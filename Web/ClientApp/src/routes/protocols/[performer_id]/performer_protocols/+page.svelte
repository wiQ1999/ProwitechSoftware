<script>
  import { onMount } from "svelte";
  import { goto } from "$app/navigation";
  import { page } from "$app/stores";
  import ModifiedBaseList from "$lib/components/base/ModifiedBaseList.svelte";
  import { openModal } from "svelte-modals";
  import BaseConfirmPopUp from "$lib/components/base/BaseConfirmPopUp.svelte";
  import BasePopUp from "$lib/components/base/BasePopUp.svelte";
  import {
    getPerformerProtocols,
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

    let protocolResponse = await getPerformerProtocols(
      $page.params.performer_id
    );
    if (protocolResponse instanceof Error) return;
    let protocols = await protocolResponse.json();
    //TODO POBRAĆ DANE ZALOGOWANEGO UŻYTKOWNIKA
    listName = "ALOJZY PTYŚ - PROTOKOŁY";
    collection = protocols;
    baseListVisibility = true;
  });

  const headerDictionary = {
    Numer: "number",
    Przeprowadzono: "inspectionDateTime",
    // Wykonujący: "inspectionPerformer.login",
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

  function detailHandler(event) {
    goto(
      `/protocols/${$page.params.performer_id}/details/${event.detail.row.id}`
    );
    // goto(`/protocols/details/${event.detail.row.id}`);
  }
</script>

<a href="/protocols">
  <button
    class="bg-red-500 uppercase decoration-none text-black text-base py-[1%] mx-auto rounded-md flex w-[60%] justify-center cursor-pointer"
    >Powrót</button
  >
</a>

{#if baseListVisibility}
  <ModifiedBaseList
    {listName}
    {collection}
    {headerDictionary}
    {tableRowsClassName}
    firstButtonVisibility={true}
    firstButtonMessage="Szczegóły"
    on:firstButtonAction={detailHandler}
    secondButtonVisibility={false}
  />{/if}
