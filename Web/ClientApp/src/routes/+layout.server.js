import { redirect } from '@sveltejs/kit'

/** @type {import('./$types').LayoutServerLoad} */
export async function load({ url, cookies }) {
    if (url.pathname === "/login")
        return

    const token = cookies.get('token')
    if (token === undefined) {
        throw redirect(307, '/login')
    }
}