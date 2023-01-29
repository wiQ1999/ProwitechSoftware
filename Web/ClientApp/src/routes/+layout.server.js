import { redirect } from '@sveltejs/kit'

/** @type {import('./$types').LayoutServerLoad} */
export async function load({ url, cookies }) {
    const token = cookies.get('token')

    if (token === undefined) {
        if (isLoginPath(url))
            return
        throw redirect(307, '/login')
    }
    else if (isLoginPath(url)) {
        throw redirect(307, '/')
    }
}

function isLoginPath(url) {
    return url.pathname === "/login"
}