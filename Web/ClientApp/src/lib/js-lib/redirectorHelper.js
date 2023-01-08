import { goto } from "$app/navigation";

export function goBack(page) {
    const lastSlash = page.url.pathname.lastIndexOf("/");
    const newUrl = page.url.pathname.substring(0, lastSlash);
    goto(newUrl);
}