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
  let buildings;
  try {
    buildings = await genericGetAll("/Building");
  } catch (err) {
    handleError(err, "pobieranie wszystkich Budynków");
  }
  return buildings;
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