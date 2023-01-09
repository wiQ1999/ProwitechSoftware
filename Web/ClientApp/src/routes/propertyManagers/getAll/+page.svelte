<script>
  // struktura PropertyManagerDTO
  //   let PropertyManagerDTO = {
  //     id: "",
  //     name: "",
  //     phoneNumber: "",
  //     fullAddress: {
  //       buildingAddress: {
  //         cityName: "",
  //         streetName: "",
  //         buildingNumber: "",
  //         postalCode: "",
  //       },
  //       localNumber: "",
  //       staircaseNumber: "",
  //     },
  //   };

  import { onMount } from "svelte";
  import { goto } from "$app/navigation";
  import BaseList from "$lib/components/base/BaseList.svelte";
  import {
    getAllPropertyManagers,
    deletePropertyManager,
  } from "$lib/stores/PropertyManager";
  import { openModal } from "svelte-modals";
  import BaseConfirmPopUp from "$lib/components/base/BaseConfirmPopUp.svelte";
  import BasePopUp from "$lib/components/base/BasePopUp.svelte";
  let collection = [];
  let tableRowsClassName = "propertyManagers-base-list";

  onMount(async () => {
    let response = await getAllPropertyManagers();
    if (response instanceof Response) {
      collection = await response.json();
    }
  });
  const headerDictionary = {
    Nazwa: "name",
    Telefon: "phoneNumber",
    Miasto: "fullAddress.buildingAddress.cityName",
    Ulica: "fullAddress.buildingAddress.streetName",
    "Numer budynku": "fullAddress.buildingAddress.buildingNumber",
    "Numer lokalu": "fullAddress.propertyAddress.venueNumber",
    "Numer klatki": "fullAddress.propertyAddress.staircaseNumber",
    "Kod pocztowy": "fullAddress.buildingAddress.postalCode",
  };
  function addHandler(event) {
    goto(`/propertyManagers/create`);
  }

  function detailHandler(event) {
    goto(`/propertyManagers/details/${event.detail.row.id}`);
  }

  async function deleteHandler(event) {
    openModal(BaseConfirmPopUp, {
      title: "Potwierdź akcję",
      message: "Czy na pewno chcesz usunąć wybranego Zarządcę Nieruchomości?",
      onOkay: async () => await deleteAndReload(event.detail.row.id),
      undoSingleColorSelection: true,
      selectedElementHtmlDomId: `${tableRowsClassName}-${event.detail.row.id}`,
    });
  }

  async function deleteAndReload(id) {
    let response = await deletePropertyManager(id);
    if (response instanceof Response) {
      openModal(BasePopUp, {
        title: "Udana akcja",
        message: "Pomyślnie usunięto wybranego Zarządcę Nieruchomości",
        reloadRequired: true,
      });
    }
  }

  async function deleteSelectedHandler(event) {
    const rows = event.detail.rows;
    openModal(BaseConfirmPopUp, {
      title: "Potwierdź akcję",
      message: "Czy na pewno chcesz usunąć zaznaczonych Zarządców?",
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
      deleteResult = await deletePropertyManager(rows[i].id);
      if (!(deleteResult instanceof Response)) errorOccured = true;
    }
    if (!errorOccured) {
      openModal(BasePopUp, {
        title: "Udana akcja",
        message: "Pomyślnie usunięto zaznaczonych Zarządców",
        reloadRequired: true,
      });
    }
  }
</script>

<BaseList
  {collection}
  {headerDictionary}
  {tableRowsClassName}
  on:listAdd={addHandler}
  on:listDetail={detailHandler}
  on:listDelete={deleteHandler}
  on:listDeleteSelected={deleteSelectedHandler}
/>
