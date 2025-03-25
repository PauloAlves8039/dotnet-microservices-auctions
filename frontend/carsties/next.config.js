/** @type {import('next').NextConfig} */
const nextConfig = {
    experimental: {
        serverActions: true,
    },
    logging: {
        fetches: {
            fullUrl: true
        }
    },
    images: {
        remotePatterns: [
            { protocol: "https", hostname: "cdn.pixabay.com" }
        ]
    }
}

module.exports = nextConfig;

