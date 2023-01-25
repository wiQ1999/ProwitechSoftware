<script>
  import { onMount } from "svelte";
  import { goto } from "$app/navigation";
  import InspectionTaskDetailedList from "$lib/components/InspectionTaskDetailedList.svelte";
  import { openModal } from "svelte-modals";
  import { getToken } from "$lib/js-lib/authManager";
  import BaseConfirmPopUp from "$lib/components/base/BaseConfirmPopUp.svelte";
  import BasePopUp from "$lib/components/base/BasePopUp.svelte";
  import {
    getInspectionTasksOfParticularPerformer,
    deleteInspectionTask,
    changeInspectionTaskStatus,
    getInspectionTaskById,
  } from "$lib/stores/InspectionTask";

  let collection = [];
  let tableRowsClassName = "performer-tasks-base-list";
  let listName = "";
  let baseListVisibility = false;
  let userId;
  onMount(async () => {
    baseListVisibility = false;
    let userData = getToken();
    userId = userData.id;
    let taskResponse = await getInspectionTasksOfParticularPerformer(userId);
    if (taskResponse instanceof Error) return;
    let tasks = await taskResponse.json();
    listName = `${userData.firstName} ${userData.lastName} - ZADANIA`;
    collection = tasks.sort(compareTasksStatutes);
    baseListVisibility = true;
  });
  function compareTasksStatutes(taskA, taskB) {
    let statusA = taskA.status;
    let statusB = taskB.status;

    if (statusA < statusB) {
      return -1;
    }
    if (statusA > statusB) {
      return 1;
    }
    return 0;
  }
  const headerDictionary = {
    Budynek: "building.buildingAddress.streetName",
    _nr: "building.buildingAddress.buildingNumber",
    _miasto: "building.buildingAddress.cityName",
    Delegujący: "taskDelegator.login",
    Status: "status",
    "Planowana data rozpoczęcia": "dueStartDateTime",
    Rozpoczęto: "startDateTime",
    Zakończono: "endDateTime",
  };

  async function firstButtonHandler(event) {
    let taskId = event.detail.row.id;
    let optionalTaskStatusChange = await changeTaskStatusIfNeeded(taskId);
    if (optionalTaskStatusChange) goto(`/tasks/handle/${taskId}`);
  }
  async function changeTaskStatusIfNeeded(taskId) {
    let taskResponse = await getInspectionTaskById(taskId);
    if (taskResponse instanceof Error) return;

    let task = await taskResponse.json();
    let taskStatus = task.status;

    if (taskStatus == "nowe") {
      let updateSuccess = await changeInspectionTaskStatus(taskId, true);
      if (updateSuccess instanceof Error) return false;
    }
    return true;
  }

  function secondButtonHandler(event) {}

  async function deleteHandler(event) {
    openModal(BaseConfirmPopUp, {
      title: "Potwierdź akcję",
      message: "Czy na pewno chcesz usunąć wybrane Zadanie?",
      onOkay: async () => await deleteAndReload(event.detail.row.id),
      undoSingleColorSelection: true,
      selectedElementHtmlDomId: `${tableRowsClassName}-${event.detail.row.id}`,
    });
  }

  async function deleteAndReload(id) {
    let response = await deleteInspectionTask(id);
    if (response instanceof Response) {
      openModal(BasePopUp, {
        title: "Udana akcja",
        message: "Pomyślnie usunięto wybrane Zadanie",
        reloadRequired: true,
      });
    }
  }

  async function deleteSelectedHandler(event) {
    const rows = event.detail.rows;
    openModal(BaseConfirmPopUp, {
      title: "Potwierdź akcję",
      message: "Czy na pewno chcesz usunąć zaznaczone Zadania?",
      onOkay: async () => await deleteSelectedAndReload(rows),
      undoMultipleColorSelection: true,
      selectedClassName: tableRowsClassName,
    });
  }
  async function deleteSelectedAndReload(rows) {
    if (rows == null) return;
    let errorOccured = false;
    let deleteResult;
    for (let i = 0; i < rows.length; i++) {
      deleteResult = await deleteInspectionTask(rows[i].id);
      if (!(deleteResult instanceof Response)) errorOccured = true;
    }
    if (!errorOccured) {
      openModal(BasePopUp, {
        title: "Udana akcja",
        message: "Pomyślnie usunięto zaznaczone Zadania",
        reloadRequired: true,
      });
    }
  }
</script>

<a href="/tasks">
  <button
    class="bg-red-500 uppercase decoration-none text-black text-base font-semibold py-[1%] mx-auto rounded-md flex w-[60%] justify-center cursor-pointer"
    >Powrót</button
  >
</a>

{#if baseListVisibility}
  <InspectionTaskDetailedList
    {listName}
    {collection}
    {headerDictionary}
    {tableRowsClassName}
    firstButtonVisibility={true}
    firstButtonMessage="ROZPOCZNIJ"
    on:firstButtonAction={firstButtonHandler}
    on:secondButtonAction={secondButtonHandler}
  />{/if}
