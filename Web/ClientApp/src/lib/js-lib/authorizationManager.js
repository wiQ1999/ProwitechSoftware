import Cookies from "js-cookie"
import jwt_decode from "jwt-decode"

const minDate = Date.UTC(1970, 0, 1)

export function setToken(token) {
    const decoded = jwt_decode(token)

    if (decoded.exp === undefined) return

    let expDate = new Date(minDate)
    expDate.setSeconds(decoded.exp)

    setCookieWithToken(token, expDate);
}

function setCookieWithToken(token, expDate) {
    Cookies.set('token', token, { expires: expDate })
}

export function getToken() {
    const token = Cookies.get('token')
    const decoded = jwt_decode(token)

    return token; // ToDo
}

export function clearToken() {
    const expDate = new Date(minDate);
    setCookieWithToken('', expDate)
}