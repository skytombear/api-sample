const js = require('@eslint/js');
const globals = require('globals');
const prettierRecommended = require('eslint-plugin-prettier/recommended');

// Flat config (ESLint 9+). Replaces the legacy .eslintrc.json / .eslintignore.
// Prettier options continue to be read from .prettierrc.
module.exports = [
  {
    ignores: ['node_modules/**'],
  },
  js.configs.recommended,
  prettierRecommended,
  {
    languageOptions: {
      ecmaVersion: 2022,
      sourceType: 'commonjs',
      globals: {
        ...globals.node,
      },
    },
  },
];
