import {
  genericPost,
  genericGetAll,
  genericGetById,
  genericPut,
  genericDelete
} from "../js-lib/httpMethods";
import { handleError } from "../js-lib/errors";

export async function postUser(userDto) {
  try {
    const response = await genericPost("/Users", userDto);
    return response.json();
  } catch (err) {
    handleError(err, "dodawanie Użytkownika");
    return err;
  }
}

export async function getAllUsers() {
  try {
    const response = await genericGetAll("/Users");
    return await response.json();
  }
  catch (err) {
    handleError(err, "pobieranie wszystkich Użytkowników");
    return err;
  }
}

export async function getUserById(userId) {
  try {
    const response = await genericGetById("/Users", userId);
    return response.json();
  } catch (err) {
    handleError(err, "pobieranie Użytkownika na podstawie ID");
  }
}

export async function putUser(id, user) {
  try {
    const response = await genericPut("/Users", id, user);
    return response.json();
  } catch (err) {
    handleError(err, "Aktualizacja Użytkownika");
    return err;
  }
}

export async function putUserPassword(id, pwdDto) {
  try {
    const response = await genericPut("/Users/Security", id, pwdDto);
    return response.json();
  } catch (err) {
    handleError(err, "Aktualizacja hasła Użytkownika");
    return err;
  }
}

export async function deleteUser(id) {
  try {
    const response = await genericDelete("/Users", id);
    return await response.json();
  } catch (err) {
    handleError(err, "usuwanie Użytkownika na podstawie ID");
    return err;
  }
}






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
