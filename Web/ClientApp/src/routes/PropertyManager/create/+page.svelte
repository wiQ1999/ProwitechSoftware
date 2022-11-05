<script>
  import { HttpMethodError } from "../../../js-lib/errors.js";
  import {
    addBuildingAddressDTO,
    postBuildingAddress,
    deleteBuildingAddress,
  } from "../../../stores/BuildingAddress.js";
  import {
    CreatePropertyManagerCommand,
    postPropertyManager,
    showPropertyManager,
  } from "../../../stores/PropertyManager";
  import BuildingAddressPopUp from "../../../components/BuildingAddressPopUp.svelte";
  import PropertyManagerAddedPopUp from "../../../components/PropertyManagerAddedPopUp.svelte";
  import { onMount } from "svelte";
  import { genericGetById } from "../../../js-lib/httpMethods.js";

  let buildingAddressPostResult = "";
  let corrdinates_not_found_message;
  let buildingAddressConfirmPopUpVisibility;
  let formVisibility;
  let addedPropertyManagerPopUpVisibility;
  let addedBuildingAddress;
  let FullAddressDTO;
  let PropertyManagerDTO;
  let buildingAddressId = "";
  onMount(() => {
    buildingAddressConfirmPopUpVisibility = false;
    formVisibility = true;
  });

  let cities = [
    { id: "Bydgoszcz", name: "Bydgoszcz" },
    { id: "Poznań", name: "Poznań" },
    { id: "Wrocław", name: "Wrocław" },
  ];

  async function onSubmit() {
    let optionalArguments = {
      force: false,
      onlyAddress: false,
    };

    buildingAddressPostResult = await postBuildingAddress(
      $addBuildingAddressDTO,
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
        displayBuildingAddressConfirmPopUp(buildingAddressJSON);
      }
    }
  }

  function displayBuildingAddressConfirmPopUp(buildingAddressJSON) {
    addedBuildingAddress = buildingAddressJSON.addedBuildingAddress;

    let cityName = addedBuildingAddress.cityName;
    let streetName = addedBuildingAddress.streetName;
    let buildingNumber = addedBuildingAddress.buildingNumber;

    corrdinates_not_found_message = `Nie znaleziono dokładnych współrzędnych dla adresu ${streetName} ${buildingNumber}, ${cityName}
  \nOdnaleziono współrzędne dla adresu: ${buildingAddressJSON.googleAPIFormattedAddress}.
  \nCzy chce je zachować?`;
    buildingAddressConfirmPopUpVisibility = true;
    formVisibility = false;
  }

  async function createPropertyManager() {
    buildingAddressConfirmPopUpVisibility = false;

    FullAddressDTO = {
      buildingAddressId: buildingAddressId,
      localNumber: $CreatePropertyManagerCommand.localNumber,
      staircaseNumber: $CreatePropertyManagerCommand.staircaseNumber,
    };

    $CreatePropertyManagerCommand.fullAddressDTO = FullAddressDTO;
    let postPropertyManagerId = await postPropertyManager(
      $CreatePropertyManagerCommand
    );

    if (postPropertyManagerId instanceof Error) {
      //delete building address of property manager (bo nie udało się go dodać, więc nie przechowujmy tego)
      await deleteBuildingAddress(buildingAddressId);
      formVisibility = true;
      // window.location.reload();
    } else if (postPropertyManagerId instanceof Response) {
      let postPropertyManagerIdJSON = await postPropertyManagerId.json();
      let getPropertyManagerByIdResult = await showPropertyManager(
        postPropertyManagerIdJSON
      );
      if (getPropertyManagerByIdResult instanceof Response) {
        PropertyManagerDTO = await getPropertyManagerByIdResult.json();
      } else {
        PropertyManagerDTO = null;
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
      createPropertyManager={async () => await createPropertyManager()}
      bind:buildingAddressId
    />
  {/if}
  {#if formVisibility}
    <form on:submit|preventDefault={onSubmit}>
      <div>
        <label for={$addBuildingAddressDTO.cityName}>Miejscowość</label>
        <select bind:value={$addBuildingAddressDTO.cityName}>
          {#each cities as city}
            <option value={city.id}>{city.name}</option>
          {/each}
        </select>
      </div>
      <div>
        <label for={$CreatePropertyManagerCommand.name}
          >Nazwa Zarządcy Nieruchomości</label
        >
        <input type="text" bind:value={$CreatePropertyManagerCommand.name} />
        <label for={$CreatePropertyManagerCommand.phoneNumber}
          >Numer telefonu</label
        >
        <input
          type="text"
          bind:value={$CreatePropertyManagerCommand.phoneNumber}
        />
        <label for={$addBuildingAddressDTO.streetName}>Nazwa ulicy</label>
        <input type="text" bind:value={$addBuildingAddressDTO.streetName} />
        <label for={$addBuildingAddressDTO.buildingNumber}>Numer budynku</label>
        <input type="text" bind:value={$addBuildingAddressDTO.buildingNumber} />
        <label for={$CreatePropertyManagerCommand.localNumber}
          >Numer lokalu (opcjonalnie)</label
        >
        <input
          type="text"
          bind:value={$CreatePropertyManagerCommand.localNumber}
        />
        <label for={$CreatePropertyManagerCommand.staircaseNumber}
          >Numer klatki schodowej (opcjonalnie)</label
        >
        <input
          type="text"
          bind:value={$CreatePropertyManagerCommand.staircaseNumber}
        />
      </div>
      <button type="submit">Submit</button>
    </form>
  {/if}
  {#if addedPropertyManagerPopUpVisibility}
    <PropertyManagerAddedPopUp {PropertyManagerDTO} />
  {/if}
</div>

<style>
  * {
    box-sizing: border-box;
  }
  form {
    display: flex;
    width: 300px;
  }
</style>
