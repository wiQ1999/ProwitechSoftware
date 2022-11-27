import {
  genericPost,
  genericGetAll,
  genericGetById,
  genericPut,
  genericDelete
} from "../js-lib/httpMethods";
import { handleError } from "../js-lib/errors";

export async function postRole(roleName) {
  try {
    const response = await genericPost("/Roles", null, { name: roleName });
    return await response.json();
  } catch (err) {
    handleError(err, "Dodawanie Roli");
    return err;
  }
}

export async function getAllRoles() {
  try {
    const response = await genericGetAll("/Roles");
    return await response.json();
  }
  catch (err) {
    handleError(err, "Pobieranie wszystkich Ról");
  }
}

export async function getRole(id) {
  try {
    const response = await genericGetById("/Roles", id);
    return await response.json();
  } catch (err) {
    handleError(err, "Pobieranie Roli");
  }
  return getPropertyManagerByIdResult;
}

export async function putRole(id, roleDto) {
  try {
    let response = await genericPut("/Role", id, roleDto);
    return await response.json();
  } catch (err) {
    handleError(err, "Aktualizacja Roli");
    return err;
  }
}

export async function deleteRole(id) {
  try {
    const response = await genericDelete("/Roles", id);
    return await response.json();
  } catch (err) {
    handleError(err, "Usuwanie Roli na podstawie ID");
  }
  return response;
}
