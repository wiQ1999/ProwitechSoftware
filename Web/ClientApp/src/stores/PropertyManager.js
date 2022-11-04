import { writable } from "svelte/store";
import { genericGetById, genericPost } from "../js-lib/httpMethods";
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
  let getPropertyManagerByIdResult = await genericGetById(
    "/PropertyManager",
    propertyManagerId
  );
  return getPropertyManagerByIdResult;
}
