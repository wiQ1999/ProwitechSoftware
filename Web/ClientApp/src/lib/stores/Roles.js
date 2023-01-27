import {
  genericPost,
  genericGetAll,
  genericGetById,
  genericPut,
  genericDelete
} from "../js-lib/httpMethods";
import { handleError } from "../js-lib/errors";

export async function postRole(name) {
  try {
    const response = await genericPost("/Roles", null, { name: name });
    return await response.json();
  } catch (err) {
    handleError(err, "Dodawanie Roli");
  }
}

export async function getAllRoles() {
  try {
    const response = await genericGetAll("/Roles");
    return await response.json();
  } catch (err) {
    handleError(err, "Pobieranie wszystkich Ról");
  }
}

export async function getRoleById(id) {
  try {
    const response = await genericGetById("/Roles", id);
    return await response.json();
  } catch (err) {
    handleError(err, "Pobieranie Roli na podstawie ID");
  }
}

export async function putRole(id, roleDto) {
  try {
    const response = await genericPut("/Roles", id, roleDto);
    return await response.json();
  } catch (err) {
    handleError(err, "Aktualizacja Roli");
  }
}

export async function deleteRole(id) {
  try {
    const response = await genericDelete("/Roles", id);
    return await response.json();
  } catch (err) {
    handleError(err, "Usuwanie Roli na podstawie ID");
  }
}
