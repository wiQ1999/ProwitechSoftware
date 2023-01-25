import {
  genericDelete,
  genericGetAll,
  genericGetById,
  genericPost,
  genericPut,
  genericCustomGet,
  genericCustomPut,
} from "$lib/js-lib/httpMethods";
import { formatDate } from "$lib/js-lib/helpers";
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
export async function getInspectionTasksOfParticularPerformer(performerId) {
  let route = "/InspectionTask/performerTasks";
  let response;
  try {
    response = await genericGetById(route, performerId);
    return response;
  } catch (err) {
    handleError(err, "pobieranie Zadań przypisanych do konkretnego Wykonawcy");
    return err;
  }
}
export async function getInspectionTaskPropertiesWithoutProtocols(taskId) {
  let route = `/InspectionTask/${taskId}/propertiesWithoutProtocols`;
  let response;
  try {
    response = await genericCustomGet(route);
    return response;
  } catch (err) {
    handleError(
      err,
      "pobieranie Nieruchomości przypisanych do Zadania, które nie posiadają Protokołów"
    );
    return err;
  }
}
export async function getTaskProtocols(taskId) {
  let route = `/InspectionProtocol/taskProtocols/${taskId}`;
  let response;
  try {
    response = await genericCustomGet(route);
    return response;
  } catch (err) {
    handleError(err, "pobieranie Protokołów przypisanych do wybranego zadania");
    return err;
  }
}
// {id:Guid}/changeStatusToInProgress"

export async function changeInspectionTaskStatus(
  taskId,
  inProgress = false,
  finished = false
) {
  let date = new Date();
  let inputDateTime = formatDate(date, true);
  console.log(inputDateTime);

  let changeTaskStatusCommand;
  if (inProgress) {
    changeTaskStatusCommand = {
      id: taskId,
      status: "w toku",
      startDateTime: inputDateTime,
    };
  }
  if (finished) {
    changeTaskStatusCommand = {
      id: taskId,
      status: "zakończone",
      endDateTime: inputDateTime,
    };
  }

  console.log(changeTaskStatusCommand);
  let route = `/InspectionTask/${taskId}/changeStatusToInProgress`;
  let response;
  try {
    response = await genericCustomPut(route, changeTaskStatusCommand);
    return response;
  } catch (err) {
    handleError(err, "Zmiana statusu Zadania z [nowe] na [w toku]");
    return err;
  }
}
