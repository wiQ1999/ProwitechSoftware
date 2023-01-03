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
    handleError(err, "dodawanie Budynku");
    return err;
  }
}
export async function getBuildingById(id) {
  let getBuildingByIdResult;
  try {
    getBuildingByIdResult = await genericGetById("/Building", id);
  } catch (err) {
    handleError(err, "pobieranie Budynku na podstawie ID");
  }
  return getBuildingByIdResult;
}
export async function getAllBuildings() {
  let response;
  try {
    response = await genericGetAll("/Building");
  } catch (err) {
    handleError(err, "pobieranie wszystkich Budynków");
  }
  return await response.json();
}
export async function deleteBuilding(id) {
  let response;
  try {
    response = await genericDelete("/Building", id);
    return response;
  } catch (err) {
    handleError(err, "usuwanie Budynku");
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
  console.log(updateBuildingDTO);

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
  console.log(UpdateBuildingCommand);

  let response;
  try {
    response = await genericPut(
      "/Building",
      UpdateBuildingCommand.id,
      UpdateBuildingCommand
    );
    return response;
  } catch (err) {
    handleError(err, "Aktualizacja danych Budynku");
    return err;
  }
}
