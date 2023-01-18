import Cookies from "js-cookie"
import jwt_decode from "jwt-decode"

export function setToken(token) {
    let decode = jwt_decode(token);
    console.log(decode)

    if (decode.exp === undefined) return
    console.log(decode.exp)

    let date = new Date(1970, 0, 1);
    date.setSeconds(decode.exp)

    console.log(date)

    Cookies.set('token', token, { expires: date });
}

export function getToken() {
    console.log("getToken")
}

export function clearToken() {
    console.log("clearToken")
}