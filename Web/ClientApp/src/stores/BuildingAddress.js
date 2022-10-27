import { writable } from "svelte/store";
import { HttpMethodError } from "../js-lib/errors.js";
import { genericPost } from "../js-lib/httpMethods.js";

export const addBuildingAddressDTO = writable({
  cityName: "",
  streetName: "",
  buildingNumber: "",
});

export async function postBuildingAddress(postBody, optionalArguments) {
  let response;
  try {
    let response = await genericPost(
      "/BuildingAddress",
      postBody,
      optionalArguments
    );
    return response;
  } catch (err) {
    if (err instanceof HttpMethodError) {
      alert(
        `Błąd HTTP przy wysyłaniu danych!\nInformacje o błędzie:\n${err.message}`
      );
    } else alert(`Wystąpił inny błąd: ${err.message}\n${err.stack}`);
    return err;
  }
}
