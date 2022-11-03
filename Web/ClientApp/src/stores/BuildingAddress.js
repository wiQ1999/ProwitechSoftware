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
      // alert(
      //   `Błąd HTTP przy wysyłaniu danych!\nInformacje o błędzie:\n${err.message}`
      // );
    }
    // else alert(`Wystąpił inny błąd: ${err.message}\n${err.stack}`);
    return err;
  }
}
export async function postBuildingAddressAgain(
  addedBuildingAddress,
  optionalArguments,
  onlyAddress = false
) {
  let postResponse;
  if (onlyAddress)
    postResponse = postBuildingAddressOnly(
      addedBuildingAddress,
      optionalArguments
    );
  else
    postResponse = postBuildingAddressWithLongAndLat(
      addedBuildingAddress,
      optionalArguments
    );
  return postResponse;
}

async function postBuildingAddressOnly(
  addedBuildingAddress,
  optionalArguments
) {
  let addBuildingAddressDTOagain = {
    cityName: "",
    streetName: "",
    buildingNumber: "",
  };
  let response;
  addBuildingAddressDTOagain.cityName = addedBuildingAddress.cityName;
  addBuildingAddressDTOagain.streetName = addedBuildingAddress.streetName;
  addBuildingAddressDTOagain.buildingNumber =
    addedBuildingAddress.buildingNumber;

  response = await postBuildingAddress(
    addBuildingAddressDTOagain,
    optionalArguments
  );
  return response;
}
async function postBuildingAddressWithLongAndLat(
  addedBuildingAddress,
  optionalArguments
) {
  let addBuildingAddressDTOWithLongAndLat = {
    cityName: "",
    streetName: "",
    buildingNumber: "",
    longitude: 0.0,
    latitude: 0.0,
  };
  let response;
  addBuildingAddressDTOWithLongAndLat.cityName = addedBuildingAddress.cityName;
  addBuildingAddressDTOWithLongAndLat.streetName =
    addedBuildingAddress.streetName;
  addBuildingAddressDTOWithLongAndLat.buildingNumber =
    addedBuildingAddress.buildingNumber;
  addBuildingAddressDTOWithLongAndLat.longitude =
    addedBuildingAddress.longitude;
  addBuildingAddressDTOWithLongAndLat.latitude = addedBuildingAddress.latitude;

  response = await postBuildingAddress(
    addBuildingAddressDTOWithLongAndLat,
    optionalArguments
  );
  return response;
}
