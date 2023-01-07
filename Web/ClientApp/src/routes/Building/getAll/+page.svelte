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
  import { getAllBuildings, deleteBuilding } from "$lib/stores/Building";
  import ShowBuildingPopUp from "$lib/components/ShowBuildingPopUp.svelte";
  import PropertyManagerForm from "../../../lib/components/PropertyManagerForm.svelte";
  let displayAll;
  let displayPopUp;
  let displayGetAllProblem;
  let errorMessage = "Nie udało się pobrać danych o Budynkach z bazy danych";
  let buildingsJSON;
  let BuildingDTO;
  let idToDelete;
  let showBuildingPopUpMessage =
    "Jesteś pewny, że chcesz usunąć poniższy Budynek?";

  onMount(async () => {
    let buildings = await getAllBuildings();
    if (buildings instanceof Error) {
      displayAll = false;
      displayGetAllProblem = true;
    } else if (buildings instanceof Response) {
      buildingsJSON = await buildings.json();
      console.log(buildingsJSON);
      if (buildingsJSON.length == 0) {
        errorMessage = "Brak budynków w bazie danych";
        displayGetAllProblem = true;
      } else {
        displayAll = true;
      }
    }
  });
  function edit(id) {
    // localStorage.setItem("manager_to_update_id", id);
    window.location.href = `/Building/update/${id}`;
  }
  function displayConfirmPopUp(building) {
    idToDelete = building.id;
    displayAll = false;
    displayPopUp = true;
    BuildingDTO = building;
  }
  async function deleteChosenBuilding(id) {
    let response = await deleteBuilding(id);
    if (response instanceof Response) {
      alert("Pomyślnie usunięto wybrany Budynek");
    }
    window.location.reload();
  }
</script>

<div class="mx-[5%] w-[90%] text-center">
  <a href="/Building/create"> 
    <button class="mx-auto p-4 rounded-md w-1/2 bg-[#007acc]">Dodaj budynek</button>
  </a>
</div>

<div class="display-all-buildings">
  {#if displayAll}
    <table class="my-[2%] mx-auto bg-white border-2 border-slate-600 rounded-sm w-[90%] text-left">
      <tbody class="[&>*:nth-child(odd)]:bg-[#dee8f5]">
        <tr class="text-xs font-bold border-b-2 border-slate-600 p-2">
          <td colspan="4">Adres budynku</td>
          <td>Typ budynku</td>
          <td>Zarządca</td>
          <td>Nr telefonu</td>
          <td>Adres zarządcy</td>
          <td>Numer lokalu</td>
          <td>Numer klatki</td>
          <td>Kod pocztowy</td>
          <td colspan="2"></td>
        </tr>
        {#each buildingsJSON as building}
          <tr>
            <td>{building.buildingAddress.postalCode}</td>
            <td>{building.buildingAddress.cityName}</td>
            <td>{building.buildingAddress.streetName}</td>
            <td>{building.buildingAddress.buildingNumber}</td>
            <td>{building.type}</td>

            {#if building.propertyManager}
              <td>{building.propertyManager.name}</td>
              <td>{building.propertyManager.phoneNumber}</td>
              <td
                >{building.propertyManager.fullAddress.buildingAddress
                  .streetName}
                {building.propertyManager.fullAddress.buildingAddress
                  .buildingNumber}
              </td>
              <td>{building.propertyManager.fullAddress.localNumber}</td>

              <td>{building.propertyManager.fullAddress.staircaseNumber}</td>
              <td
                >{building.propertyManager.fullAddress.buildingAddress
                  .postalCode}</td
              >
            {/if}

            <td
              ><button class="bg-yellow-500 decoration-none text-black text-base py-[1%] m-[5%] rounded-md justify-center cursor-pointer flex w-[50px] h-[25px]"
                on:click|preventDefault={() => edit(building.id)}
                ><div class="edit icon" /></button
              ></td
            >
            <td
              ><button class="bg-red-500 decoration-none text-black text-base p-[1%] m-[5%] rounded-md justify-center cursor-pointer flex w-[50px] h-[25px]"
                on:click|preventDefault={() => displayConfirmPopUp(building)}
                ><div class="trash icon"/></button
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
    <div class="w-[100%] h-[100%] m-0 p-0 top-0 left-0 fixed bg-black/80">
      <div class="w-[50%] h-[50%] relative my-[10%] mx-auto bg-white rounded-2xl">
        <ShowBuildingPopUp
          {BuildingDTO}
          message1="Czy na pewno chcesz usunąć poniższy budynek:"
          message2="podlegający pod Zarządcę Nieruchomości:"
        />
        <button
        class="bg-green-500 uppercase decoration-none text-black text-base py-[1%] my-[5%] mx-auto rounded-md flex w-[60%] justify-center cursor-pointer"
          on:click|preventDefault={async () =>
            await deleteChosenBuilding(idToDelete)}>TAK, USUŃ</button
        >
        <button
        class="bg-red-500 uppercase decoration-none text-black text-base py-[1%] my-[5%] mx-auto rounded-md flex w-[60%] justify-center cursor-pointer"
          on:click|preventDefault={() => window.location.reload()}
          >ANULUJ</button
        >
      </div>
    </div>{/if}
</div>

<style>
  .edit.icon {
    color: #000;
    position: absolute;
    margin-left: 4px;
    margin-top: 7px;
    width: 14px;
    height: 2px;
    border-radius: 1px;
    border: solid 1px currentColor;
    -webkit-transform: rotate(-45deg);
    transform: rotate(-45deg);
  }

  .edit.icon:before {
    content: "";
    position: absolute;
    left: -12px;
    top: -1px;
    width: 0px;
    height: 0px;
    border-left: solid 5px transparent;
    border-right: solid 5px currentColor;
    border-top: solid 2px transparent;
    border-bottom: solid 2px transparent;
  }

  .trash.icon {
    color: #000;
    position: absolute;
    margin-left: 5px;
    margin-top: 7px;
    width: 9px;
    height: 10px;
    border-left: solid 1px currentColor;
    border-right: solid 1px currentColor;
    border-bottom: solid 1px currentColor;
    border-radius: 0 0 2px 2px;
  }

  .trash.icon:before {
    content: "";
    position: absolute;
    left: -4px;
    top: -2px;
    width: 17px;
    height: 1px;
    background-color: currentColor;
  }

  .trash.icon:after {
    content: "";
    position: absolute;
    left: 0px;
    top: -5px;
    width: 7px;
    height: 2px;
    border-left: solid 1px currentColor;
    border-right: solid 1px currentColor;
    border-top: solid 1px currentColor;
    border-radius: 4px 4px 0 0;
  }
</style>
