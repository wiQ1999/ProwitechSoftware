import {
  genericDelete,
  genericGetAll,
  genericGetById,
  genericPost,
  genericPut,
} from "$lib/js-lib/httpMethods";
import { handleError } from "$lib/js-lib/errors";

export async function postBuilding(
  buildingAddressId,
  propertyManagerId,
  buildingType
) {
  let response;

  let createBuildingCommand;
  if (propertyManagerId == null) {
    createBuildingCommand = {
      buildingAddressId: buildingAddressId,
      type: buildingType,
    };
  } else {
    createBuildingCommand = {
      buildingAddressId: buildingAddressId,
      type: buildingType,
      propertyManagerId: propertyManagerId,
    };
  }
  try {
    response = await genericPost("/Building", createBuildingCommand);
    return response;
  } catch (err) {
    handleError(err, "dodawanie Budynku", true);
    return err;
  }
}
export async function getBuildingById(id) {
  let getBuildingByIdResult;
  try {
    getBuildingByIdResult = await genericGetById("/Building", id);
    return getBuildingByIdResult;
  } catch (err) {
    handleError(err, "pobieranie Budynku na podstawie ID");
    return err;
  }
}
export async function getAllBuildings() {
  let response;
  try {
    response = await genericGetAll("/Building");
    return response;
  } catch (err) {
    handleError(err, "pobieranie wszystkich Budynków");
    return err;
  }
}
export async function deleteBuilding(id) {
  let response;
  try {
    response = await genericDelete("/Building", id);
    return response;
  } catch (err) {
    let reloadRequired = true;
    handleError(err, "usuwanie Budynku", reloadRequired);
    return err;
  }
}
export async function updateBuilding(updateBuildingDTO) {
  let buildingGotUpdated = await putBuilding(updateBuildingDTO);
  if (buildingGotUpdated instanceof Response) {
    return true;
  }
  return false;
}
async function putBuilding(updateBuildingDTO) {
  let UpdateBuildingCommand;
  if (updateBuildingDTO.propertyManagerId) {
    UpdateBuildingCommand = {
      id: updateBuildingDTO.id,
      type: updateBuildingDTO.type,
      propertyManagerId: updateBuildingDTO.propertyManagerId,
    };
  } else {
    UpdateBuildingCommand = {
      id: updateBuildingDTO.id,
      type: updateBuildingDTO.type,
    };
  }

  let response;
  try {
    response = await genericPut(
      "/Building",
      UpdateBuildingCommand.id,
      UpdateBuildingCommand
    );
    return response;
  } catch (err) {
    handleError(err, "Aktualizacja danych Budynku", true);
    return err;
  }
}
