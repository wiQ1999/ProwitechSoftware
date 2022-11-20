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
    console.log(propertyManagers);
    formVisibility = true;

    // getAllPropertyManagers
  });
</script>

{#if formVisibility}
  <form on:submit|preventDefault={async () => await onSubmit()}>
    <div>
      <label for="building-address-city-name">Miejscowość</label>
      <select bind:value={buildingAddressDTO.cityName}>
        {#each cities as city}
          <option value={city.id}>{city.name}</option>
        {/each}
      </select>
    </div>
    <div>
      <label for="property-manager-name">Nazwa ulicy</label>
      <input type="text" bind:value={buildingAddressDTO.streetName} />
      <label for="building-address-building-number">Numer budynku</label>
      <input type="text" bind:value={buildingAddressDTO.buildingNumber} />
    </div>
    <div>
      <select bind:value={buildingType}>
        {#each buildingTypes as btype}
          <option value={btype}>{btype}</option>
        {/each}
      </select>
    </div>
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
    <button type="submit">Submit</button>
  </form>
{/if}

<style>
  * {
    box-sizing: border-box;
  }
  form {
    display: flex;
    width: 300px;
  }
</style>
