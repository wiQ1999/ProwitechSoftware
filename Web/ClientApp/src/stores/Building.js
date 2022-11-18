import {
  genericDelete,
  genericGetAll,
  genericGetById,
  genericPost,
  genericPut,
} from "../js-lib/httpMethods";
import { handleError } from "../js-lib/errors";

export async function postBuilding(
  buildingAddressId,
  propertyManagerId,
  buildingType
) {
  let response;
  let createBuildingCommand = {
    buildingAddressId: buildingAddressId,
    type: buildingType,
    propertyManagerId: propertyManagerId,
  };
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
