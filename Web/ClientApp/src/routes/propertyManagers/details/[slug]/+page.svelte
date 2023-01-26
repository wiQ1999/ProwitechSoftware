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

  import { tryToUpdateBuildingAddress } from "$lib/stores/BuildingAddress";
  import { checkIfUpdatedBuildingAddressAndOriginalBuildingAddressDiffer } from "$lib/stores/BuildingAddress";
  import ShowPropertyManagerPopUp from "$lib/components/ShowPropertyManagerPopUp.svelte";
  import { onMount } from "svelte";
  import {
    getPropertyManagerById,
    checkIfPropManagersDiffer,
    updatePropertyManager,
  } from "$lib/stores/PropertyManager";
  import PropertyManagerForm from "$lib/components/PropertyManagerForm.svelte";
  import EditBuildingAddressPopUp from "$lib/components/EditBuildingAddressPopUp.svelte";
  import { AddUpdateBuildingAddressRequestResult } from "$lib/js-lib/helpers";

  //dane pobrane z getPropertyManagerById - pierwotne i podlegające zmianie
  let updateBuildingAddressDTO;
  let originalBuildingAddressDTO;
  let updatePropertyManagerDTO;
  let originalPropertyManagerDTO;
  //---------------------------------------
  //części wpływające na wygląd
  let editBuildingAddressPopUpVisibility;
  let corrdinates_not_found_message;
  let formVisibility;
  let errorDivVisibility;
  let updatedPropertyManagerPopUpVisibility;
  let showPropertyManagerPopUpMessage;
  //---------------------------------------
  let buildingAddressId;
  let postalCode = "BRAK";

  let buildingAddressChanged;
  let otherPropManagerDataChanged;

  let buildingAddressesDontDiffer;
  let buildingAddressUpdateError;

  let PropertyManagerDTO;
  let AddUpdateBuildingAddressResponse;

  onMount(async () => {
    updatedPropertyManagerPopUpVisibility = false;
    editBuildingAddressPopUpVisibility = false;
    await prepareForm(data.id);
  });
  //data --> pobierane dane z URLa przez funkcję load (w pliku +page.js w bieżącym folderze)
  //-----------------------------------------------------------------------------------------
  // struktura originalPropertyManagerDTO:
  // {
  //   "id": "4b8855bc-1057-41dd-0a56-08dabf373e96",
  //   "name": "Klub Sportowy Zawisza",
  //   "phoneNumber": "+48 999 999 999",
  //   "fullAddress": {
  //     "id": "d3bc1437-a363-4d7c-5487-08dabf373e80",
  //     "buildingAddressId": "47054ff8-e3c3-4034-8629-bdc4da733944",
  //     "buildingAddress": {
  //       "id": "47054ff8-e3c3-4034-8629-bdc4da733944",
  //       "cityName": "Bydgoszcz",
  //       "streetName": "Gdańska",
  //       "buildingNumber": "44",
  //       "longitude": 18.0075972,
  //       "latitude": 53.12941739999999,
  //       "coordinateType": "ROOFTOP",
  //       "postalCode": "85-008"
  //     },
  //     "localNumber": "1",
  //     "staircaseNumber": "F"
  //   }
  // }
  async function prepareForm(propertyManagerId) {
    let propertyManagerResponse = await getPropertyManagerById(
      propertyManagerId
    );
    if (propertyManagerResponse instanceof Response) {
      originalPropertyManagerDTO = await propertyManagerResponse.json();
      updatePropertyManagerDTO = structuredClone(originalPropertyManagerDTO);
      if (updatePropertyManagerDTO.fullAddress.propertyAddress == null) {
        updatePropertyManagerDTO.fullAddress.propertyAddress = {
          venueNumber: "",
          staircaseNumber: "",
        };
      }
      postalCode =
        originalPropertyManagerDTO.fullAddress?.buildingAddress?.postalCode;
      if (postalCode == undefined || postalCode == null || postalCode == "")
        postalCode = "BRAK";

      originalBuildingAddressDTO =
        originalPropertyManagerDTO.fullAddress.buildingAddress;
      updateBuildingAddressDTO = structuredClone(originalBuildingAddressDTO);
      console.log(updatePropertyManagerDTO);
      formVisibility = true;
    } else {
      errorDivVisibility = true;
    }
  }

  async function updatePropertyManagerAllData(
    newBuildingAddressDTO,
    oldBuildingAddressDTO
  ) {
    await updateBuildingAddressOnly(
      newBuildingAddressDTO,
      oldBuildingAddressDTO
    );
    if (
      buildingAddressChanged ||
      buildingAddressesDontDiffer ||
      buildingAddressUpdateError
    ) {
      await updatePropertyManagerDataWithoutBuildingAddress(
        updatePropertyManagerDTO,
        originalPropertyManagerDTO,
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

  async function updatePropertyManagerDataWithoutBuildingAddress(
    newPropertyManagerDTO,
    oldPropertyManagerDTO,
    buildingAddressChanged
  ) {
    let newAndOldPropManDiffer = checkIfPropManagersDiffer(
      newPropertyManagerDTO,
      oldPropertyManagerDTO
    );
    if (!newAndOldPropManDiffer) {
      otherPropManagerDataChanged = false;
    } else {
      let updateSuccess = await updatePropertyManager(newPropertyManagerDTO);
      if (updateSuccess) otherPropManagerDataChanged = true;
      else {
        return;
        //otherPropManagerDataChanged = false;
      }
    }
    displayPropertyManagerAfterUpdate(
      oldPropertyManagerDTO.id,
      buildingAddressChanged,
      otherPropManagerDataChanged
    );
  }

  async function displayPropertyManagerAfterUpdate(
    id,
    buildingAddressChanged,
    otherPropManagerDataChanged
  ) {
    let message;

    if (buildingAddressChanged && otherPropManagerDataChanged) {
      message =
        "Dane Zarządcy Nieruchomości po edycji adresu budynku oraz innych danych:";
    } else if (buildingAddressChanged) {
      message =
        "Zmieniono adres budynku Zarządcy Nieruchomości BEZ innych danych. Dane Zarządcy Nieruchomości po aktualizacji:";
    } else if (otherPropManagerDataChanged) {
      message =
        "Zmieniono dane Zarządcy Nieruchomości BEZ zmiany adresu budynku. Nowe dane:";
    } else {
      message = "Żadne dane nie zostały zmienione. Poniżej aktualne dane:";
    }

    let propertyManagerAfterUpdate = await getPropertyManagerById(id);

    if (propertyManagerAfterUpdate instanceof Response) {
      PropertyManagerDTO = await propertyManagerAfterUpdate.json();
    } else {
      PropertyManagerDTO = null;
    }
    formVisibility = false;
    showPropertyManagerPopUpMessage = message;
    editBuildingAddressPopUpVisibility = false;
    updatedPropertyManagerPopUpVisibility = true;
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

<a href="/propertyManagers/getAll">
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
        await updatePropertyManagerDataWithoutBuildingAddress(
          updatePropertyManagerDTO,
          originalPropertyManagerDTO,
          buildingAddressChanged
        )}
      bind:buildingAddressId
      bind:buildingAddressChanged
    />
  {/if}
  {#if errorDivVisibility}
    <div>Błąd ładowania danych Zarządcy Nieruchomości do edycji</div>
  {/if}
  {#if formVisibility}
    <PropertyManagerForm
      bind:buildingAddressDTO={updateBuildingAddressDTO}
      bind:propertyManagerDTO={updatePropertyManagerDTO}
      onSubmit={async () =>
        await updatePropertyManagerAllData(
          updateBuildingAddressDTO,
          originalBuildingAddressDTO
        )}
      editMode={true}
    />
  {/if}
  {#if updatedPropertyManagerPopUpVisibility}
    <ShowPropertyManagerPopUp
      {PropertyManagerDTO}
      message={showPropertyManagerPopUpMessage}
    />
  {/if}
</div>

<div
  class="w-1/2 my-[10px] mx-auto py-3 px-5 bg-[#f4f7f8] rounded-lg text-center"
>
  Kod pocztowy Zarządcy Nieruchomości
  <p class="font-bold">{postalCode}</p>
  <a href="/propertyManagers/details/{data.id}/postal-code">
    <button
      class="flex font-semibold border-2 border-[#0078c8] hover:bg-blue-400 mt-4 p-4 mx-auto rounded-md"
      >Edytuj kod pocztowy</button
    >
  </a>
</div>
