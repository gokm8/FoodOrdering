import { defineConfig } from 'vite';
import plugin from '@vitejs/plugin-react';

export default defineConfig({
    plugins: [plugin()],
    server: {
        port: 64630,
        proxy: {
            '/api': {
                target: 'https://localhost:7143',
                changeOrigin: true,
                secure: false,
            },
        },
    },
});