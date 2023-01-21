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
  import { compareProtocolsByVenueNumber } from "$lib/stores/InspectionProtocol";
  import { getBuildingById } from "$lib/stores/Building";
  import ModifiedBaseList from "$lib/components/base/ModifiedBaseList.svelte";
  import { setResultFormatIfItIsDateTime } from "$lib/js-lib/helpers";

  let collectionOfRealPropertiesWithoutAssignedProtocols = [];
  let collectionOfNewProtocols = [];
  let firstTableRowsClassName = "real-properties-without-protocols-base-list";
  let secondTableRowsClassName = "task-protocols-base-list";
  let firstListName = "";
  let secondListName = "";
  let firstListVisibility = false;
  let secondListVisibility = false;
  let buttonDisabled = true;
  //TO DO ZMIENIĆ NA ID ZALOGOWANEGO USERA
  let userId = "030B7529-173C-41A8-953D-75BA46B7FC21";
  let realPropertiesWithoutProtocols;
  let buildingInfo;
  let buildingInfoVisibility = false;
  let taskProtocols;
  let taskStatus;
  let inspectionTask;
  let allBuildingRealPropertiesCount;
  let submitButtonVisibility = false;
  let singleFamilyBuildingType = false;
  let multipleFamilyBuildingType = false;
  onMount(async () => {
    firstListVisibility = false;
    secondListVisibility = false;
    buildingInfoVisibility = false;
    buttonDisabled = true;
    submitButtonVisibility = false;
    singleFamilyBuildingType = false;
    multipleFamilyBuildingType = false;

    let buildingPrepared = await prepareBuildingInfo();
    let firstListPrepared = await prepareFirstList();
    let secondListPrepared = await prepareSecondList();

    if (buildingPrepared && firstListPrepared && secondListPrepared) {
      firstListVisibility = true;
      secondListVisibility = true;
      buildingInfoVisibility = true;
    }
    if (
      collectionOfNewProtocols.length == allBuildingRealPropertiesCount &&
      taskStatus != "zakończone" &&
      taskStatus != "zakonczone"
    )
      buttonDisabled = false;
    if (taskStatus == "w toku") {
      submitButtonVisibility = true;
    }
  });

  async function prepareBuildingInfo() {
    let taskResponse = await getInspectionTaskById($page.params.task_id);
    if (taskResponse instanceof Error) return false;

    inspectionTask = await taskResponse.json();

    let buildingResponse = await getBuildingById(inspectionTask.building.id);
    if (buildingResponse instanceof Error) return false;

    let building = await buildingResponse.json();
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
    console.log(realPropertiesWithoutProtocols);
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
    console.log(taskProtocols);
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
    console.log("firstHandler");
    // goto(`/protocols/create`);
  }

  function secondButtonHandler(event) {
    console.log("secondHandler");
  }

  async function SECOND_LIST_deleteHandler(event) {
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

  async function SECOND_LIST_deleteSelectedHandler(event) {
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
  const finishTask = async () => {
    let updateSuccess = await changeInspectionTaskStatus(
      $page.params.task_id,
      false,
      true
    );
    if (updateSuccess instanceof Error) return false;
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
  <div>
    ZADANIE Z DNIA {setResultFormatIfItIsDateTime(
      "dueStartDateTime",
      inspectionTask.dueStartDateTime
    )}
  </div>
  <div>
    <table>
      <tr>
        <td>BUDYNEK</td>
        <td>{buildingInfo}</td>
        <td>STATUS</td>
        <td>{taskStatus}</td>
      </tr>
      <tr>
        <td>ROZPOCZĘTO</td>
        <td
          >{inspectionTask.startDateTime != "0001-01-01T00:00:00"
            ? setResultFormatIfItIsDateTime(
                "startDateTime",
                inspectionTask.startDateTime
              )
            : ""}</td
        >
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
{#if multipleFamilyBuildingType}
  <div class="wielolokalowy">
    {#if firstListVisibility && collectionOfRealPropertiesWithoutAssignedProtocols.length > 0}
      <ModifiedBaseList
        listName={firstListName}
        collection={collectionOfRealPropertiesWithoutAssignedProtocols}
        headerDictionary={firstListHeaderDictionary}
        {firstTableRowsClassName}
        firstButtonVisibility={true}
        firstButtonMessage="DODAJ PROTOKÓŁ"
        on:firstButtonAction={FIRST_LIST_firstButtonHandler}
        on:secondButtonAction={secondButtonHandler}
      />{/if}
    {#if secondListVisibility && collectionOfNewProtocols.length > 0 && taskStatus == "w toku"}
      <ModifiedBaseList
        listName={secondListName}
        collection={collectionOfNewProtocols}
        headerDictionary={secondListHeaderDictionary}
        {secondTableRowsClassName}
        firstButtonVisibility={true}
        firstButtonMessage="EDYTUJ"
        secondButtonVisibility={true}
        secondButtonMessage="USUŃ"
        on:firstButtonAction={FIRST_LIST_firstButtonHandler}
        on:secondButtonAction={secondButtonHandler}
      />{/if}
    {#if secondListVisibility && collectionOfNewProtocols.length > 0 && (taskStatus == "zakonczone" || taskStatus == "zakończone")}
      <ModifiedBaseList
        listName={secondListName}
        collection={collectionOfNewProtocols}
        headerDictionary={secondListHeaderDictionary}
        {secondTableRowsClassName}
        firstButtonVisibility={true}
        firstButtonMessage="EDYTUJ"
        on:firstButtonAction={FIRST_LIST_firstButtonHandler}
        on:secondButtonAction={secondButtonHandler}
      />{/if}
  </div>
{/if}
{#if singleFamilyBuildingType}
  <div class="jednolokalowy">
    {#if firstListVisibility && collectionOfRealPropertiesWithoutAssignedProtocols.length > 0}
      <button
        on:click|preventDefault={FIRST_LIST_firstButtonHandler}
        class="mx-auto mb-[2%] p-16 rounded-sm w-1/4 bg-[#007acc] text-white font-semibold flex justify-center"
        >Dodaj protokół</button
      >
    {/if}
    {#if secondListVisibility && collectionOfNewProtocols.length > 0 && taskStatus == "w toku"}
      <ModifiedBaseList
        listName={secondListName}
        collection={collectionOfNewProtocols}
        headerDictionary={singleFamilyBuildingHeaderDictionary}
        {secondTableRowsClassName}
        firstButtonVisibility={true}
        firstButtonMessage="EDYTUJ"
        secondButtonVisibility={true}
        secondButtonMessage="USUŃ"
        on:firstButtonAction={FIRST_LIST_firstButtonHandler}
        on:secondButtonAction={secondButtonHandler}
      />{/if}
    {#if secondListVisibility && collectionOfNewProtocols.length > 0 && (taskStatus == "zakonczone" || taskStatus == "zakończone")}
      <ModifiedBaseList
        listName={secondListName}
        collection={collectionOfNewProtocols}
        headerDictionary={singleFamilyBuildingHeaderDictionary}
        {secondTableRowsClassName}
        firstButtonVisibility={true}
        firstButtonMessage="EDYTUJ"
        on:firstButtonAction={FIRST_LIST_firstButtonHandler}
        on:secondButtonAction={secondButtonHandler}
      />{/if}
  </div>
{/if}

{#if submitButtonVisibility}
  <button
    type="submit"
    on:click|preventDefault={finishTask}
    class="py-5 px-10 border-2 border-[#0078c8] font-semibold text-lg rounded-md w-[90%] mb-3 justify-center cursor-pointer hover:bg-blue-400"
    disabled={buttonDisabled}>Zakończ zadanie</button
  >{/if}
