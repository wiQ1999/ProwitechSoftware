<script>
  import { onMount } from "svelte";
  import { getAllPropertyManagers } from "$lib/stores/PropertyManager";

  export let buildingAddressDTO = {
    cityName: "",
    streetName: "",
    buildingNumber: "",
  };
  export let propertyManagerId;
  export let buildingType;
  export let onSubmit = async () => {};

  let formVisibility;
  let propertyManagers = [];

  let cities = [
    { id: "Bydgoszcz", name: "Bydgoszcz" },
    { id: "Poznań", name: "Poznań" },
    { id: "Wrocław", name: "Wrocław" },
  ];
  let buildingTypes = ["jednorodzinny", "wielolokalowy", "lokal usługowy"];

  onMount(async () => {
    let propertyManagersResult = await getAllPropertyManagers();
    if (propertyManagersResult instanceof Error) {
      // displayAll = false;
      // displayGetAllProblem = true;
      return;
    }

    let propertyManagersResultJSON = await propertyManagersResult.json();
    console.log(propertyManagersResultJSON);

    for (let element of propertyManagersResultJSON) {
      propertyManagers.push({
        id: element.id,
        name: element.name,
        fullAddressInShort: {
          cityName: element.fullAddress.buildingAddress.cityName,
          streetName: element.fullAddress.buildingAddress.streetName,
          buildingNumber: element.fullAddress.buildingAddress.buildingNumber,
          postalCode: element.fullAddress.buildingAddress.postalCode,
          localNumber: element.fullAddress.localNumber,
          staircaseNumber: element.fullAddress.staircaseNumber,
        },
      });
    }
    propertyManagers.push({
      id: null,
      name: "Brak zarządcy",
      fullAddressInShort: {
        cityName: "",
        streetName: "",
        buildingNumber: "",
        postalCode: "",
        localNumber: "",
        staircaseNumber: "",
      },
    });
    console.log(propertyManagers);
    formVisibility = true;

    // getAllPropertyManagers
  });
</script>

{#if formVisibility}
  <form on:submit|preventDefault={async () => await onSubmit()}>
    <fieldset>
      <legend> <h1> Dodaj budynek </h1> </legend>
      <label for="building-address-city-name">Miejscowość</label>
      <select bind:value={buildingAddressDTO.cityName}>
        {#each cities as city}
          <option value={city.id}>{city.name}</option>
        {/each}
      </select>

      <label for="property-manager-name">Nazwa ulicy</label>
      <input type="text" bind:value={buildingAddressDTO.streetName} />
      <label for="building-address-building-number">Numer budynku</label>
      <input type="text" bind:value={buildingAddressDTO.buildingNumber} />

      <label for="building-type">Typ domu</label>
      <select bind:value={buildingType}>
        {#each buildingTypes as btype}
          <option value={btype}>{btype}</option>
        {/each}
      </select>
      <label for="property-manager-info">Zarządca nieruchomości</label>
    <select bind:value={propertyManagerId}>
      {#each propertyManagers as propman}
        <option value={propman.id}
          >{propman.name} |
          {propman.fullAddressInShort.streetName} |
          {propman.fullAddressInShort.buildingNumber} |
          {propman.fullAddressInShort.staircaseNumber} |
          {propman.fullAddressInShort.localNumber} |
          {propman.fullAddressInShort.postalCode}
          {propman.fullAddressInShort.cityName}</option
        >
      {/each}
    </select>
  </fieldset>
    <button type="submit">Submit</button>
  </form>
{/if}

<style>
  * {
    box-sizing: border-box;
  }
  form {
  max-width: 50%;
  margin: 10px auto;
  padding: 10px 20px;
  background: #f4f7f8;
  border-radius: 8px;
  text-align: center;
  }

  input,select {
  background: rgba(255,255,255,0.1);
  border: none;
  font-size: 16px;
  height: auto;
  margin: 0;
  outline: 0;
  padding: 15px;
  width: 100%;
  background-color: #e8eeef;
  color: #8a97a9;
  box-shadow: 0 1px 0 rgba(0,0,0,0.03) inset;
  margin-bottom: 30px;
  }

  label {
    display: block;
  }

  fieldset {
    border: none;
    text-align: center;
  }

  button {
    padding: 19px 39px 18px 39px;
    background-color: #0078c8;
    font-size: 18px;
    text-align: center;
    font-style: normal;
    border-radius: 5px;
    width: 100%;
    box-shadow: 0 -1px 0 rgba(255,255,255,0.1) inset;
    margin-bottom: 10px;
    justify-content: center;
    cursor: pointer;
  }
</style>
