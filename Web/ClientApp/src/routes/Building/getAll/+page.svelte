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
  import { getAllBuildings } from "../../../stores/Building";
  import ShowBuildingPopUp from "../../../components/ShowBuildingPopUp.svelte";
  let displayAll;
  let displayPopUp;
  let displayGetAllProblem;
  let errorMessage = "Nie udało się pobrać danych o Budynkach z bazy danych";
  let buildingsJSON;
  let PropertyManagerDTO;
  let idToDelete;
  let showPropertyManagerPopUpMessage =
    "Jesteś pewny, że chcesz usunąć poniższy Budynek?";

  onMount(async () => {
    let buildings = await getAllBuildings();
    if (buildings instanceof Error) {
      displayAll = false;
      displayGetAllProblem = true;
    } else if (buildings instanceof Response) {
      buildingsJSON = await buildings.json();
      console.log(buildingsJSON);
      displayAll = true;
    }
  });
  function edit(id) {
    // localStorage.setItem("manager_to_update_id", id);
    window.location.href = `/Building/update/${id}`;
  }
  function displayConfirmPopUp(manager) {
    PropertyManagerDTO = {
      name: manager.name,
      phoneNumber: manager.phoneNumber,
      fullAddress: {
        buildingAddress: {
          cityName: manager.fullAddress.buildingAddress.cityName,
          streetName: manager.fullAddress.buildingAddress.streetName,
          buildingNumber: manager.fullAddress.buildingAddress.buildingNumber,
          postalCode: manager.fullAddress.buildingAddress.postalCode,
        },
        localNumber: manager.fullAddress.localNumber,
        staircaseNumber: manager.fullAddress.staircaseNumber,
      },
    };
    idToDelete = manager.id;
    displayAll = false;
    displayPopUp = true;
  }
  async function deleteBuilding(id) {
    let response = await deletePropertyManager(id);
    if (response instanceof Response) {
      alert("Pomyślnie usunięto Zarządcę Nieruchomości");
    }
    window.location.reload();
  }
</script>

<div class="display-all-buildings">
  {#if displayAll}
    <table>
      <tbody>
        Budynki:
        {#each buildingsJSON as building}
          <tr>
            <td>{building.buildingAddress.cityName}</td>
            <td>{building.buildingAddress.streetName}</td>
            <td>{building.buildingAddress.buildingNumber}</td>
            <td>{building.buildingAddress.postalCode}</td>
            <td>{building.type}</td>

            <td>{building.propertyManager.name}</td>
            <td>{building.propertyManager.phoneNumber}</td>
            <td
              >{building.propertyManager.fullAddress.buildingAddress
                .streetName}</td
            >
            <td
              >{building.propertyManager.fullAddress.buildingAddress
                .buildingNumber}</td
            >
            <td>{building.propertyManager.fullAddress.localNumber}</td>
            <td>{building.propertyManager.fullAddress.staircaseNumber}</td>
            <td
              >{building.propertyManager.fullAddress.buildingAddress
                .postalCode}</td
            >

            <td
              ><button on:click|preventDefault={() => edit(building.id)}
                >Edytuj</button
              ></td
            >
            <td
              ><button
                on:click|preventDefault={() => displayConfirmPopUp(building)}
                >Usuń</button
              ></td
            >
            <!-- <button on:click|preventDefault={async () => await continueAdding()}
          >Kontynuuj</button
        > -->
          </tr>
        {/each}
      </tbody>
    </table>
  {:else if displayGetAllProblem}
    {errorMessage}
  {:else if displayPopUp}
    <div class="delete-building-confirm-pop-up">
      <!-- <ShowBuildingPopUp
        {PropertyManagerDTO}
        message={showPropertyManagerPopUpMessage}
      /> -->
      <button
        on:click|preventDefault={async () => await deleteBuilding(idToDelete)}
        >TAK, USUŃ</button
      >
      <button on:click|preventDefault={() => window.location.reload()}
        >ANULUJ</button
      >
    </div>{/if}
</div>
