import {
  genericDelete,
  genericGetAll,
  genericGetById,
  genericPost,
  genericPut,
} from "$lib/js-lib/httpMethods";
import { handleError } from "$lib/js-lib/errors";

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
    return getPropertyManagerByIdResult;
  } catch (err) {
    handleError(err, "pobieranie Zarządcy Nieruchomości na podstawie ID");
    return err;
  }
}
export async function getAllPropertyManagers() {
  let response;
  try {
    response = await genericGetAll("/PropertyManager");
    return response;
  } catch (err) {
    handleError(err, "pobieranie wszystkich Zarządców Nieruchomości");
    return err;
  }
}
export async function deletePropertyManager(id) {
  let response;
  try {
    response = await genericDelete("/PropertyManager", id);
    return response;
  } catch (err) {
    handleError(err, "usuwanie Zarządcy Nieruchomości na podstawie ID");
    return err;
  }
}
export function checkIfPropManagersDiffer(newPropMan, oldPropMan) {
  let namesDiffer = !(newPropMan.name == oldPropMan.name);
  let phoneNumbersDiffer = !(newPropMan.phoneNumber == oldPropMan.phoneNumber);
  let propertyAddressesDiffer;

  if (
    oldPropMan.fullAddress.propertyAddress == null &&
    newPropMan.fullAddress.propertyAddress.venueNumber == null &&
    newPropMan.fullAddress.propertyAddress.staircaseNumber == null
  ) {
    propertyAddressesDiffer = false;
  } else if (
    oldPropMan.fullAddress.propertyAddress != null &&
    oldPropMan.fullAddress.propertyAddress.venueNumber ==
      newPropMan.fullAddress.propertyAddress.venueNumber &&
    oldPropMan.fullAddress.propertyAddress.staircaseNumber ==
      newPropMan.fullAddress.propertyAddress.staircaseNumber
  ) {
    propertyAddressesDiffer = false;
  } else {
    propertyAddressesDiffer = true;
  }
  if (namesDiffer || phoneNumbersDiffer || propertyAddressesDiffer) {
    return true;
  }
  return false;
}
function prepareUpdatePropertyManagerCommand(newPropertyManagerDTO) {
  let updatePropertyManagerCommand;
  if (
    newPropertyManagerDTO.fullAddress.propertyAddress.venueNumber != "" ||
    newPropertyManagerDTO.fullAddress.propertyAddress.staircaseNumber != ""
  ) {
    updatePropertyManagerCommand = {
      id: newPropertyManagerDTO.id,
      name: newPropertyManagerDTO.name,
      phoneNumber: newPropertyManagerDTO.phoneNumber,
      updateFullAddressDTO: {
        buildingAddressId: newPropertyManagerDTO.fullAddress.buildingAddressId,
        propertyAddress: {
          venueNumber:
            newPropertyManagerDTO.fullAddress.propertyAddress.venueNumber,
          staircaseNumber:
            newPropertyManagerDTO.fullAddress.propertyAddress.staircaseNumber,
        },
      },
    };
  } else {
    updatePropertyManagerCommand = {
      id: newPropertyManagerDTO.id,
      name: newPropertyManagerDTO.name,
      phoneNumber: newPropertyManagerDTO.phoneNumber,
      updateFullAddressDTO: {
        buildingAddressId: newPropertyManagerDTO.fullAddress.buildingAddressId,
      },
    };
  }
  return updatePropertyManagerCommand;
}
export async function updatePropertyManager(newPropertyManagerDTO) {
  let updatePropertyManagerCommand = prepareUpdatePropertyManagerCommand(
    newPropertyManagerDTO
  );
  let propManGotUpdated = await putPropertyManager(
    updatePropertyManagerCommand.id,
    updatePropertyManagerCommand
  );
  if (propManGotUpdated instanceof Response) {
    return true;
  }
  return false;
}
