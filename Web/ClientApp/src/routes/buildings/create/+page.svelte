<script>
  //struktura jednego rekordu z getAllPropertyManagers()
  // {
  // "id": "4b8855bc-1057-41dd-0a56-08dabf373e96",
  // "name": "Klub Sportowy Zawisza",
  // "phoneNumber": "",
  // "fullAddress": {
  //   "id": "d3bc1437-a363-4d7c-5487-08dabf373e80",
  //   "buildingAddressId": "47054ff8-e3c3-4034-8629-bdc4da733944",
  //   "buildingAddress": {
  //     "id": "47054ff8-e3c3-4034-8629-bdc4da733944",
  //     "cityName": "Bydgoszcz",
  //     "streetName": "Gdańska",
  //     "buildingNumber": "445",
  //     "longitude": null,
  //     "latitude": null,
  //     "coordinateType": null,
  //     "postalCode": "86-031"
  //   },
  //   "localNumber": "1",
  //   "staircaseNumber": "F"
  // }
  //struktura newBuilding:
  //   {
  //   "id": "472e6029-2cfb-483e-f2ff-08daca1119fe",
  //   "buildingAddress": {
  //     "id": "d24bd875-c5f8-4a7c-a1c3-ff33f67b6c67",
  //     "cityName": "Poznań",
  //     "streetName": "Heweliusza",
  //     "buildingNumber": "3",
  //     "longitude": 16.8725373,
  //     "latitude": 52.394716,
  //     "coordinateType": "ROOFTOP",
  //     "postalCode": "61-001"
  //   },
  //   "type": "wielolokalowy",
  //   "locals": [],
  //   "propertyManager": {
  //     "id": "a9cc9b5b-9f73-4bc6-0f76-08dac7a32061",
  //     "name": "Fruwające krowy",
  //     "phoneNumber": "+48 956 232 125",
  //     "fullAddress": {
  //       "id": "69220a87-62c1-4953-4cde-08dac7a32055",
  //       "buildingAddressId": "c16ec69d-0583-4df6-b00f-6ea20754b392",
  //       "buildingAddress": null,
  //       "localNumber": "15",
  //       "staircaseNumber": "C"
  //     }
  //   }
  // }

  import AddBuildingAddressPopUp from "$lib/components/AddBuildingAddressPopUp.svelte";
  import BuildingForm from "$lib/components/BuildingForm.svelte";
  import {
    getBuildingAddressById,
    postBuildingAddress,
    getBuildingAddressIdIfAlredyExists,
    deleteBuildingAddress,
  } from "$lib/stores/BuildingAddress";
  import { prepareCoordinatesNotFoundMessage } from "$lib/js-lib/helpers";
  import { onMount } from "svelte";
  import { postBuilding, getBuildingById } from "$lib/stores/Building";
  import ShowBuildingPopUp from "$lib/components/ShowBuildingPopUp.svelte";
  let buildingAddressDTO;
  let propertyManagerId;
  let addedBuildingAddress;
  let corrdinates_not_found_message;
  let buildingAddressId;
  let buildingType;
  let newBuildingData;

  let propertyManagers = [];

  //zmienne odpowiedzialne za wygląd
  let formVisibility;
  let buildingAddressConfirmPopUpVisibility;
  let showBuildingPopUpVisibility = false;
  let message1;
  let message2;
  //---------------------------------------------
  onMount(async () => {
    formVisibility = true;
    buildingAddressConfirmPopUpVisibility = false;
  });
  async function tryToAddBuildingAddress(bDTO) {
    let optionalArguments = {
      force: false,
      onlyAddress: false,
    };

    let buildingAddressPostResult = await postBuildingAddress(
      bDTO,
      optionalArguments
    );

    if (buildingAddressPostResult instanceof Error) {
      // window.location.reload();
    } else if (buildingAddressPostResult instanceof Response) {
      let buildingAddressJSON = await buildingAddressPostResult.json();
      if (buildingAddressJSON.webApiStatus == "ADDED_TO_DB") {
        buildingAddressId = buildingAddressJSON.addedBuildingAddress.id;
        await createBuilding(
          buildingAddressId,
          propertyManagerId,
          buildingType
        );
      } else {
        addedBuildingAddress = buildingAddressJSON.addedBuildingAddress;
        corrdinates_not_found_message = prepareCoordinatesNotFoundMessage(
          addedBuildingAddress,
          buildingAddressJSON
        );
        buildingAddressConfirmPopUpVisibility = true;
        formVisibility = false;
      }
    }
  }
  async function createBuilding(baId, propId, bType) {
    if (baId != "00000000-0000-0000-0000-000000000000") {
      let buildingPostResult = await postBuilding(baId, propId, bType);
      if (buildingPostResult instanceof Response) {
        let buildingId = await buildingPostResult.json();
        // console.log(buildingId);
        await showNewBuilding(buildingId);
      } else if (buildingPostResult instanceof Error) {
        await deleteBuildingAddress(baId);
      }
    }
  }
  async function showNewBuilding(bId) {
    let newBuildingGetResult = await getBuildingById(bId);

    if (newBuildingGetResult instanceof Response) {
      newBuildingData = await newBuildingGetResult.json();
      message1 = "Udało się dodać do bazy danych Budynek o poniższych danych:";
      message2 = "Zarządcą powyższej Nieruchomości jest firma:";
      console.log(newBuildingData);
    } else {
      newBuildingData = null;
    }
    formVisibility = false;
    showBuildingPopUpVisibility = true;
  }
</script>

<a href="/buildings/getAll">
  <button class="bg-red-500 uppercase decoration-none text-black text-base font-semibold py-[1%] mx-auto rounded-md flex w-[60%] justify-center cursor-pointer">Powrót</button>
</a>
<div>
  {#if buildingAddressConfirmPopUpVisibility}
    <AddBuildingAddressPopUp
      {addedBuildingAddress}
      {corrdinates_not_found_message}
      functionToInvokeAfterAdding={async () =>
        await createBuilding(
          buildingAddressId,
          propertyManagerId,
          buildingType
        )}
      bind:buildingAddressId
    />
  {/if}
  {#if formVisibility}
    <BuildingForm
      bind:buildingAddressDTO
      bind:propertyManagerId
      bind:buildingType
      onSubmit={async () => await tryToAddBuildingAddress(buildingAddressDTO)}
    />{/if}
  {#if showBuildingPopUpVisibility}
  <div>
    <ShowBuildingPopUp BuildingDTO={newBuildingData} {message1} {message2} />
  </div>
    {/if}
</div>

