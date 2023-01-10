<script>
  // struktura AddUpdateBuildingAddressReponse:
  // {
  //   "addedBuildingAddress": {
  //     "id": "00000000-0000-0000-0000-000000000000",
  //     "cityName": "Poznań",
  //     "streetName": "Słowackiego",
  //     "buildingNumber": "23",
  //     "longitude": 16.9072995,
  //     "latitude": 52.41043699999999,
  //     "coordinateType": "ROOFTOP",
  //     "postalCode": "60-822"
  //   },
  //   "googleApiStatus": "OK",
  //   "coordinateType": "ROOFTOP",
  //   "httpStatusResponse": "OK",
  //   "httpStatusCode": 200,
  //   "webApiStatus": "ADDED_TO_DB",
  //   "googleAPIFormattedAddress": "Słowackiego 23, 60-822 Poznań, Polska"
  // }

  /** @type {import('./$types').PageData} */
  export let data;

  import {
    tryToUpdateBuildingAddress,
    checkIfUpdatedBuildingAddressAndOriginalBuildingAddressDiffer,
  } from "$lib/stores/BuildingAddress";
  import { chooseNewStringIfNewDiffersFromOld } from "$lib/js-lib/helpers";
  import { getBuildingById, updateBuilding } from "$lib/stores/Building.js";
  import ShowBuildingPopUp from "$lib/components/ShowBuildingPopUp.svelte";
  import { onMount } from "svelte";
  import BuildingForm from "$lib/components/BuildingForm.svelte";
  import EditBuildingAddressPopUp from "$lib/components/EditBuildingAddressPopUp.svelte";
  import { AddUpdateBuildingAddressRequestResult } from "$lib/js-lib/helpers";

  //dane pobrane z getBuildingById - pierwotne i podlegające zmianie
  let originalBuildingDTO;
  let updateBuildingDTO;
  //--
  let originalBuildingAddressDTO;
  let updateBuildingAddressDTO;
  //--
  let originalPropertyManagerId;
  let updatePropertyManagerId;
  //--
  let originalBuildingType;
  let updateBuildingType;
  //---------------------------------------
  //części wpływające na wygląd
  let editBuildingAddressPopUpVisibility;
  let corrdinates_not_found_message;
  let formVisibility;
  let errorDivVisibility;
  let updatedBuildingPopUpVisibility;
  let showBuildingPopUpMessage;
  //---------------------------------------
  let buildingAddressId;

  let buildingAddressChanged;
  let otherBuildingDataChanged;

  let buildingAddressesDontDiffer;
  let buildingAddressUpdateError;

  let BuildingDTO;
  let AddUpdateBuildingAddressResponse;

  onMount(async () => {
    updatedBuildingPopUpVisibility = false;
    editBuildingAddressPopUpVisibility = false;
    await prepareForm(data.id);
  });
  //data --> pobierane dane z URLa przez funkcję load (w pliku +page.js w bieżącym folderze)
  //-----------------------------------------------------------------------------------------
  // STRUKTURA GET_BUILDING_BY_ID:
  //   {
  //   "id": "fbd74583-a8b5-4954-67c9-08dacb03ff5f",
  //   "buildingAddress": {
  //     "id": "41896088-6304-4dce-bafa-96e671b7c75a",
  //     "cityName": "Poznań",
  //     "streetName": "św. Marcin",
  //     "buildingNumber": "99",
  //     "longitude": null,
  //     "latitude": null,
  //     "coordinateType": null,
  //     "postalCode": "61-804"
  //   },
  //   "type": "wielolokalowy",
  //   "locals": [],
  //   "propertyManager": {
  //     "id": "38974075-73ac-46dd-34e4-08dacaf3e376",
  //     "name": "Poznanskie Betlejem",
  //     "phoneNumber": "+48 756 4563 212",
  //     "fullAddress": {
  //       "id": "a7de7d5b-6f3b-4f0c-c160-08dacaf3e366",
  //       "buildingAddressId": "b0046c21-eb1c-4980-8f78-fd1431ff6bcc",
  //       "buildingAddress": null,
  //       "localNumber": "6",
  //       "staircaseNumber": "c"
  //     }
  //   }
  // }

  async function prepareForm(buildingId) {
    let buildingResponse = await getBuildingById(buildingId);
    if (buildingResponse instanceof Response) {
      originalBuildingDTO = await buildingResponse.json();
      // updateBuildingDTO = structuredClone(originalBuildingDTO);
      // //--
      originalBuildingAddressDTO = originalBuildingDTO.buildingAddress;
      updateBuildingAddressDTO = structuredClone(originalBuildingAddressDTO);
      //--
      if (originalBuildingDTO.propertyManager != null) {
        originalPropertyManagerId = originalBuildingDTO.propertyManager.id;
      } else {
        originalPropertyManagerId = null;
      }
      updatePropertyManagerId = structuredClone(originalPropertyManagerId);
      //--
      originalBuildingType = originalBuildingDTO.type;
      updateBuildingType = structuredClone(originalBuildingType);

      formVisibility = true;
    } else {
      errorDivVisibility = true;
    }
  }
  async function updateBuildingAllData(
    newBuildingAddressDTO,
    newPropertyManagerId,
    newBuildingType
  ) {
    await updateBuildingAddressOnly(
      newBuildingAddressDTO,
      originalBuildingAddressDTO
    );
    if (
      buildingAddressChanged ||
      buildingAddressesDontDiffer ||
      buildingAddressUpdateError
    ) {
      await updateBuildingDataWithoutBuildingAddress(
        newPropertyManagerId,
        newBuildingType,
        buildingAddressChanged
      );
    }
  }

  async function updateBuildingAddressOnly(
    newBuildingAddressDTO,
    oldBuildingAddressDTO
  ) {
    let newAndOldAddressDiffer =
      checkIfUpdatedBuildingAddressAndOriginalBuildingAddressDiffer(
        newBuildingAddressDTO,
        oldBuildingAddressDTO
      );
    if (!newAndOldAddressDiffer) {
      buildingAddressChanged = false;
      buildingAddressesDontDiffer = true;
      return;
    }
    let addressUpdatedAtOnce = await tryToUpdateBuildingAddress(
      newBuildingAddressDTO
    );
    if (addressUpdatedAtOnce == AddUpdateBuildingAddressRequestResult.success) {
      {
        buildingAddressChanged = true;
        return;
      }
    } else if (
      addressUpdatedAtOnce == AddUpdateBuildingAddressRequestResult.error
    ) {
      buildingAddressChanged = false;
      buildingAddressUpdateError = true;
      return;
    } else if (
      addressUpdatedAtOnce ==
      AddUpdateBuildingAddressRequestResult.overQueryLimit
    ) {
      alert("Problem z GoogleAPI - przekroczono limit reuqestów");
      buildingAddressChanged = false;
      return;
    } else {
      //COORDINATE_TYPE_ISSUE - pokaż okno potwierdzające
      corrdinates_not_found_message = prepareMessage(
        newBuildingAddressDTO,
        addressUpdatedAtOnce
      );
      AddUpdateBuildingAddressResponse = addressUpdatedAtOnce;
      formVisibility = false;
      editBuildingAddressPopUpVisibility = true;
    }
  }

  async function updateBuildingDataWithoutBuildingAddress(
    newPropertyManagerId,
    newType,
    buildingAddressChanged
  ) {
    let propertyManagerIdForBuildingUpdate = chooseNewStringIfNewDiffersFromOld(
      originalPropertyManagerId,
      newPropertyManagerId
    );
    let buildingTypeForUpdate = chooseNewStringIfNewDiffersFromOld(
      originalBuildingType,
      newType
    );

    if (
      propertyManagerIdForBuildingUpdate != originalPropertyManagerId ||
      buildingTypeForUpdate != originalBuildingType
    ) {
      updateBuildingDTO = {
        id: originalBuildingDTO.id,
        type: buildingTypeForUpdate,
        propertyManagerId: propertyManagerIdForBuildingUpdate,
      };
      console.log(updateBuildingDTO);
      let updateSuccess = await updateBuilding(updateBuildingDTO);
      if (updateSuccess) {
        otherBuildingDataChanged = true;
      } else {
        otherBuildingDataChanged = false;
      }
    } else {
      otherBuildingDataChanged = false;
    }

    displayBuildingAfterUpdate(
      originalBuildingDTO.id,
      buildingAddressChanged,
      otherBuildingDataChanged
    );
  }

  async function displayBuildingAfterUpdate(
    id,
    buildingAddressChanged,
    otherDataChanged
  ) {
    let message;

    if (buildingAddressChanged && otherDataChanged) {
      message = "Dane Budynku po edycji adresu budynku oraz innych danych:";
    } else if (buildingAddressChanged) {
      message =
        "Zmieniono adres Budynku BEZ innych danych. Dane Budynku po aktualizacji:";
    } else if (otherDataChanged) {
      message = "Zmieniono dane Budynku BEZ zmiany adresu budynku. Nowe dane:";
    } else {
      message = "Żadne dane nie zostały zmienione. Poniżej aktualne dane:";
    }

    let buildingAfterUpdate = await getBuildingById(id);

    if (buildingAfterUpdate instanceof Response) {
      BuildingDTO = await buildingAfterUpdate.json();
    } else {
      BuildingDTO = null;
    }
    formVisibility = false;
    showBuildingPopUpMessage = message;
    updatedBuildingPopUpVisibility = true;
  }

  function prepareMessage(
    updateBuildingAddressTriedToBePut,
    AddUpdateBuildingAddressReponse
  ) {
    let cityName = updateBuildingAddressTriedToBePut.cityName;
    let streetName = updateBuildingAddressTriedToBePut.streetName;
    let buildingNumber = updateBuildingAddressTriedToBePut.buildingNumber;

    return `Nie znaleziono dokładnych współrzędnych dla adresu ${streetName} ${buildingNumber}, ${cityName}
    \nOdnaleziono współrzędne dla adresu: ${AddUpdateBuildingAddressReponse.googleAPIFormattedAddress}.
    \nCzy chce je zachować?`;
  }
</script>

<a href="/buildings/getAll">
  <button
    class="bg-red-500 uppercase decoration-none text-black text-base py-[1%] mx-auto rounded-md flex w-[60%] justify-center cursor-pointer"
    >Powrót</button
  >
</a>
<div class="add-property-manager-form">
  {#if editBuildingAddressPopUpVisibility}
    <EditBuildingAddressPopUp
      updateBuildingAddressDTO={AddUpdateBuildingAddressResponse.addedBuildingAddress}
      {corrdinates_not_found_message}
      continueEdition={async () =>
        await updateBuildingDataWithoutBuildingAddress(
          updatePropertyManagerId,
          updateBuildingType,
          buildingAddressChanged
        )}
      bind:buildingAddressId
      bind:buildingAddressChanged
    />
  {/if}
  {#if errorDivVisibility}
    <div>Błąd ładowania danych Budynku do edycji</div>
  {/if}
  {#if formVisibility}
    <BuildingForm
      bind:buildingAddressDTO={updateBuildingAddressDTO}
      bind:propertyManagerId={updatePropertyManagerId}
      bind:buildingType={updateBuildingType}
      onSubmit={async () =>
        await updateBuildingAllData(
          updateBuildingAddressDTO,
          updatePropertyManagerId,
          updateBuildingType
        )}
      editMode={true}
      building={originalBuildingDTO}
    />{/if}
  {#if updatedBuildingPopUpVisibility}
    <ShowBuildingPopUp
      {BuildingDTO}
      message1={showBuildingPopUpMessage}
      message2="podlegający pod Zarządcę Nieruchomości:"
    />
  {/if}
</div>
