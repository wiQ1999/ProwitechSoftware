import {
  genericDelete,
  genericGetAll,
  genericGetById,
  genericPost,
  genericPut,
} from "../js-lib/httpMethods";
import { handleError } from "../js-lib/errors";

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
export async function putPropertyManager(id, propertyManager) {
  let response;
  try {
    response = await genericPut("/PropertyManager", id, propertyManager);
    return response;
  } catch (err) {
    handleError(err, "Aktualizacja Zarządcy Nieruchomości");
    return err;
  }
}
export async function getPropertyManagerById(propertyManagerId) {
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
export function checkIfPropManagersDiffer(newPropMan, oldPropMan) {
  if (
    newPropMan.name != oldPropMan.name ||
    newPropMan.phoneNumber != oldPropMan.phoneNumber ||
    newPropMan.fullAddress.localNumber != oldPropMan.fullAddress.localNumber ||
    newPropMan.fullAddress.staircaseNumber !=
      oldPropMan.fullAddress.staircaseNumber
  )
    return true;
  return false;
}
// STRUKTURA UpdatePropertyManagerCommand
// {
//   "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
//   "name": "string",
//   "phoneNumber": "string",
//   "updateFullAddressDTO": {
//     "buildingAddressId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
//     "localNumber": "string",
//     "staircaseNumber": "string"
//   }
// }
export async function updatePropertyManager(newPropertyManagerDTO) {
  let propertyManagerPutBody = {
    id: newPropertyManagerDTO.id,
    name: newPropertyManagerDTO.name,
    phoneNumber: newPropertyManagerDTO.phoneNumber,
    updateFullAddressDTO: {
      buildingAddressId: newPropertyManagerDTO.fullAddress.buildingAddressId,
      localNumber: newPropertyManagerDTO.fullAddress.localNumber,
      staircaseNumber: newPropertyManagerDTO.fullAddress.staircaseNumber,
    },
  };
  let propManGotUpdated = await putPropertyManager(
    propertyManagerPutBody.id,
    propertyManagerPutBody
  );
  if (propManGotUpdated instanceof Response) {
    return true;
  }
  return false;
}
