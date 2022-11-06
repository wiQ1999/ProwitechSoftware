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

  import { putBuildingAddress } from "../../../../stores/BuildingAddress";
  import { checkIfUpdatedBuildingAddressAndOriginalBuildingAddressDiffer } from "../../../../stores/BuildingAddress";
  import BuildingAddressPopUp from "../../../../components/AddBuildingAddressPopUp.svelte";
  import ShowPropertyManagerPopUp from "../../../../components/ShowPropertyManagerPopUp.svelte";
  import { onMount } from "svelte";
  import { getPropertyManagerById } from "../../../../stores/PropertyManager";
  import PropertyManagerForm from "../../../../components/PropertyManagerForm.svelte";
  import EditBuildingAddressPopUp from "../../../../components/EditBuildingAddressPopUp.svelte";
  import { AddUpdateBuildingAddressRequestResult } from "../../../../js-lib/helpers";

  let updateBuildingAddressDTO;
  let originalBuildingAddressDTO;
  let originalPropertyManagerDTO;
  let updatePropertyManagerDTO;

  let editBuildingAddressPopUpVisibility;

  let AddUpdateBuildingAddressReponse;

  let corrdinates_not_found_message;
  let formVisibility;
  let errorDivVisibility;
  let updatedPropertyManagerPopUpVisibility;
  let buildingAddressId;
  // let FullAddressDTO;
  // let buildingAddressId = "";
  // let showPropertyManagerPopUpMessage =
  //   "Dodano do bazy danych Zarządcę Nieruchomości o poniższych danych:";

  onMount(async () => {
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
    await updatePropertyManagerDataWithoutBuildingAddress();
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
    if (!newAndOldAddressDiffer) return;
    let addressUpdatedAtOnce = await tryToUpdateBuildingAddress(
      newBuildingAddressDTO
    );
    if (addressUpdatedAtOnce == AddUpdateBuildingAddressRequestResult.success) {
      return;
      // await updatePropertyManagerDataWithoutBuildingAddress();
    } else if (
      addressUpdatedAtOnce == AddUpdateBuildingAddressRequestResult.error
    ) {
      // window.location.reload();
    } else {
      corrdinates_not_found_message = prepareMessage(
        newBuildingAddressDTO,
        addressUpdatedAtOnce
      );
      AddUpdateBuildingAddressReponse = addressUpdatedAtOnce;
      console.log(addressUpdatedAtOnce);
      formVisibility = false;
      editBuildingAddressPopUpVisibility = true;
    }
  }

  async function tryToUpdateBuildingAddress(updateBuildingAddressDTO) {
    updateBuildingAddressDTO.longitude = null;
    updateBuildingAddressDTO.latitude = null;

    let updateBuildingAddressResult = await putBuildingAddress(
      updateBuildingAddressDTO.id,
      updateBuildingAddressDTO
    );
    if (updateBuildingAddressResult instanceof Response) {
      let updateBuildingAddressJSON = await updateBuildingAddressResult.json();
      if (updateBuildingAddressJSON.webApiStatus == "ADDED_TO_DB") {
        return AddUpdateBuildingAddressRequestResult.success;
      } else {
        return updateBuildingAddressJSON;
      }
    } else {
      return AddUpdateBuildingAddressRequestResult.error;
    }
  }
  async function updatePropertyManagerDataWithoutBuildingAddress(
    updatePropertyManagerDTO
  ) {
    console.log("updatePropertyManagerDataWithoutBuildingAddress");
  }
  // async function displayEditBuildingAddressPopUp(
  //   updateBuildingAddressTriedToBePut,
  //   AddUpdateBuildingAddressReponse
  // ) {
  //   corrdinates_not_found_message = prepareMessage(
  //     updateBuildingAddressTriedToBePut,
  //     AddUpdateBuildingAddressReponse
  //   );
  //   editBuildingAddressPopUpVisibility = true;
  // }

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

  //   function displayBuildingAddressConfirmPopUp(
  //     addedBuildingAddress,
  //     buildingAddressJSON
  //   ) {
  //     let cityName = addedBuildingAddress.cityName;
  //     let streetName = addedBuildingAddress.streetName;
  //     let buildingNumber = addedBuildingAddress.buildingNumber;

  //     corrdinates_not_found_message = `Nie znaleziono dokładnych współrzędnych dla adresu ${streetName} ${buildingNumber}, ${cityName}
  //   \nOdnaleziono współrzędne dla adresu: ${buildingAddressJSON.googleAPIFormattedAddress}.
  //   \nCzy chce je zachować?`;
  //     buildingAddressConfirmPopUpVisibility = true;
  //     formVisibility = false;
  //   }

  //   async function createPropertyManager() {
  //     buildingAddressConfirmPopUpVisibility = false;

  //     FullAddressDTO = {
  //       buildingAddressId: buildingAddressId,
  //       localNumber: CreatePropertyManagerCommand.localNumber,
  //       staircaseNumber: CreatePropertyManagerCommand.staircaseNumber,
  //     };

  //     CreatePropertyManagerCommand.fullAddressDTO = FullAddressDTO;
  //     let postPropertyManagerId = await postPropertyManager(
  //       CreatePropertyManagerCommand
  //     );

  //     if (postPropertyManagerId instanceof Error) {
  //       //delete building address of property manager (bo nie udało się go dodać, więc nie przechowujmy tego)
  //       await deleteBuildingAddress(buildingAddressId);
  //       window.location.reload();
  //     } else if (postPropertyManagerId instanceof Response) {
  //       let postPropertyManagerIdJSON = await postPropertyManagerId.json();
  //       let getPropertyManagerByIdResult = await showPropertyManager(
  //         postPropertyManagerIdJSON
  //       );
  //       if (getPropertyManagerByIdResult instanceof Response) {
  //         PropertyManagerDTO = await getPropertyManagerByIdResult.json();
  //       } else {
  //         PropertyManagerDTO = null;
  //       }
  //       formVisibility = false;
  //       buildingAddressConfirmPopUpVisibility = false;
  //       addedPropertyManagerPopUpVisibility = true;
  //     }
  //   }
</script>

<div class="add-property-manager-form">
  {#if editBuildingAddressPopUpVisibility}
    <EditBuildingAddressPopUp
      updateBuildingAddressDTO={AddUpdateBuildingAddressReponse.addedBuildingAddress}
      {corrdinates_not_found_message}
      continueEdition={async () =>
        await updatePropertyManagerDataWithoutBuildingAddress(
          updatePropertyManagerDTO
        )}
      bind:buildingAddressId
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
