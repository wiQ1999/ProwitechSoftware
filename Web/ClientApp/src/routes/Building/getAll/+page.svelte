<script>
  //STRUKTURA JEDNEGO BUDYNKU Z GET_ALL()
  //  {
  //     "id": "d31430c9-2b95-4854-14eb-08dac9389dcd",
  //     "buildingAddress": {
  //       "id": "922992d5-f753-41ed-b1e0-4efb62dafee3",
  //       "cityName": "Wrocław",
  //       "streetName": "Baśniowa",
  //       "buildingNumber": "712",
  //       "longitude": null,
  //       "latitude": null,
  //       "coordinateType": null,
  //       "postalCode": "51"
  //     },
  //     "type": "lokal usługowy",
  //     "propertyManager": {
  //       "id": "f18e425a-ad93-4c5f-a130-08dac6d96ba1",
  //       "name": "Grube Ryby",
  //       "phoneNumber": "+48 722 222 222",
  //       "fullAddress": {
  //         "id": "e13dd7a1-5656-40cb-5a75-08dac6d96b9a",
  //         "buildingAddressId": "f6bb89f1-7b20-463a-b2d9-28444d942c88",
  //         "buildingAddress": {
  //           "id": "f6bb89f1-7b20-463a-b2d9-28444d942c88",
  //           "cityName": "Poznań",
  //           "streetName": "Pawia",
  //           "buildingNumber": "12",
  //           "longitude": 16.945237,
  //           "latitude": 52.380728,
  //           "coordinateType": "ROOFTOP",
  //           "postalCode": "61-300"
  //         },
  //         "localNumber": "6",
  //         "staircaseNumber": "D"
  //       }
  //     }
  //   }
  import { onMount } from "svelte";
  import { goto } from "$app/navigation";
  import BaseList from "$lib/components/base/BaseList.svelte";
  import { openModal } from "svelte-modals";
  import BaseConfirmPopUp from "$lib/components/base/BaseConfirmPopUp.svelte";
  import BasePopUp from "$lib/components/base/BasePopUp.svelte";
  import { getAllBuildings, deleteBuilding } from "$lib/stores/Building";

  let collection = [];
  let tableRowsClassName="building-base-list"
  onMount(async () => {
    collection = await getAllBuildings();
  });

  const headerDictionary = {
    Miasto: "buildingAddress.cityName",
    Ulica: "buildingAddress.streetName",
    "Numer budynku": "buildingAddress.buildingNumber",
    "Kod pocztowy": "buildingAddress.postalCode",
    Typ: "type",
    "Zarządca Nieruchomości": "propertyManager.name",
  };

  function addHandler(event) {
    goto(`/building/create`);
  }

  function detailHandler(event) {
    goto(`/building/update/${event.detail.row.id}`);
  }

  async function deleteHandler(event) {
    openModal(BaseConfirmPopUp, {
      title: "Potwierdź akcję",
      message: "Czy na pewno chcesz usunąć wybrany budynek?",
      onOkay: async () => await deleteAndReload(event.detail.row.id),
      undoSingleColorSelection: true,
      selectedElementHtmlDomId: `${tableRowsClassName}-${event.detail.row.id}`
    });
  }

  async function deleteAndReload(id) {
    let response = await deleteBuilding(id);
    if (response instanceof Response) {
      openModal(BasePopUp, {
        title: "Udana akcja",
        message: "Pomyślnie usunięto wybrany budynek",
        reloadRequired: true
      });
    }
  }

  async function deleteSelectedHandler(event) {
    const rows = event.detail.rows;
    openModal(BaseConfirmPopUp, {
      title: "Potwierdź akcję",
      message: "Czy na pewno chcesz usunąć zaznaczone budynki?",
      onOkay: async () => await deleteSelectedAndReload(rows),
      undoMultipleColorSelection: true,
      selectedClassName: tableRowsClassName
    });
  }
  async function deleteSelectedAndReload(rows) {
    if (rows == null) return;
    let errorOccured = false;
    let deleteResult;

    for (let i = 0; i < rows.length; i++) {
      deleteResult = await deleteBuilding(rows[i].id);
      if (!(deleteResult instanceof Response)) errorOccured = true;
    }
    if (!errorOccured) {
      openModal(BasePopUp, {
        title: "Udana akcja",
        message: "Pomyślnie usunięto zaznaczone budynki",
        reloadRequired: true
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