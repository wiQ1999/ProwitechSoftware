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
</script>

{#if buildingTypeError}
  {buildingTypeErrorMessage}
{/if}
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
