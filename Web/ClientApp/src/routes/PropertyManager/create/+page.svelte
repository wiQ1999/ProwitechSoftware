<script>
  import { HttpMethodError } from "../../../js-lib/errors.js";
  import {
    addBuildingAddressDTO,
    postBuildingAddress,
  } from "../../../stores/BuildingAddress.js";
  import { CreatePropertyManagerCommand } from "../../../stores/PropertyManager";
  import BuildingAddressPopUp from "../../../components/BuildingAddressPopUp.svelte";
  import { onMount } from "svelte";

  let buildingAddressPostResult = "";
  let corrdinates_not_found_message;
  let posted;
  let addedBuildingAddress;
  onMount(() => {
    posted = false;
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
    if (buildingAddressPostResult instanceof HttpMethodError) {
      console.log("/<3");
      console.log(buildingAddressPostResult);
    } else if (buildingAddressPostResult instanceof Error) {
      console.log("buildingAddressPostResult instanceof Error");
    } else {
      if (buildingAddressPostResult.webApiStatus == "ADDED_TO_DB") {
      } else {
        displayPopUp();
      }
    }
  }

  function displayPopUp() {
    addedBuildingAddress = buildingAddressPostResult.addedBuildingAddress;
    console.log(buildingAddressPostResult);

    let cityName = addedBuildingAddress.cityName;
    let streetName = addedBuildingAddress.streetName;
    let buildingNumber = addedBuildingAddress.buildingNumber;

    corrdinates_not_found_message = `Nie znaleziono dokładnych współrzędnych dla adresu ${streetName} ${buildingNumber}, ${cityName}
  \nOdnaleziono współrzędne dla adresu: ${buildingAddressPostResult.googleAPIFormattedAddress}.
  \nCzy chce je zachować?`;
    posted = true;
  }
</script>

<div class="add-property-manager-form">
  {#if posted}
    <BuildingAddressPopUp
      {addedBuildingAddress}
      {corrdinates_not_found_message}
    />
  {/if}
  {#if !posted}
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
