import Cookies from "js-cookie"
import jwt_decode from "jwt-decode"

const cookieName = 'token';
const minDate = Date.UTC(1970, 0, 1)

export function setToken(token) {
    const decoded = jwt_decode(token)

    if (decoded.exp === undefined) return

    let expDate = new Date(minDate)
    expDate.setSeconds(decoded.exp)

    Cookies.set(cookieName, token, { expires: expDate })
}

export function getToken() {
    const decoded = getAndDecodeToken()

    const expiryDate = new Date(minDate)
    expiryDate.setSeconds(decoded.exp)

    return {
        id: decoded.id,
        login: decoded.login,
        firstName: decoded.firstName,
        lastName: decoded.lastName,
        roleId: decoded.roleId,
        roleName: decoded.roleName,
        permissions: decoded.properties,
        expiryDate: expiryDate
    }
}

function getAndDecodeToken() {
    const token = Cookies.get(cookieName)
    if (token === undefined) return

    return jwt_decode(token)
}

export function readPermissionPropertiesFor(source) { // TODO
    const decoded = getAndDecodeToken()
    if (decoded === undefined) return

    const filtered = decoded.permissions.filter(perm => {
        const splited = perm.split("_")

        console.log(splited)

        if (splited.length != 2 || splited[0] !== source) return false
        return true
    })

    return filtered
}

export function clearToken() {
    const expDate = new Date(minDate);
    Cookies.set(cookieName, '', { expires: expDate })
}