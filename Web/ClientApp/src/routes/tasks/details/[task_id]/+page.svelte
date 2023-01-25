<script>
  import { openModal } from "svelte-modals";
  import BasePopUp from "$lib/components/base/BasePopUp.svelte";
  import { page } from "$app/stores";
  import { goto } from "$app/navigation";
  import { onMount } from "svelte";
  import { getToken } from "$lib/js-lib/authManager";
  import HandleTaskList from "$lib/components/HandleTaskList.svelte";

  import InspectionTaskForm from "$lib/components/InspectionTaskForm.svelte";
  import {
    getInspectionTaskById,
    putInspectionTask,
    checkIfTasksDiffer,
    getTaskProtocols,
  } from "$lib/stores/InspectionTask";
  import { getBuildingById } from "$lib/stores/Building";
  import { compareProtocolsByVenueNumber } from "$lib/stores/InspectionProtocol";
  let editMode = true;
  let formVisibility = false;
  let href = `/tasks/getAll`;
  let originalInspectionTask;
  let building;
  let showProtocolsList = false;
  let listName;
  let collectionOfProtocols = [];
  let tableRowsClassName = "task-details-protocols-list";
  let UpdateInspectionTaskCommand = {
    id: "",
    taskDelegatorId: "",
    taskPerformerId: "",
    status: "",
    buildingId: "",
    dueStartDateTime: "",
    startDateTime: "",
    endDateTime: "",
  };
  let chosenHeadersList;
  const headerDictionaryForMultipleProperties = {
    "Numer protokołu": "number",
    "Numer lokalu": "inspectedProperty.propertyAddress.venueNumber",
    "Klatka schodowa": "inspectedProperty.propertyAddress.staircaseNumber",
    Mieszkaniec: "resident.firstName",
    _nazwisko: "resident.lastName",
    "Numer telefonu": "resident.phoneNumber",
  };
  const headerDictionaryForSingleProperty = {
    "Numer protokołu": "number",
    Mieszkaniec: "resident.firstName",
    _nazwisko: "resident.lastName",
    "Numer telefonu": "resident.phoneNumber",
  };
  onMount(async () => {
    let userData = getToken();
    console.log(userData);
    let res = await getInspectionTaskById($page.params.task_id);
    if (res instanceof Error) return;
    originalInspectionTask = await res.json();
    console.log(originalInspectionTask);

    if (originalInspectionTask.building.type == "JEDNOLOKALOWY")
      chosenHeadersList = headerDictionaryForSingleProperty;
    else chosenHeadersList = headerDictionaryForMultipleProperties;

    UpdateInspectionTaskCommand = {
      id: originalInspectionTask.id,
      taskDelegatorId: originalInspectionTask.taskDelegator.id,
      taskPerformerId: originalInspectionTask.taskPerformer.id,
      status: originalInspectionTask.status,
      buildingId: originalInspectionTask.building.id,
      dueStartDateTime: originalInspectionTask.dueStartDateTime,
    };

    if (
      UpdateInspectionTaskCommand.status == "zakonczone" ||
      UpdateInspectionTaskCommand.status == "zakończone"
    ) {
      showProtocolsList = await prepareListOfProtocols();
    }

    let buildingResponse = await getBuildingById(
      originalInspectionTask.building.id
    );
    if (buildingResponse instanceof Response) {
      building = await buildingResponse.json();
    }
    formVisibility = true;
  });
  async function prepareListOfProtocols() {
    let taskProtocolsResponse = await getTaskProtocols($page.params.task_id);

    if (taskProtocolsResponse instanceof Error) return false;

    let taskProtocols = await taskProtocolsResponse.json();
    listName = "Utworzone protokoły";
    collectionOfProtocols = taskProtocols.sort(compareProtocolsByVenueNumber);
    return true;
  }
  function firstButtonHandler(event) {
    let propertyId = event.detail.row.inspectedProperty.id;
    goto(
      `/protocols/task/${$page.params.task_id}/property/${propertyId}/protocol/${event.detail.row.id}/details/advanced`
    );
  }
  const updateInspectionTask = async () => {
    let userData = getToken();
    UpdateInspectionTaskCommand.taskDelegatorId = userData.id;
    let differ = checkIfTasksDiffer(
      originalInspectionTask,
      UpdateInspectionTaskCommand
    );
    if (!differ) {
      openModal(BasePopUp, {
        title: "Brak akcji",
        message: "Dane Zadania nie zostały zmienione",
      });
      return;
    }
    let result = await putInspectionTask(
      UpdateInspectionTaskCommand.id,
      UpdateInspectionTaskCommand
    );
    if (result instanceof Response) {
      openModal(BasePopUp, {
        title: "Sukces",
        message: "Pomyślnie edytowano Zadanie",
        reloadRequired: true,
      });
    }
  };
</script>

<a {href}>
  <button
    class="bg-red-500 uppercase decoration-none text-black text-base font-semibold py-[1%] mx-auto rounded-md flex w-[60%] justify-center cursor-pointer"
    >Powrót</button
  >
</a>
{#if formVisibility}
  <InspectionTaskForm
    onSubmit={updateInspectionTask}
    bind:CreateInspectionTaskCommand={UpdateInspectionTaskCommand}
    {building}
    {editMode}
  />
{/if}
{#if showProtocolsList}
  <HandleTaskList
    {listName}
    collection={collectionOfProtocols}
    headerDictionary={chosenHeadersList}
    {tableRowsClassName}
    firstButtonVisibility={true}
    firstButtonMessage="EDYTUJ"
    on:firstButtonAction={firstButtonHandler}
  />
{/if}
