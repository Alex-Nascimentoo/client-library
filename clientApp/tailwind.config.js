/** @type {import('tailwindcss').Config} */
export default {
  content: [
    "./index.html",
    "./src/**/*.{js,ts,jsx,tsx}"
  ],
  theme: {
    extend: {
      boxShadow: {
        'lg': '10px 10px 15px -3px rgb(0 0 0 / 0.1), -10px 4px 6px -4px rgb(0 0 0 / 0.1);'
      }
    },
  },
  plugins: [],
}

