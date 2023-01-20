import {
  genericDelete,
  genericGetAll,
  genericGetById,
  genericPost,
  genericPut,
} from "$lib/js-lib/httpMethods";
import { handleError } from "$lib/js-lib/errors";

const path = "/RealProperty";

export async function postRealProperty(CreateRealPropertyCommand) {
  let response;
  try {
    response = await genericPost(path, CreateRealPropertyCommand);
    return response;
  } catch (err) {
    handleError(err, "dodawanie Nieruchomości");
    return err;
  }
}
export async function putRealProperty(id, UpdateRealPropertyCommand) {
  let response;
  try {
    response = await genericPut(path, id, UpdateRealPropertyCommand);
    return response;
  } catch (err) {
    handleError(err, "Aktualizacja Nieruchomości");
    return err;
  }
}
export async function getRealPropertyById(id) {
  let response;
  try {
    response = await genericGetById(path, id);
    return response;
  } catch (err) {
    handleError(err, "pobieranie Nieruchomości na podstawie ID");
    return err;
  }
}
export async function getAllRealProperties() {
  let response;
  try {
    response = await genericGetAll(path);
    return response;
  } catch (err) {
    handleError(err, "pobieranie wszystkich Nieruchomości");
    return err;
  }
}
export async function deleteRealProperty(id) {
  let response;
  try {
    response = await genericDelete(path, id);
    return response;
  } catch (err) {
    let reloadRequired = true;
    handleError(err, "usuwanie Nieruchomości na podstawie ID", reloadRequired);
    return err;
  }
}

export function checkIfRealPropertiesDiffer(
  realPropertyFromGet,
  updateRealProperty
) {
  if (
    realPropertyFromGet.propertyAddress.venueNumber !=
    updateRealProperty.PropertyAddressWithVenueNumberDTO.venueNumber
  )
    return true;
  if (
    realPropertyFromGet.propertyAddress.staircaseNumber !=
    updateRealProperty.PropertyAddressWithVenueNumberDTO.staircaseNumber
  )
    return true;
  return false;
}

export function compareRealPropertiesByVenueNumber(a, b) {
  let aVenueNumber = a.propertyAddress.venueNumber;
  let bVenueNumber = b.propertyAddress.venueNumber;

  let aInt = parseInt(aVenueNumber);
  let bInt = parseInt(bVenueNumber);
  if (aInt < bInt) {
    return -1;
  }
  if (aInt > bInt) {
    return 1;
  }
  return 0;
}
