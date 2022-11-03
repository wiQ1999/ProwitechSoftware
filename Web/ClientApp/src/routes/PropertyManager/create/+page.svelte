<script>
  import { HttpMethodError } from "../../../js-lib/errors.js";
  import {
    addBuildingAddressDTO,
    postBuildingAddress,
  } from "../../../stores/BuildingAddress.js";
  import {
    CreatePropertyManagerCommand,
    postPropertyManager,
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
    console.log(JSON.stringify($addBuildingAddressDTO));
    console.log(JSON.stringify($CreatePropertyManagerCommand));
    console.log("--------------------------------------");

    let optionalArguments = {
      force: false,
      onlyAddress: false,
    };

    buildingAddressPostResult = await postBuildingAddress(
      $addBuildingAddressDTO,
      optionalArguments
    );
    if (buildingAddressPostResult instanceof Response) {
      let buildingAddressJSON = await buildingAddressPostResult.json();
      if (buildingAddressJSON.webApiStatus == "ADDED_TO_DB") {
        console.log("DODANO");
        console.log(buildingAddressJSON);
        buildingAddressId = buildingAddressJSON.addedBuildingAddress.id;
        createPropertyManager();
        //kontynuuj --> czyli wyślij dane do utworzenia FullAddress i PropertyManagera
      } else {
        displayBuildingAddressConfirmPopUp(buildingAddressJSON);
      }
    } else {
      if (buildingAddressPostResult instanceof HttpMethodError) {
        alert(
          `Błąd HTTP przy wysyłaniu danych!\nInformacje o błędzie:\n${buildingAddressPostResult.message}`
        );
      } else if (buildingAddressPostResult instanceof Error) {
        alert(
          `Wystąpił inny błąd: ${buildingAddressPostResult.message}\n${buildingAddressPostResult.stack}`
        );
      }
    }
  }

  function displayBuildingAddressConfirmPopUp(buildingAddressJSON) {
    console.log(buildingAddressJSON);
    addedBuildingAddress = buildingAddressJSON.addedBuildingAddress;
    console.log(addedBuildingAddress);

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
    formVisibility = true;
    console.log("uruchomiona funkcja");
    // console.log(buildingAddressId);
    // console.log($CreatePropertyManagerCommand);
    FullAddressDTO = {
      buildingAddressId: buildingAddressId,
      localNumber: $CreatePropertyManagerCommand.localNumber,
      staircaseNumber: $CreatePropertyManagerCommand.staircaseNumber,
    };
    $CreatePropertyManagerCommand.fullAddressDTO = FullAddressDTO;
    console.log($CreatePropertyManagerCommand);
    let postPropertyManagerResult = await postPropertyManager(
      $CreatePropertyManagerCommand
    );
    console.log(postPropertyManagerResult);
    // console.log(postPropertyManagerResultJSON);
    if (postPropertyManagerResult instanceof Response) {
      let postPropertyManagerResultJSON =
        await postPropertyManagerResult.json();
      // console.log(postPropertyManagerResultJSON);
      PropertyManagerDTO = await genericGetById(
        "/PropertyManager",
        postPropertyManagerResultJSON
      );
      console.log(PropertyManagerDTO);
      formVisibility = false;
      buildingAddressConfirmPopUpVisibility = false;
      addedPropertyManagerPopUpVisibility = true;
    } else {
      if (postPropertyManagerResult instanceof HttpMethodError) {
        alert(
          `Błąd HTTP przy wysyłaniu danych!\nInformacje o błędzie:\n${buildingAddressPostResult.message}`
        );
      } else if (postPropertyManagerResult instanceof Error) {
        alert(
          `Wystąpił inny błąd: ${buildingAddressPostResult.message}\n${buildingAddressPostResult.stack}`
        );
      }
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
  /* select,
  input {
    background-color: bisque;
  }
  label {
    color: #decff1;
  } */
  * {
    box-sizing: border-box;
  }
  form {
    display: flex;
    /* flex-direction: column; */
    width: 300px;
  }
</style>
