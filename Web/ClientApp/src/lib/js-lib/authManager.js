import Cookies from "js-cookie"
import jwt_decode from "jwt-decode"

const cookieName = 'token';
const minDate = Date.UTC(1970, 0, 1)

/**
 * Sets given JWT token in cookies.
 * @param {string} token - encrypted JWT token.
 */
export function setToken(token) {
    const decoded = jwt_decode(token)

    if (decoded.exp === undefined) return

    let expDate = new Date(minDate)
    expDate.setSeconds(decoded.exp)

    Cookies.set(cookieName, token, { expires: expDate })
}

/**
 * Gets and decodes JWT token from cookies.
 * @returns {object|undefined} decoded JWT token if exist.
 */
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
        permissions: decoded.permissions,
        expiryDate: expiryDate
    }
}

function getAndDecodeToken() {
    const token = Cookies.get(cookieName)
    if (token === undefined) return

    return jwt_decode(token)
}

/**
 * Searches for permissions properties in decrypted JWT token.
 * @param {string} source - application source name searched for.
 * @returns {array} array with permission propertie names.
 */
export function getPermissionsFor(source) {
    let result = []

    const decoded = getAndDecodeToken()
    if (decoded === undefined) return result

    for (let i = 0; i < decoded.permissions.length; i++) {
        const permission = decoded.permissions[i];
        const splited = permission.split("_")

        if (splited.length != 2 || splited[0] !== source) continue

        result.push(splited[1])
    }

    return result
}

/**
 * Checks if decrypted JWT token include create permission property.
 * @param {string} source - application source name searched for.
 * @returns {boolean} true if include.
 */
export function hasCreatePermissionFor(source) {
    return getPermissionsFor(source).includes("create")
}

/**
 * Checks if decrypted JWT token include read permission property.
 * @param {string} source - application source name searched for.
 * @returns {boolean} true if include.
 */
export function hasReadPermissionFor(source) {
    return getPermissionsFor(source).includes("read")
}

/**
 * Checks if decrypted JWT token include update permission property.
 * @param {string} source - application source name searched for.
 * @returns {boolean} true if include.
 */
export function hasUpdatePermissionFor(source) {
    return getPermissionsFor(source).includes("update")
}

/**
 * Checks if decrypted JWT token include delete permission property.
 * @param {string} source - application source name searched for.
 * @returns {boolean} true if include.
 */
export function hasDeletePermissionFor(source) {
    return getPermissionsFor(source).includes("delete")
}

/**
 * Deletes JWT token from cookies, even if not exist.
 */
export function clearToken() {
    const expDate = new Date(minDate);
    Cookies.set(cookieName, '', { expires: expDate })
}