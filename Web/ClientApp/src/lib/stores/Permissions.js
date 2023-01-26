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
    handleError(err, "Dodawanie Roli");
    return err;
  }
}

export async function getForRole(roleId) {
  try {
    const response = await genericGetById("/Permissions/Role", roleId);
    return await response.json();
  }
  catch (err) {
    handleError(err, "Pobieranie wszystkich Ról");
    return err;
  }
}
