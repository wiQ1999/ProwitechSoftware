<script>
  import { onMount } from "svelte";
  import { goto } from "$app/navigation";
  import { openModal } from "svelte-modals";
  import { page } from "$app/stores";
  import BaseConfirmPopUp from "$lib/components/base/BaseConfirmPopUp.svelte";
  import BasePopUp from "$lib/components/base/BasePopUp.svelte";
  import { compareRealPropertiesByVenueNumber } from "$lib/stores/RealProperty";
  import {
    getInspectionTaskById,
    deleteInspectionTask,
    getInspectionTaskPropertiesWithoutProtocols,
    getTaskProtocols,
    changeInspectionTaskStatus,
  } from "$lib/stores/InspectionTask";
  import {
    compareProtocolsByVenueNumber,
    deleteInspectionProtocol,
  } from "$lib/stores/InspectionProtocol";
  import { getBuildingById } from "$lib/stores/Building";
  import HandleTaskList from "$lib/components/HandleTaskList.svelte";
  import { setResultFormatIfItIsDateTime } from "$lib/js-lib/helpers";
  import { getToken } from "$lib/js-lib/authManager";
  import Map from "$lib/components/Map.svelte";

  let collectionOfRealPropertiesWithoutAssignedProtocols = [];
  let collectionOfNewProtocols = [];
  let firstTableRowsClassName = "real-properties-without-protocols-base-list";
  let secondTableRowsClassName = "task-protocols-base-list";
  let firstListName = "";
  let secondListName = "";
  let firstListVisibility = false;
  let secondListVisibility = false;
  let buttonDisabled = true;
  let userId;
  let realPropertiesWithoutProtocols;
  let buildingInfo;
  let buildingInfoVisibility = false;
  let taskProtocols;
  let taskStatus;
  let inspectionTask;
  let building;
  let allBuildingRealPropertiesCount;
  let submitButtonVisibility = false;
  let singleFamilyBuildingType = false;
  let multipleFamilyBuildingType = false;
  let mapVisibility = false;
  let problemWithBuildingPropertiesVisibility = false;
  onMount(async () => {
    let userData = getToken();
    userId = userData.id;
    firstListVisibility = false;
    secondListVisibility = false;
    buildingInfoVisibility = false;
    buttonDisabled = true;
    submitButtonVisibility = false;
    singleFamilyBuildingType = false;
    multipleFamilyBuildingType = false;
    mapVisibility = false;
    problemWithBuildingPropertiesVisibility = false;

    let buildingPrepared = await prepareBuildingInfo();
    let firstListPrepared = await prepareFirstList();
    let secondListPrepared = await prepareSecondList();

    if (buildingPrepared && firstListPrepared && secondListPrepared) {
      firstListVisibility = true;
      secondListVisibility = true;
      buildingInfoVisibility = true;
      mapVisibility = true;
    }
    if (
      collectionOfNewProtocols.length>0 && collectionOfNewProtocols.length == allBuildingRealPropertiesCount &&
      taskStatus != "zakończone" &&
      taskStatus != "zakonczone"
    )
      buttonDisabled = false;
    if (taskStatus == "w toku") {
      submitButtonVisibility = true;
    }
    if (
      collectionOfRealPropertiesWithoutAssignedProtocols.length == 0 &&
      collectionOfNewProtocols.length == 0
    ) {
      problemWithBuildingPropertiesVisibility = true;
    }
  });

  async function prepareBuildingInfo() {
    let taskResponse = await getInspectionTaskById($page.params.task_id);
    if (taskResponse instanceof Error) return false;

    inspectionTask = await taskResponse.json();

    let buildingResponse = await getBuildingById(inspectionTask.building.id);
    if (buildingResponse instanceof Error) return false;

    building = await buildingResponse.json();
    if (building.type == "WIELOLOKALOWY") multipleFamilyBuildingType = true;
    if (building.type == "JEDNOLOKALOWY") singleFamilyBuildingType = true;
    allBuildingRealPropertiesCount = building.properties.length;
    buildingInfo = `${building.buildingAddress.streetName} ${building.buildingAddress.buildingNumber}, ${building.buildingAddress.cityName}`;
    taskStatus = inspectionTask.status;
    if (taskStatus == "zakonczone") taskStatus = "zakończone";
    return true;
  }
  async function prepareFirstList() {
    let realPropertiesWithoutProtocolsResponse =
      await getInspectionTaskPropertiesWithoutProtocols($page.params.task_id);

    if (realPropertiesWithoutProtocolsResponse instanceof Error) return false;

    realPropertiesWithoutProtocols =
      await realPropertiesWithoutProtocolsResponse.json();
    firstListName =
      "Nieruchomości, które jeszcze nie zostały poddane inspekcji";
    collectionOfRealPropertiesWithoutAssignedProtocols =
      realPropertiesWithoutProtocols.sort(compareRealPropertiesByVenueNumber);
    return true;
  }
  async function prepareSecondList() {
    let taskProtocolsResponse = await getTaskProtocols($page.params.task_id);

    if (taskProtocolsResponse instanceof Error) return false;

    taskProtocols = await taskProtocolsResponse.json();
    secondListName = "Utworzone protokoły";
    collectionOfNewProtocols = taskProtocols.sort(
      compareProtocolsByVenueNumber
    );
    return true;
  }

  const firstListHeaderDictionary = {
    "Numer lokalu": "propertyAddress.venueNumber",
    "Klatka schodowa": "propertyAddress.staircaseNumber",
  };
  const secondListHeaderDictionary = {
    "Numer protokołu": "number",
    "Numer lokalu": "inspectedProperty.propertyAddress.venueNumber",
    "Klatka schodowa": "inspectedProperty.propertyAddress.staircaseNumber",
    Mieszkaniec: "resident.firstName",
    _nazwisko: "resident.lastName",
    "Numer telefonu": "resident.phoneNumber",
  };
  const singleFamilyBuildingHeaderDictionary = {
    "Numer protokołu": "number",
    Mieszkaniec: "resident.firstName",
    _nazwisko: "resident.lastName",
    "Numer telefonu": "resident.phoneNumber",
  };

  function FIRST_LIST_firstButtonHandler(event) {
    goto(
      `/protocols/task/${$page.params.task_id}/property/${event.detail.row.id}/create`
    );
  }

  function SECOND_LIST_firstButtonHandler(event) {
    let propertyId = event.detail.row.inspectedProperty.id;
    goto(
      `/protocols/task/${$page.params.task_id}/property/${propertyId}/protocol/${event.detail.row.id}/details`
    );
  }
  const SINGLE_FAMILY_BUILDING_buttonHandler = () => {
    let propertyId = collectionOfRealPropertiesWithoutAssignedProtocols[0].id;
    goto(
      `/protocols/task/${$page.params.task_id}/property/${propertyId}/create`
    );
  };
  function showMap() {
    mapVisibility = true;
  }

  function SECOND_LIST_deleteHandler(event) {
    mapVisibility = false;
    openModal(BaseConfirmPopUp, {
      title: "Potwierdź akcję",
      message: "Czy na pewno chcesz usunąć wybrany Protokół?",
      onOkay: async () => await deleteAndReload(event.detail.row.id),
      undoSingleColorSelection: true,
      selectedElementHtmlDomId: `${secondTableRowsClassName}-${event.detail.row.id}`,
      actionAfterCancelRequired: true,
      actionAfterCancel: () => showMap(),
    });
  }

  async function deleteAndReload(id) {
    mapVisibility = false;
    let response = await deleteInspectionProtocol(id);
    if (response instanceof Response) {
      openModal(BasePopUp, {
        title: "Udana akcja",
        message: "Pomyślnie usunięto wybrany Protokół",
        reloadRequired: true,
      });
    }
  }
  const finishTask = async () => {
    let updateSuccess = await changeInspectionTaskStatus(
      $page.params.task_id,
      false,
      true
    );
    if (updateSuccess instanceof Error) return false;
    mapVisibility = false;
    openModal(BasePopUp, {
      title: "Udana akcja",
      message: "Zakończono Zadanie",
      redirectionRequired: true,
      redirectionHref: `/tasks/${userId}/performer_tasks`,
    });
  };
</script>

<a href="/tasks/{userId}/performer_tasks">
  <button
    class="bg-red-500 uppercase decoration-none text-black text-base font-semibold py-[1%] mx-auto rounded-md flex w-[60%] justify-center cursor-pointer"
    >Powrót</button
  >
</a>
{#if buildingInfoVisibility}
  
  <div class="my-[2%] mx-auto bg-white border-2 border-slate-600 rounded-sm w-[50%] text-center">
    <div class="mb-[2%] text-center text-2xl mt-4 font-semibold">
      ZADANIE Z DNIA {setResultFormatIfItIsDateTime(
        "dueStartDateTime",
        inspectionTask.dueStartDateTime
      )}
    </div>
    <table class="mx-auto">
      <tr>
        <td class="p-2"><b>BUDYNEK {building.type} </b> przy ul. <b>{buildingInfo} </b></td>
      </tr>
      <tr>
        <td class="p-2">STATUS: <b>{taskStatus} </b></td>
      </tr>
      <tr>
        <td class="p-2">ROZPOCZĘTO <b>{inspectionTask.startDateTime != "0001-01-01T00:00:00"
          ? setResultFormatIfItIsDateTime(
              "startDateTime",
              inspectionTask.startDateTime
            )
          : ""} </b></td>
      </tr>
      {#if taskStatus == "zakończone" || taskStatus == "zakonczone"}
        <tr>
          <td>ZAKOŃCZONO</td>
          <td
            >{inspectionTask.endDateTime != "0001-01-01T00:00:00"
              ? setResultFormatIfItIsDateTime(
                  "endDateTime",
                  inspectionTask.endDateTime
                )
              : ""}</td
          >
        </tr>
      {/if}
    </table>
  </div>
  <div />
{/if}
{#if mapVisibility}
  <Map {building} displayLink={true} mapForTask={true} />{/if}
{#if problemWithBuildingPropertiesVisibility}
  <div class="building-properties-not-created">
    DO BUDYNKU NIE PRZYPISANO ŻADNYCH LOKALI - SKONTAKTUJ SIĘ Z SZEFEM
  </div>
{/if}
{#if multipleFamilyBuildingType}
  <div class="wielolokalowy">
    {#if firstListVisibility && collectionOfRealPropertiesWithoutAssignedProtocols.length > 0}
      <HandleTaskList
        listName={firstListName}
        collection={collectionOfRealPropertiesWithoutAssignedProtocols}
        headerDictionary={firstListHeaderDictionary}
        {firstTableRowsClassName}
        firstButtonVisibility={true}
        firstButtonMessage="DODAJ PROTOKÓŁ"
        on:firstButtonAction={FIRST_LIST_firstButtonHandler}
      />{/if}
    {#if secondListVisibility && collectionOfNewProtocols.length > 0 && taskStatus == "w toku"}
      <HandleTaskList
        listName={secondListName}
        collection={collectionOfNewProtocols}
        headerDictionary={secondListHeaderDictionary}
        tableRowsClassName={secondTableRowsClassName}
        firstButtonVisibility={true}
        firstButtonMessage="EDYTUJ"
        secondButtonVisibility={true}
        secondButtonMessage="USUŃ"
        on:firstButtonAction={SECOND_LIST_firstButtonHandler}
        on:secondButtonAction={SECOND_LIST_deleteHandler}
      />{/if}
    {#if secondListVisibility && collectionOfNewProtocols.length > 0 && (taskStatus == "zakonczone" || taskStatus == "zakończone")}
      <HandleTaskList
        listName={secondListName}
        collection={collectionOfNewProtocols}
        headerDictionary={secondListHeaderDictionary}
        firstButtonVisibility={true}
        firstButtonMessage="EDYTUJ"
        on:firstButtonAction={SECOND_LIST_firstButtonHandler}
      />{/if}
  </div>
{/if}
{#if singleFamilyBuildingType}
  <div class="jednolokalowy">
    {#if firstListVisibility && collectionOfRealPropertiesWithoutAssignedProtocols.length > 0}
      <button
        on:click|preventDefault={SINGLE_FAMILY_BUILDING_buttonHandler}
        class="ml-[2%] mb-[2%] rounded-sm w-1/4 bg-[#007acc] text-white font-semibold flex justify-center"
        >Dodaj protokół</button
      >
    {/if}
    {#if secondListVisibility && collectionOfNewProtocols.length > 0 && taskStatus == "w toku"}
      <HandleTaskList
        listName={secondListName}
        collection={collectionOfNewProtocols}
        headerDictionary={singleFamilyBuildingHeaderDictionary}
        tableRowsClassName={secondTableRowsClassName}
        firstButtonVisibility={true}
        firstButtonMessage="EDYTUJ"
        secondButtonVisibility={true}
        secondButtonMessage="USUŃ"
        on:firstButtonAction={SECOND_LIST_firstButtonHandler}
        on:secondButtonAction={SECOND_LIST_deleteHandler}
      />{/if}
    {#if secondListVisibility && collectionOfNewProtocols.length > 0 && (taskStatus == "zakonczone" || taskStatus == "zakończone")}
      <HandleTaskList
        listName={secondListName}
        collection={collectionOfNewProtocols}
        headerDictionary={singleFamilyBuildingHeaderDictionary}
        tableRowsClassName={secondTableRowsClassName}
        firstButtonVisibility={true}
        firstButtonMessage="EDYTUJ"
        on:firstButtonAction={SECOND_LIST_firstButtonHandler}
      />{/if}
  </div>
{/if}

{#if submitButtonVisibility}
<div class="text-center">
  <button
    type="submit"
    on:click|preventDefault={finishTask}
    class="py-5 border-2 border-[#0078c8] font-semibold text-lg rounded-md w-[90%] mb-3 justify-center hover:bg-blue-400 disabled:bg-gray-400"
    disabled={buttonDisabled}>Zakończ zadanie</button>
</div>
{/if}
