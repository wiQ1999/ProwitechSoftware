<script>
  import { onMount } from "svelte";
  import { goto } from "$app/navigation";
  import { page } from "$app/stores";
  import BaseList from "$lib/components/base/BaseList.svelte";
  import { openModal } from "svelte-modals";
  import BaseConfirmPopUp from "$lib/components/base/BaseConfirmPopUp.svelte";
  import BasePopUp from "$lib/components/base/BasePopUp.svelte";
  import {
    getAllInspectionProtocols,
    deleteInspectionProtocol,
    getBuildingProtocols,
  } from "$lib/stores/InspectionProtocol";
  import { getBuildingById } from "$lib/stores/Building";

  let collection = [];
  let tableRowsClassName = "inspection-protocols-base-list";
  let listName = "";
  let buildingInfoVisibility = false;
  let buildingTypeError = false;
  let baseListVisibility = false;
  let chosenHeadersList;
  const headerDictionaryForSingleProperty = {
    "Numer protokołu": "number",
    Mieszkaniec: "resident.firstName",
    _nazwisko: "resident.lastName",
    "Numer telefonu": "resident.phoneNumber",
  };
  const headerDictionaryForMultipleProperties = {
    "Numer protokołu": "number",
    "Numer lokalu": "inspectedProperty.propertyAddress.venueNumber",
    "Klatka schodowa": "inspectedProperty.propertyAddress.staircaseNumber",
    Mieszkaniec: "resident.firstName",
    _nazwisko: "resident.lastName",
    "Numer telefonu": "resident.phoneNumber",
  };
  onMount(async () => {
    buildingInfoVisibility = false;
    baseListVisibility = false;

    buildingInfoVisibility = await prepareBuildingInfo();

    let protocolResponse = await getBuildingProtocols($page.params.slug);
    if (protocolResponse instanceof Error) return;
    let protocols = await protocolResponse.json();

    collection = protocols;
    baseListVisibility = true;
  });
  async function prepareProtocolsButton(buildingId) {
    let protocolsResponse = await getBuildingProtocols(buildingId);
    if (protocolsResponse instanceof Error) return false;
    let protocols = await protocolsResponse.json();
    if (protocols.length > 0) return true;
    return false;
  }
  async function prepareBuildingInfo() {
    let buildingResponse = await getBuildingById($page.params.slug);
    if (buildingResponse instanceof Error) return false;
    let building = await buildingResponse.json();
    if (building.type == "JEDNOLOKALOWY")
      chosenHeadersList = headerDictionaryForSingleProperty;
    else chosenHeadersList = headerDictionaryForMultipleProperties;

    listName = `PROTOKOŁY BUDYNKU o adresie ${building.buildingAddress.streetName} ${building.buildingAddress.buildingNumber}, ${building.buildingAddress.cityName}`;
  }

  const headerDictionary = {
    Numer: "number",
    Przeprowadzono: "inspectionDateTime",
    Wykonujący: "inspectionPerformer.login",
    Nieruchomość: "inspectedProperty.building.buildingAddress.streetName",
    _Nieruchomość_1:
      "inspectedProperty.building.buildingAddress.buildingNumber",
    _Nieruchomość_2: "inspectedProperty.building.buildingAddress.cityName",
    Mieszkanie: "inspectedProperty.propertyAddress.venueNumber",
    Klatka: "inspectedProperty.propertyAddress.staircaseNumber",
    // Typ: "inspectedProperty.building.type",
    Mieszkaniec: "resident.firstName",
    _Mieszkaniec: "resident.lastName",
    Telefon: "resident.phoneNumber",
  };

  function addHandler(event) {
    goto(`/protocols/create`);
  }

  function detailHandler(event) {
    goto(`/protocols/details/${event.detail.row.id}`);
  }

  async function deleteHandler(event) {
    openModal(BaseConfirmPopUp, {
      title: "Potwierdź akcję",
      message: "Czy na pewno chcesz usunąć wybrany Protokół?",
      onOkay: async () => await deleteAndReload(event.detail.row.id),
      undoSingleColorSelection: true,
      selectedElementHtmlDomId: `${tableRowsClassName}-${event.detail.row.id}`,
    });
  }

  async function deleteAndReload(id) {
    let response = await deleteInspectionProtocol(id);
    if (response instanceof Response) {
      openModal(BasePopUp, {
        title: "Udana akcja",
        message: "Pomyślnie usunięto wybrany Protokół",
        reloadRequired: true,
      });
    }
  }

  async function deleteSelectedHandler(event) {
    const rows = event.detail.rows;
    openModal(BaseConfirmPopUp, {
      title: "Potwierdź akcję",
      message: "Czy na pewno chcesz usunąć zaznaczone Protokoły?",
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
      deleteResult = await deleteInspectionProtocol(rows[i].id);
      if (!(deleteResult instanceof Response)) errorOccured = true;
    }
    if (!errorOccured) {
      openModal(BasePopUp, {
        title: "Udana akcja",
        message: "Pomyślnie usunięto zaznaczone Protokoły",
        reloadRequired: true,
      });
    }
  }

    function closeHandler() {
        goto("/buildings/getAll");
    }

    function openMenu() {
        let button = document.getElementById('openableButton');
        if(!button.hidden) button.hidden = true;
        else button.hidden = false;
        }
</script>

<div class="absolute ml-[3%] mt-5 mr-[78%] w-[20%] text-left">
  <button on:mouseenter={openMenu} on:mouseleave={openMenu} class="bg-blue-500 p-2 text-2xl"><i class="fa fa-align-justify"></i></button>
  <div on:mouseenter={openMenu} on:mouseleave={openMenu} hidden id="openableButton" class="text-center bg-blue-500"> 
      <!--kontener dla dużych ekranów wyświetlający się po lewej a dla mniejszych jako menu rozwijane?-->
      <a href="/buildings/details/{$page.params.slug}">Szczegóły</a>
      <br />
      <a href="/buildings/details/{$page.params.slug}/postal-code">Kod pocztowy</a>
      <br />
      <a href="/buildings/details/{$page.params.slug}/protocols">Protokoły</a>
      <br />
      <a href="/buildings/details/{$page.params.slug}/real-properties/getAll">Lokale</a>
      <br />
      <button on:click|preventDefault={closeHandler} class="bg-red-500 w-[100%]">Zamknij</button>
  </div>
</div>
<a href="/buildings/details/{$page.params.slug}">
  <button
    class="bg-red-500 uppercase decoration-none text-black text-base py-[1%] mx-auto rounded-md flex w-[60%] justify-center cursor-pointer"
    >Powrót</button
  >
</a>

{#if baseListVisibility}
  <BaseList
    {listName}
    {collection}
    headerDictionary={chosenHeadersList}
    {tableRowsClassName}
    on:listAdd={addHandler}
    on:listDetail={detailHandler}
    on:listDelete={deleteHandler}
    on:listDeleteSelected={deleteSelectedHandler}
    addButtonVisibility={false}
  />{/if}
