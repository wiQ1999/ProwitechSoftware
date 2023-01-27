import {
  genericPost,
  genericGetAll,
  genericGetById,
  genericPut,
  genericDelete
} from "../js-lib/httpMethods";
import { handleError } from "../js-lib/errors";

export async function postUser(userDto) {
  try {
    const response = await genericPost("/Users", userDto);
    return response.json();
  } catch (err) {
    handleError(err, "dodawanie Użytkownika");
  }
}

export async function getAllUsers() {
  try {
    const response = await genericGetAll("/Users");
    return await response.json();
  } catch (err) {
    handleError(err, "pobieranie wszystkich Użytkowników");
  }
}

export async function getUserById(userId) {
  try {
    const response = await genericGetById("/Users", userId);
    return response.json();
  } catch (err) {
    handleError(err, "pobieranie Użytkownika na podstawie ID");
  }
}

export async function putUser(id, user) {
  try {
    const response = await genericPut("/Users", id, user);
    return response.json();
  } catch (err) {
    handleError(err, "Aktualizacja Użytkownika");
  }
}

export async function putUserPassword(id, pwdDto) {
  try {
    const response = await genericPut("/Users/Security", id, pwdDto);
    return response.json();
  } catch (err) {
    handleError(err, "Aktualizacja hasła Użytkownika");
  }
}

export async function deleteUser(id) {
  try {
    const response = await genericDelete("/Users", id);
    return await response.json();
  } catch (err) {
    handleError(err, "usuwanie Użytkownika na podstawie ID");
  }
}
