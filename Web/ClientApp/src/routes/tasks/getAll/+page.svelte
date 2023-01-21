<script>
  import { onMount } from "svelte";
  import { goto } from "$app/navigation";
  import BaseList from "$lib/components/base/BaseList.svelte";
  import { openModal } from "svelte-modals";
  import BaseConfirmPopUp from "$lib/components/base/BaseConfirmPopUp.svelte";
  import BasePopUp from "$lib/components/base/BasePopUp.svelte";
  import {
    getAllInspectionTasks,
    deleteInspectionTask,
  } from "$lib/stores/InspectionTask";

  let collection = [];
  let tableRowsClassName = "real-properties-base-list";
  let listName = "";
  let buildingTypeError = false;
  let baseListVisibility = false;
  let buildingInfoVisibility = false;
  onMount(async () => {
    buildingTypeError = false;
    baseListVisibility = false;

    let taskResponse = await getAllInspectionTasks();
    if (taskResponse instanceof Error) return;
    let tasks = await taskResponse.json();
    listName = "ZADANIA";
    collection = tasks;
    buildingInfoVisibility = true;
    baseListVisibility = true;
  });

  const headerDictionary = {
    Budynek: "building.buildingAddress.streetName",
    _nr: "building.buildingAddress.buildingNumber",
    _miasto: "building.buildingAddress.cityName",
    Delegujący: "taskDelegator.login",
    Wykonujący: "taskPerformer.login",
    Status: "status",
    "Planowana data rozpoczęcia": "dueStartDateTime",
    Rozpoczęto: "startDateTime",
    Zakończono: "endDateTime",
  };

  function addHandler(event) {
    goto(`/tasks/create`);
  }

  function detailHandler(event) {
    goto(`/tasks/details/${event.detail.row.id}`);
  }

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

{#if baseListVisibility}
  <BaseList
    {listName}
    {collection}
    {headerDictionary}
    {tableRowsClassName}
    on:listAdd={addHandler}
    on:listDetail={detailHandler}
    on:listDelete={deleteHandler}
    on:listDeleteSelected={deleteSelectedHandler}
  />{/if}
