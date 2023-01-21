import {
  genericDelete,
  genericGetAll,
  genericGetById,
  genericPost,
  genericPut,
} from "$lib/js-lib/httpMethods";
import { handleError } from "$lib/js-lib/errors";

const path = "/InspectionTask";

export async function postInspectionProtocol(CreateInspectionProtocolCommand) {
  let response;
  try {
    response = await genericPost(path, CreateInspectionProtocolCommand);
    return response;
  } catch (err) {
    handleError(err, "dodawanie Protokołu");
    return err;
  }
}
export async function putInspectionProtocol(
  id,
  UpdateInspectionProtocolCommand
) {
  let response;
  try {
    response = await genericPut(path, id, UpdateInspectionProtocolCommand);
    return response;
  } catch (err) {
    handleError(err, "Aktualizacja Protokołu");
    return err;
  }
}
export async function getInspectionProtocolById(id) {
  let response;
  try {
    response = await genericGetById(path, id);
    return response;
  } catch (err) {
    handleError(err, "pobieranie Protokołu na podstawie ID");
    return err;
  }
}
export async function getAllInspectionProtocols() {
  let response;
  try {
    response = await genericGetAll(path);
    return response;
  } catch (err) {
    handleError(err, "pobieranie wszystkich Protokołów");
    return err;
  }
}
export async function deleteInspectionProtocol(id) {
  let response;
  try {
    response = await genericDelete(path, id);
    return response;
  } catch (err) {
    let reloadRequired = true;
    handleError(err, "usuwanie Protokołu na podstawie ID", reloadRequired);
    return err;
  }
}
export async function getInspectionProtocolsOfParticularTask(taskId) {
  console.log(taskId);
  let route = "/InspectionProtocol/taskProtocols";
  let response;
  try {
    response = await genericGetById(route, taskId);
    return response;
  } catch (err) {
    handleError(
      err,
      "pobieranie wszystkich Protokołów przypisanych do wybranego Zadania"
    );
    return err;
  }
}
export function compareProtocolsByVenueNumber(a, b) {
  let aVenueNumber = a.inspectedProperty.propertyAddress.venueNumber;
  let bVenueNumber = b.inspectedProperty.propertyAddress.venueNumber;

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

// export function checkIfTasksDiffer(
//   inspectionTaskFromGet,
//   updatedInspectionTask
// ) {
//   if (inspectionTaskFromGet.building.id != updatedInspectionTask.buildingId)
//     return true;
//   if (
//     inspectionTaskFromGet.taskDelegator.id !=
//     updatedInspectionTask.taskDelegatorId
//   )
//     return true;
//   if (
//     inspectionTaskFromGet.taskPerformer.id !=
//     updatedInspectionTask.taskPerformerId
//   )
//     return true;
//   if (
//     inspectionTaskFromGet.dueStartDateTime !=
//     updatedInspectionTask.dueStartDateTime
//   ) {
//     let dueStartTimeStrLength = inspectionTaskFromGet.dueStartDateTime.length;
//     let originalDueStartTimeWithoutZeros =
//       inspectionTaskFromGet.dueStartDateTime.substring(
//         0,
//         dueStartTimeStrLength - 3
//       );
//     if (
//       originalDueStartTimeWithoutZeros != updatedInspectionTask.dueStartDateTime
//     )
//       return true;
//   }
//   return false;
// }
