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
                'dark-light': '#1e293b',
                'dark-2': '#24303f',
                'dark-3': '#313d4a',
                'dark-4': '#1a222c',
                'dark-5': '#313d4a',
                'dark-6': '#24303f',
                'dark-7': '#1c2434',
                'body-dark': '#aeb7c0',
                'body-dark-2': '#8a99af',
                'stroke-dark': '#2e3a47',
                'gray-dark': '#5d6d7e',
            },
            fontFamily: {
                sans: ['Inter', 'system-ui', 'sans-serif'],
                decorative: ['"Pacifico"', 'cursive']
            }
        }
    },
    plugins: []
};
