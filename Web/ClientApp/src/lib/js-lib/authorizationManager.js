import Cookies from "js-cookie"
import jwt_decode from "jwt-decode"

export function setToken(token) {
    let decode = jwt_decode(token);
    console.log(decode)

    if (decode.exp === undefined) return

    Cookies.set('token', token, { expires: decode.exp });
}

export function getToken() {
    console.log("getToken")
}

export function clearToken() {
    console.log("clearToken")
}