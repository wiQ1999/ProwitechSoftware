<script>
  import {
    postBuildingAddress,
    deleteBuildingAddress,
  } from "../../../stores/BuildingAddress.js";
  import {
    postPropertyManager,
    getPropertyManagerById,
  } from "../../../stores/PropertyManager";
  import { prepareCoordinatesNotFoundMessage } from "../../../js-lib/helpers";
  import BuildingAddressPopUp from "../../../components/AddBuildingAddressPopUp.svelte";
  import ShowPropertyManagerPopUp from "../../../components/ShowPropertyManagerPopUp.svelte";
  import { onMount } from "svelte";
  import PropertyManagerForm from "../../../components/PropertyManagerForm.svelte";

  let buildingAddressDTO;
  let propertyManagerDTO;
  let buildingAddressPostResult = "";
  let corrdinates_not_found_message;
  let buildingAddressConfirmPopUpVisibility;
  let formVisibility;
  let addedPropertyManagerPopUpVisibility;
  let addedBuildingAddress;
  let FullAddressDTO;
  let PropertyManagerDTOToShow;
  let buildingAddressId = "";
  let showPropertyManagerPopUpMessage =
    "Dodano do bazy danych Zarządcę Nieruchomości o poniższych danych:";
  onMount(() => {
    buildingAddressConfirmPopUpVisibility = false;
    formVisibility = true;
  });

  async function onSubmit() {
    let optionalArguments = {
      force: false,
      onlyAddress: false,
    };

    buildingAddressPostResult = await postBuildingAddress(
      buildingAddressDTO,
      optionalArguments
    );

    if (buildingAddressPostResult instanceof Error) {
      // window.location.reload();
    } else if (buildingAddressPostResult instanceof Response) {
      let buildingAddressJSON = await buildingAddressPostResult.json();
      if (buildingAddressJSON.webApiStatus == "ADDED_TO_DB") {
        buildingAddressId = buildingAddressJSON.addedBuildingAddress.id;
        await createPropertyManager();
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

  async function createPropertyManager() {
    buildingAddressConfirmPopUpVisibility = false;

    let PropertyManagerCommand = {
      name: propertyManagerDTO.name,
      phoneNumber: propertyManagerDTO.phoneNumber,
      fullAddressDTO: {
        buildingAddressId: buildingAddressId,
        localNumber: propertyManagerDTO.fullAddress.localNumber,
        staircaseNumber: propertyManagerDTO.fullAddress.staircaseNumber,
      },
    };

    let postPropertyManagerId = await postPropertyManager(
      PropertyManagerCommand
    );

    if (postPropertyManagerId instanceof Error) {
      //delete building address of property manager (bo nie udało się go dodać, więc nie przechowujmy tego)
      await deleteBuildingAddress(buildingAddressId);
      formVisibility = true;
      // window.location.reload();
    } else if (postPropertyManagerId instanceof Response) {
      let postPropertyManagerIdJSON = await postPropertyManagerId.json();
      let getPropertyManagerByIdResult = await getPropertyManagerById(
        postPropertyManagerIdJSON
      );
      if (getPropertyManagerByIdResult instanceof Response) {
        PropertyManagerDTOToShow = await getPropertyManagerByIdResult.json();
      } else {
        PropertyManagerDTOToShow = null;
      }
      formVisibility = false;
      buildingAddressConfirmPopUpVisibility = false;
      addedPropertyManagerPopUpVisibility = true;
    }
  }
</script>

<div class="add-property-manager-form">
  {#if buildingAddressConfirmPopUpVisibility}
    <BuildingAddressPopUp
      {addedBuildingAddress}
      {corrdinates_not_found_message}
      functionToInvokeAfterAdding={async () => await createPropertyManager()}
      bind:buildingAddressId
    />
  {/if}
  {#if formVisibility}
    <PropertyManagerForm
      bind:buildingAddressDTO
      bind:propertyManagerDTO
      {onSubmit}
    />
  {/if}
  {#if addedPropertyManagerPopUpVisibility}
    <ShowPropertyManagerPopUp
      PropertyManagerDTO={PropertyManagerDTOToShow}
      message={showPropertyManagerPopUpMessage}
    />
  {/if}
</div>
