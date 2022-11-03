import { writable } from "svelte/store";
import { genericGetAll, genericPost } from "../js-lib/httpMethods";

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
    return err;
  }
}
