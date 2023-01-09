<script>
  import {
    postBuildingAddress,
    deleteBuildingAddress,
    getBuildingAddressIdIfAlredyExists,
  } from "$lib/stores/BuildingAddress.js";
  import {
    postPropertyManager,
    getPropertyManagerById,
  } from "$lib/stores/PropertyManager";
  import { prepareCoordinatesNotFoundMessage } from "$lib/js-lib/helpers";
  import BuildingAddressPopUp from "$lib/components/AddBuildingAddressPopUp.svelte";
  import ShowPropertyManagerPopUp from "$lib/components/ShowPropertyManagerPopUp.svelte";
  import { onMount } from "svelte";
  import PropertyManagerForm from "$lib/components/PropertyManagerForm.svelte";
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

  function preparePropertyManagerCommand() {
    console.log(propertyManagerDTO);
    let PropertyManagerCommand;

    if (
      propertyManagerDTO.fullAddress.propertyAddress.venueNumber != "" ||
      propertyManagerDTO.fullAddress.propertyAddress.staircaseNumber != ""
    ) {
      PropertyManagerCommand = {
        name: propertyManagerDTO.name,
        phoneNumber: propertyManagerDTO.phoneNumber,
        fullAddressDTO: {
          buildingAddressId: buildingAddressId,
          propertyAddressDTO: {
            venueNumber:
              propertyManagerDTO.fullAddress.propertyAddress.venueNumber,
            staircaseNumber:
              propertyManagerDTO.fullAddress.propertyAddress.staircaseNumber,
          },
        },
      };
    } else {
      PropertyManagerCommand = {
        name: propertyManagerDTO.name,
        phoneNumber: propertyManagerDTO.phoneNumber,
        fullAddressDTO: {
          buildingAddressId: buildingAddressId,
        },
      };
    }
    return PropertyManagerCommand;
  }

  async function createPropertyManager() {
    buildingAddressConfirmPopUpVisibility = false;
    let PropertyManagerCommand = preparePropertyManagerCommand();
    console.log(PropertyManagerCommand);
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

<a href="/propertyManagers/getAll">
  <button class="bg-red-500 uppercase decoration-none text-black text-base py-[1%] mx-auto rounded-md flex w-[60%] justify-center cursor-pointer">Powrót</button>
</a>
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
