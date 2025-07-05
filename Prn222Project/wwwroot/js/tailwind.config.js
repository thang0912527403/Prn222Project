module.exports = {
    darkMode: 'class',
    content: [
        './Views/**/*.cshtml',
        './Pages/**/*.cshtml',
        './wwwroot/**/*.html'
    ],
    theme: {
        extend: {
            colors: {
                primary: '#6366f1',
                secondary: '#8b5cf6',
                accent: '#06b6d4',
                dark: '#0f172a',
                'dark-light': '#1e293b'
            },
            fontFamily: {
                sans: ['Inter', 'system-ui', 'sans-serif'],
                decorative: ['"Pacifico"', 'cursive']
            }
        }
    },
    plugins: []
};
