/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./**/*.{razor,html}"],
  theme: {
    extend: {
        colors: {
            primary: "#1d4c43",
            secondary: "#e6fd99",
        },
    },
  },
  plugins: [],
};
