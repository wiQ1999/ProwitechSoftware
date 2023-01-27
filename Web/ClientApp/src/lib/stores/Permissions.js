import {
  genericPost,
  genericGetById
} from "../js-lib/httpMethods";
import { handleError } from "../js-lib/errors";

export async function postOrPutForRole(roleId, dto) {
  try {
    const response = await genericPost("/Permissions/Role/" + roleId, dto);
    return await response.json();
  } catch (err) {
    handleError(err, "Aktualziacja uprawnień dla roli.");
  }
}

export async function getForRole(roleId) {
  try {
    const response = await genericGetById("/Permissions/Role", roleId);
    return await response.json();
  }
  catch (err) {
    handleError(err, "Pobieranie uprawnień dla roli.");
  }
}

export async function postOrPutForUser(userId, dto) {
  try {
    const response = await genericPost("/Permissions/User/" + userId, dto);
    return await response.json();
  } catch (err) {
    handleError(err, "Aktualziacja uprawnień dla użytkownika.");
  }
}

export async function getForUser(userId) {
  try {
    const response = await genericGetById("/Permissions/User", userId);
    return await response.json();
  }
  catch (err) {
    handleError(err, "Pobieranie uprawnień dla użytkownika.");
  }
}
