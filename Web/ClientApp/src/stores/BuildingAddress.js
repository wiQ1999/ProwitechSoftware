import { handleError } from "../js-lib/errors.js";
import {
  genericPost,
  genericDelete,
  genericGetById,
  genericPut,
} from "../js-lib/httpMethods.js";
import { AddUpdateBuildingAddressRequestResult } from "../js-lib/helpers";
export async function getBuildingAddressById(id) {
  let response;
  try {
    response = await genericGetById("/BuildingAddress", id);
    return response;
  } catch (err) {
    handleError(err, "pobieranie Adresu Budynku na podstawie ID");
    return err;
  }
}

export async function deleteBuildingAddress(id) {
  let response;
  try {
    response = await genericDelete("/BuildingAddress", id);
    return response;
  } catch (err) {
    handleError(err, "usuwanie Adresu Budynku");
    return err;
  }
}
export async function updateBuildingAddressAgain(
  updateBuildingAddressDTO,
  optionalArguments,
  onlyAddress = false
) {
  if (onlyAddress) {
    updateBuildingAddressDTO.longitude = null;
    updateBuildingAddressDTO.latitude = null;
  }
  return await putBuildingAddress(
    updateBuildingAddressDTO.id,
    updateBuildingAddressDTO,
    optionalArguments
  );
}
export async function putBuildingAddress(
  id,
  buldingAddressDTO,
  optionalParameters = null
) {
  let response;
  try {
    response = await genericPut(
      "/BuildingAddress",
      id,
      buldingAddressDTO,
      optionalParameters
    );
    return response;
  } catch (err) {
    handleError(err, "edycja Adresu Budynku");
    return err;
  }
}
export async function tryToUpdateBuildingAddress(updateBuildingAddressDTO) {
  updateBuildingAddressDTO.longitude = null;
  updateBuildingAddressDTO.latitude = null;

  let updateBuildingAddressResult = await putBuildingAddress(
    updateBuildingAddressDTO.id,
    updateBuildingAddressDTO
  );
  if (updateBuildingAddressResult instanceof Response) {
    let updateBuildingAddressJSON = await updateBuildingAddressResult.json();
    if (updateBuildingAddressJSON.webApiStatus == "ADDED_TO_DB") {
      return AddUpdateBuildingAddressRequestResult.success;
    } else if (updateBuildingAddressJSON.webApiStatus == "OVER_QUERY_LIMIT") {
      return AddUpdateBuildingAddressRequestResult.overQueryLimit;
    } else {
      return updateBuildingAddressJSON;
    }
  } else {
    return AddUpdateBuildingAddressRequestResult.error;
  }
}

export async function postBuildingAddress(postBody, optionalArguments = null) {
  let response;
  try {
    response = await genericPost(
      "/BuildingAddress",
      postBody,
      optionalArguments
    );
    return response;
  } catch (err) {
    handleError(err, "dodawanie nowego Adresu Budynku");
    return err;
  }
}
export async function postBuildingAddressAgain(
  addedBuildingAddress,
  optionalArguments,
  onlyAddress = false
) {
  //specjalnie błąd dla sprawdzenia
  // addedBuildingAddress.cityName = "";
  let postResponse;
  if (onlyAddress)
    postResponse = await postBuildingAddressOnly(
      addedBuildingAddress,
      optionalArguments
    );
  else
    postResponse = await postBuildingAddressWithLongAndLat(
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
export function checkIfUpdatedBuildingAddressAndOriginalBuildingAddressDiffer(
  updateBuildingAddressDTO,
  originalBuildingAddressDTO
) {
  if (
    updateBuildingAddressDTO.cityName != originalBuildingAddressDTO.cityName ||
    updateBuildingAddressDTO.streetName !=
      originalBuildingAddressDTO.streetName ||
    updateBuildingAddressDTO.buildingNumber !=
      originalBuildingAddressDTO.buildingNumber
  )
    return true;
  return false;
}
