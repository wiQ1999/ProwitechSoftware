import { writable } from "svelte/store";
import { handleError } from "../js-lib/errors.js";
import { genericPost } from "../js-lib/httpMethods.js";

export const addBuildingAddressDTO = writable({
  cityName: "",
  streetName: "",
  buildingNumber: "",
});

export async function deleteBuildingAddress(id) {
  let response;
  try {
    response = await genericDelete("/BuildingAddress", id);
    return response;
  } catch (err) {
    return err;
  }
}

export async function postBuildingAddress(postBody, optionalArguments) {
  let response;
  try {
    response = await genericPost(
      "/BuildingAddress",
      postBody,
      optionalArguments
    );
    return response;
  } catch (err) {
    handleError(err, "dodawanie nowego adresu budynku");
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
    cityName: addedBuildingAddress.cityName,
    streetName: addedBuildingAddress.streetName,
    buildingNumber: addedBuildingAddress.buildingNumber,
  };
  let response;
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
    cityName: addedBuildingAddress.cityName,
    streetName: addedBuildingAddress.streetName,
    buildingNumber: addedBuildingAddress.buildingNumber,
    longitude: addedBuildingAddress.longitude,
    latitude: addedBuildingAddress.latitude,
  };
  let response;
  response = await postBuildingAddress(
    addBuildingAddressDTOWithLongAndLat,
    optionalArguments
  );
  return response;
}
