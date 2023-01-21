import {
  genericDelete,
  genericGetAll,
  genericGetById,
  genericPost,
  genericPut,
} from "$lib/js-lib/httpMethods";
import { handleError } from "$lib/js-lib/errors";

const path = "/InspectionTask";

export async function postInspectionTask(CreateInspectionTaskCommand) {
  let response;
  try {
    response = await genericPost(path, CreateInspectionTaskCommand);
    return response;
  } catch (err) {
    handleError(err, "dodawanie Zadania");
    return err;
  }
}
export async function putInspectionTask(id, UpdateInspectionTaskCommand) {
  let response;
  try {
    response = await genericPut(path, id, UpdateInspectionTaskCommand);
    return response;
  } catch (err) {
    handleError(err, "Aktualizacja Zadania");
    return err;
  }
}
export async function getInspectionTaskById(id) {
  let response;
  try {
    response = await genericGetById(path, id);
    return response;
  } catch (err) {
    handleError(err, "pobieranie Zadania na podstawie ID");
    return err;
  }
}
export async function getAllInspectionTasks() {
  let response;
  try {
    response = await genericGetAll(path);
    return response;
  } catch (err) {
    handleError(err, "pobieranie wszystkich Zadań");
    return err;
  }
}
export async function deleteInspectionTask(id) {
  let response;
  try {
    response = await genericDelete(path, id);
    return response;
  } catch (err) {
    let reloadRequired = true;
    handleError(err, "usuwanie Zadania na podstawie ID", reloadRequired);
    return err;
  }
}

export function checkIfTasksDiffer(
  inspectionTaskFromGet,
  updatedInspectionTask
) {
  if (inspectionTaskFromGet.building.id != updatedInspectionTask.buildingId)
    return true;
  if (
    inspectionTaskFromGet.taskDelegator.id !=
    updatedInspectionTask.taskDelegatorId
  )
    return true;
  if (
    inspectionTaskFromGet.taskPerformer.id !=
    updatedInspectionTask.taskPerformerId
  )
    return true;
  if (
    inspectionTaskFromGet.dueStartDateTime !=
    updatedInspectionTask.dueStartDateTime
  ) {
    let dueStartTimeStrLength = inspectionTaskFromGet.dueStartDateTime.length;
    let originalDueStartTimeWithoutZeros =
      inspectionTaskFromGet.dueStartDateTime.substring(
        0,
        dueStartTimeStrLength - 3
      );
    if (
      originalDueStartTimeWithoutZeros != updatedInspectionTask.dueStartDateTime
    )
      return true;
  }
  return false;
}

// export function compareRealPropertiesByVenueNumber(a, b) {
//   let aVenueNumber = a.propertyAddress.venueNumber;
//   let bVenueNumber = b.propertyAddress.venueNumber;

//   let aInt = parseInt(aVenueNumber);
//   let bInt = parseInt(bVenueNumber);
//   if (aInt < bInt) {
//     return -1;
//   }
//   if (aInt > bInt) {
//     return 1;
//   }
//   return 0;
// }
