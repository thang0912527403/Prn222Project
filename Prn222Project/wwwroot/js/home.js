// === Carousel Logic ===
(function () {
    let currentSlide = 0;
    const totalSlides = 3;
    const slideTrack = document.getElementById('slideTrack');
    const indicators = document.querySelectorAll('.slide-indicator');
    const prevBtn = document.getElementById('prevBtn');
    const nextBtn = document.getElementById('nextBtn');
    let autoSlideTimer;

    function updateSlide() {
        slideTrack.style.transform = `translateX(-${currentSlide * 100}%)`;
        indicators.forEach((indicator, index) =>
            indicator.classList.toggle('active', index === currentSlide)
        );
    }

    function nextSlide() {
        currentSlide = (currentSlide + 1) % totalSlides;
        updateSlide();
        resetAutoSlide();
    }

    function prevSlide() {
        currentSlide = (currentSlide - 1 + totalSlides) % totalSlides;
        updateSlide();
        resetAutoSlide();
    }

    function resetAutoSlide() {
        clearInterval(autoSlideTimer);
        autoSlideTimer = setInterval(nextSlide, 4000);
    }

    // Touch & mouse drag
    let startX = 0, isDragging = false;
    const handleDrag = (endX) => {
        const diffX = startX - endX;
        if (Math.abs(diffX) > 50) diffX > 0 ? nextSlide() : prevSlide();
    };

    slideTrack.addEventListener('touchstart', (e) => { startX = e.touches[0].clientX; isDragging = true; });
    slideTrack.addEventListener('touchend', (e) => { if (isDragging) handleDrag(e.changedTouches[0].clientX); isDragging = false; });

    slideTrack.addEventListener('mousedown', (e) => { startX = e.clientX; isDragging = true; slideTrack.style.cursor = 'grabbing'; });
    document.addEventListener('mouseup', (e) => { if (isDragging) handleDrag(e.clientX); isDragging = false; slideTrack.style.cursor = 'grab'; });

    slideTrack.addEventListener('mouseenter', () => clearInterval(autoSlideTimer));
    slideTrack.addEventListener('mouseleave', resetAutoSlide);

    nextBtn?.addEventListener('click', nextSlide);
    prevBtn?.addEventListener('click', prevSlide);
    document.addEventListener('keydown', (e) => {
        if (e.key === 'ArrowRight') nextSlide();
        else if (e.key === 'ArrowLeft') prevSlide();
    });

    // Init
    updateSlide();
    resetAutoSlide();
})();

// === Smooth Scroll & Scroll Animation ===
(function () {
    document.querySelectorAll('a[href^="#"]').forEach(anchor => {
        anchor.addEventListener('click', function (e) {
            e.preventDefault();
            const target = document.querySelector(this.getAttribute('href'));
            if (target) {
                target.scrollIntoView({ behavior: 'smooth', block: 'start' });
            }
        });
    });

    const observer = new IntersectionObserver(entries => {
        entries.forEach(entry => {
            if (entry.isIntersecting) entry.target.classList.add('slide-up');
        });
    }, { threshold: 0.1, rootMargin: '0px 0px -50px 0px' });

    document.querySelectorAll('.crypto-card, .crypto-card-dark').forEach(el => observer.observe(el));
})();

// === Dark Mode Toggle ===
(function () {
    const btn = document.getElementById('toggleDark');
    const html = document.documentElement;
    btn?.addEventListener('click', () => html.classList.toggle('dark'));
})();

// === Mobile Menu Toggle ===
(function () {
    const btn = document.querySelector('[aria-controls="mobile-menu"]');
    const menu = document.getElementById('mobile-menu');
    if (!btn || !menu) return;

    const [openIcon, closeIcon] = btn.querySelectorAll('svg');
    btn.addEventListener('click', () => {
        const isExpanded = menu.classList.toggle('hidden');
        openIcon?.classList.toggle('hidden');
        closeIcon?.classList.toggle('hidden');
        btn.setAttribute('aria-expanded', (!isExpanded).toString());
    });
})();

// === Modal Logic ===
(function () {
    window.openModal = () => document.getElementById('authModal')?.classList.remove('hidden');
    window.closeModal = () => document.getElementById('authModal')?.classList.add('hidden');

    window.addEventListener('click', (e) => {
        const modal = document.getElementById('authModal');
        if (e.target === modal) closeModal();
    });
})();
