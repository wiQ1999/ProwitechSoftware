import {
  genericGetAll,
  genericDelete,
  genericGetById,
  genericPost,
  genericPut,
} from "../js-lib/httpMethods";
import { handleError } from "../js-lib/errors";

export async function getAllRoles() {
  try {
    const response = await genericGetAll("/Roles");
    return await response.json();
  }
  catch (err) {
    handleError(err, "pobieranie wszystkich Ról");
  }
}

export async function postRole(roleDto) {
  try {
    const response = await genericPost("/Roles", roleDto);
    return await response.json();
  } catch (err) {
    handleError(err, "dodawanie Roli");
    return err;
  }
}

export async function delteRole(id) {
  try {
    const response = await genericDelete("/Roles", id);
    return await response.json();
  } catch (err) {
    handleError(err, "usuwanie Roli na podstawie ID");
  }
  return response;
}



// export async function postPropertyManager(propertyManager) {
//   let response;
//   try {
//     response = await genericPost("/PropertyManager", propertyManager);
//     return response;
//   } catch (err) {
//     handleError(err, "dodawanie Zarządcy Nieruchomości");
//     return err;
//   }
// }

// export async function putPropertyManager(id, propertyManager) {
//   let response;
//   try {
//     response = await genericPut("/PropertyManager", id, propertyManager);
//     return response;
//   } catch (err) {
//     handleError(err, "Aktualizacja Zarządcy Nieruchomości");
//     return err;
//   }
// }

// export async function getPropertyManagerById(propertyManagerId) {
//   let getPropertyManagerByIdResult;
//   try {
//     getPropertyManagerByIdResult = await genericGetById(
//       "/PropertyManager",
//       propertyManagerId
//     );
//   } catch (err) {
//     handleError(err, "pobieranie Zarządcy Nieruchomości na podstawie ID");
//   }
//   return getPropertyManagerByIdResult;
// }

// export async function deletePropertyManager(id) {
//   let response;
//   try {
//     response = await genericDelete("/PropertyManager", id);
//   } catch (err) {
//     handleError(err, "usuwanie Zarządcy Nieruchomości na podstawie ID");
//   }
//   return response;
// }

// export function checkIfPropManagersDiffer(newPropMan, oldPropMan) {
//   if (
//     newPropMan.name != oldPropMan.name ||
//     newPropMan.phoneNumber != oldPropMan.phoneNumber ||
//     newPropMan.fullAddress.localNumber != oldPropMan.fullAddress.localNumber ||
//     newPropMan.fullAddress.staircaseNumber !=
//     oldPropMan.fullAddress.staircaseNumber
//   )
//     return true;
//   return false;
// }

// export async function updatePropertyManager(newPropertyManagerDTO) {
//   let propertyManagerPutBody = {
//     id: newPropertyManagerDTO.id,
//     name: newPropertyManagerDTO.name,
//     phoneNumber: newPropertyManagerDTO.phoneNumber,
//     updateFullAddressDTO: {
//       buildingAddressId: newPropertyManagerDTO.fullAddress.buildingAddressId,
//       localNumber: newPropertyManagerDTO.fullAddress.localNumber,
//       staircaseNumber: newPropertyManagerDTO.fullAddress.staircaseNumber,
//     },
//   };
//   let propManGotUpdated = await putPropertyManager(
//     propertyManagerPutBody.id,
//     propertyManagerPutBody
//   );
//   if (propManGotUpdated instanceof Response) {
//     return true;
//   }
//   return false;
// }
