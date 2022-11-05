import { writable } from "svelte/store";
import {
  genericDelete,
  genericGetAll,
  genericGetById,
  genericPost,
} from "../js-lib/httpMethods";
import { handleError } from "../js-lib/errors";

export const CreatePropertyManagerCommand = writable({
  name: "",
  phoneNumber: "",
  fullAddressDTO: {
    buildingAddressId: "",
    localNumber: "",
    staircaseNumber: "",
  },
});
export async function postPropertyManager(propertyManager) {
  let response;
  try {
    response = await genericPost("/PropertyManager", propertyManager);
    return response;
  } catch (err) {
    handleError(err, "dodawanie Zarządcy Nieruchomości");
    return err;
  }
}
export async function showPropertyManager(propertyManagerId) {
  let getPropertyManagerByIdResult;
  try {
    getPropertyManagerByIdResult = await genericGetById(
      "/PropertyManager",
      propertyManagerId
    );
  } catch (err) {
    handleError(err, "pobieranie Zarządcy Nieruchomości na podstawie ID");
  }
  return getPropertyManagerByIdResult;
}
export async function getAllPropertyManagers() {
  let managers;
  try {
    managers = await genericGetAll("/PropertyManager");
  } catch (err) {
    handleError(err, "pobieranie wszystkich Zarządców Nieruchomości");
  }
  return managers;
}
export async function deletePropertyManager(id) {
  let response;
  try {
    response = await genericDelete("/PropertyManager", id);
  } catch (err) {
    handleError(err, "usuwanie Zarządcy Nieruchomości na podstawie ID");
  }
  return response;
}
