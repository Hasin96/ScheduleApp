module.exports = {
    purge: {
        enabled: false,
        content: [
            './Views/**/*.cshtml'
        ]
    },
  darkMode: false, // or 'media' or 'class'
    theme: {
        fontSize: {
            base: '62.5%',
            'sm': '1.4rem',
            'md': '1.6rem',
            'lg': '2rem'
        },
        fontFamily: {
            roboto: ['roboto', 'sans-serif']
        },
        colors: {
            white:'#fff',
            gray: '#627D98',
            'gray-lightest': '#F0F4F8',
            'gray-darkest': '#102A43',
            'gray-dark': '#486581',
            'primary-darkest': '#003e6b',
            'primary-dark': '#0F609B',
            'primary': '#186FAF',
            'primary-light': '#4098D7',
            'primary-lighter':'#B6E0FE',
            'primary-lightest': '#DCEEFB'
        },
        extend: {
            spacing: {
                136: '34rem',
                168: '42rem'
            },
            flex: {
                fixed: '0 0 7rem',
                fluid: '1 1 24rem'
            }
        },
  },
  variants: {
      extend: {
          cursor: ['hover'],
          backgroundColor: ['group-focus'],
          textColor: ['group-focus']
      },
      animation: ['responsive', 'motion-safe', 'motion-reduce']
  },
  plugins: [],
}
