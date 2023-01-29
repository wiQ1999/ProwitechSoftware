<script>
  import { onMount } from "svelte";
  import { goto } from "$app/navigation";
  import BaseList from "$lib/components/base/BaseList.svelte";
  import { openModal } from "svelte-modals";
  import BaseConfirmPopUp from "$lib/components/base/BaseConfirmPopUp.svelte";
  import BasePopUp from "$lib/components/base/BasePopUp.svelte";
  import {
    getAllInspectionProtocols,
    deleteInspectionProtocol,
  } from "$lib/stores/InspectionProtocol";

  let collection = [];
  let tableRowsClassName = "inspection-protocols-base-list";
  let listName = "";
  let buildingTypeError = false;
  let baseListVisibility = false;
  onMount(async () => {
    buildingTypeError = false;
    baseListVisibility = false;

    let protocolResponse = await getAllInspectionProtocols();
    if (protocolResponse instanceof Error) return;
    let protocols = await protocolResponse.json();
    listName = "WSZYSTKIE PROTOKOŁY";
    collection = protocols;
    baseListVisibility = true;
  });

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
</script>

<a href="/protocols">
  <button
    class="bg-red-500 uppercase decoration-none text-black text-base py-[1%] mx-auto rounded-md flex w-[60%] justify-center cursor-pointer"
    >Powrót</button
  >
</a>
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
