<script>
  import { onMount } from "svelte";
  import { goto } from "$app/navigation";
  import { page } from "$app/stores";
  import BaseList from "$lib/components/base/BaseList.svelte";
  import { openModal } from "svelte-modals";
  import BaseConfirmPopUp from "$lib/components/base/BaseConfirmPopUp.svelte";
  import BasePopUp from "$lib/components/base/BasePopUp.svelte";
  import { getBuildingById } from "$lib/stores/Building";
  import {
    deleteRealProperty,
    compareRealPropertiesByVenueNumber,
  } from "$lib/stores/RealProperty";

  let collection = [];
  let tableRowsClassName = "real-properties-base-list";
  let building;
  let listName = "";
  let buildingTypeError = false;
  let baseListVisibility = false;
  let buildingInfoVisibility = false;
  let buildingTypeErrorMessage;
  onMount(async () => {
    buildingTypeError = false;
    baseListVisibility = false;

    let buildingResponse = await getBuildingById($page.params.slug);

    if (buildingResponse instanceof Error) return;

    building = await buildingResponse.json();
    if (building.type != "WIELOLOKALOWY") {
      buildingTypeError = true;
      buildingTypeErrorMessage = `Budynek pod adresem ${building.buildingAddress.streetName} ${building.buildingAddress.buildingNumber} ${building.buildingAddress.cityName} nie składa się z wielu lokali. BRAK LOKALI DO WYŚWIETLENIA`;
      return;
    }
    listName = `${building.buildingAddress.streetName} ${building.buildingAddress.buildingNumber} ${building.buildingAddress.cityName} - LISTA LOKALI`;
    collection = building.properties.sort(compareRealPropertiesByVenueNumber);
    buildingInfoVisibility = true;
    baseListVisibility = true;
  });

  const headerDictionary = {
    Numer: "propertyAddress.venueNumber",
    "Numer klatki schodowej": "propertyAddress.staircaseNumber",
  };

  function addHandler(event) {
    goto(`/buildings/details/${$page.params.slug}/real-properties/create`);
  }

  function detailHandler(event) {
    goto(
      `/buildings/details/${$page.params.slug}/real-properties/details/${event.detail.row.id}`
    );
  }

  async function deleteHandler(event) {
    openModal(BaseConfirmPopUp, {
      title: "Potwierdź akcję",
      message: "Czy na pewno chcesz usunąć wybraną nieruchomość?",
      onOkay: async () => await deleteAndReload(event.detail.row.id),
      undoSingleColorSelection: true,
      selectedElementHtmlDomId: `${tableRowsClassName}-${event.detail.row.id}`,
    });
  }

  async function deleteAndReload(id) {
    let response = await deleteRealProperty(id);
    if (response instanceof Response) {
      openModal(BasePopUp, {
        title: "Udana akcja",
        message: "Pomyślnie usunięto wybraną Nieruchomość",
        reloadRequired: true,
      });
    }
  }

  async function deleteSelectedHandler(event) {
    const rows = event.detail.rows;
    openModal(BaseConfirmPopUp, {
      title: "Potwierdź akcję",
      message: "Czy na pewno chcesz usunąć zaznaczone Nieruchomości?",
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
      deleteResult = await deleteRealProperty(rows[i].id);
      if (!(deleteResult instanceof Response)) errorOccured = true;
    }
    if (!errorOccured) {
      openModal(BasePopUp, {
        title: "Udana akcja",
        message: "Pomyślnie usunięto zaznaczone Nieruchomości",
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
{#if buildingTypeError}
  {buildingTypeErrorMessage}
{/if}
{#if baseListVisibility}
  <a href="/buildings/details/{$page.params.slug}">
    <button
      class="bg-red-500 uppercase decoration-none text-black text-base font-semibold py-[1%] mx-auto rounded-md flex w-[60%] justify-center cursor-pointer"
      >Powrót</button
    >
  </a>
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
