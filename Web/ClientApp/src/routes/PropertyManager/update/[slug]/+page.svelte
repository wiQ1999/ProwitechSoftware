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

  import { tryToUpdateBuildingAddress } from "../../../../stores/BuildingAddress";
  import { checkIfUpdatedBuildingAddressAndOriginalBuildingAddressDiffer } from "../../../../stores/BuildingAddress";
  import ShowPropertyManagerPopUp from "../../../../components/ShowPropertyManagerPopUp.svelte";
  import { onMount } from "svelte";
  import {
    getPropertyManagerById,
    checkIfPropManagersDiffer,
    putPropertyManager,
  } from "../../../../stores/PropertyManager";
  import PropertyManagerForm from "../../../../components/PropertyManagerForm.svelte";
  import EditBuildingAddressPopUp from "../../../../components/EditBuildingAddressPopUp.svelte";
  import { AddUpdateBuildingAddressRequestResult } from "../../../../js-lib/helpers";

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

  let buildingAddressChanged;
  let otherPropManagerDataChanged;

  let buildingAddressesDontDiffer;
  let buildingAddressUpdateError;

  let PropertyManagerDTO;
  let AddUpdateBuildingAddressReponse;

  onMount(async () => {
    updatedPropertyManagerPopUpVisibility = false;
    editBuildingAddressPopUpVisibility = false;
    await prepareForm(data.id);
  });

  async function prepareForm(propertyManagerId) {
    let propertyManagerResponse = await getPropertyManagerById(
      propertyManagerId
    );
    if (propertyManagerResponse instanceof Response) {
      originalPropertyManagerDTO = await propertyManagerResponse.json();
      updatePropertyManagerDTO = structuredClone(originalPropertyManagerDTO);
      originalBuildingAddressDTO =
        originalPropertyManagerDTO.fullAddress.buildingAddress;
      updateBuildingAddressDTO = structuredClone(originalBuildingAddressDTO);

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
      //pokaż okno potwierdzające
      corrdinates_not_found_message = prepareMessage(
        newBuildingAddressDTO,
        addressUpdatedAtOnce
      );
      AddUpdateBuildingAddressReponse = addressUpdatedAtOnce;
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
      else otherPropManagerDataChanged = false;
    }
    displayPropertyManagerAfterUpdate(
      oldPropertyManagerDTO.id,
      buildingAddressChanged,
      otherPropManagerDataChanged
    );
  }
  async function updatePropertyManager(newPropertyManagerDTO) {
    let propertyManagerPutBody = {
      id: newPropertyManagerDTO.id,
      name: newPropertyManagerDTO.name,
      phoneNumber: newPropertyManagerDTO.phoneNumber,
      updateFullAddressDTO: {
        buildingAddressId: newPropertyManagerDTO.fullAddress.buildingAddressId,
        localNumber: newPropertyManagerDTO.fullAddress.localNumber,
        staircaseNumber: newPropertyManagerDTO.fullAddress.staircaseNumber,
      },
    };
    let propManGotUpdated = await putPropertyManager(
      propertyManagerPutBody.id,
      propertyManagerPutBody
    );
    if (propManGotUpdated instanceof Response) {
      return true;
    }
    return false;
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

<div class="add-property-manager-form">
  {#if editBuildingAddressPopUpVisibility}
    <EditBuildingAddressPopUp
      updateBuildingAddressDTO={AddUpdateBuildingAddressReponse.addedBuildingAddress}
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
      bind:PropertyManagerCommand={updatePropertyManagerDTO}
      onSubmit={async () =>
        await updatePropertyManagerAllData(
          updateBuildingAddressDTO,
          originalBuildingAddressDTO
        )}
    />
  {/if}
  {#if updatedPropertyManagerPopUpVisibility}
    <ShowPropertyManagerPopUp
      {PropertyManagerDTO}
      message={showPropertyManagerPopUpMessage}
    />
  {/if}
</div>
