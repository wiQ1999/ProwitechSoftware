<script>
  import { onMount } from "svelte";
  import { goto } from "$app/navigation";
  import InspectionTaskDetailedList from "$lib/components/InspectionTaskDetailedList.svelte";
  import { openModal } from "svelte-modals";
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
  let notAdminId = "030B7529-173C-41A8-953D-75BA46B7FC21";
  onMount(async () => {
    baseListVisibility = false;
    //TODO POBRAĆ ZADANIA ZALOGOWANEGO UŻYTKOWNIKA
    let taskResponse = await getInspectionTasksOfParticularPerformer(
      notAdminId
    );
    if (taskResponse instanceof Error) return;
    let tasks = await taskResponse.json();
    //TODO NAZWA LIST NAME = IMIĘ + NAZWISKO ZALOGOWANEGO + ZADANIA
    listName = "ALOJZY PTYŚ - ZADANIA";
    collection = tasks;
    baseListVisibility = true;
  });

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
