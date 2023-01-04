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
  export let editMode = false;
  let readMode = false;

  let formVisibility;
  let propertyManagers = [];

  let cities = [
    { id: "Bydgoszcz", name: "Bydgoszcz" },
    { id: "Poznań", name: "Poznań" },
    { id: "Wrocław", name: "Wrocław" },
  ];
  let buildingTypes = ["jednorodzinny", "wielolokalowy", "lokal usługowy"];

  onMount(async () => {
    readMode = editMode;
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
        cityName: null,
        streetName: null,
        buildingNumber: null,
        postalCode: null,
        localNumber: null,
        staircaseNumber: null,
      },
    });
    console.log(propertyManagers);
    formVisibility = true;

    // getAllPropertyManagers
  });
  function changeEditingStatus() {
    readMode = !readMode;
    editMode = false;
  }
</script>

{#if formVisibility}
  {#if editMode}
    <button on:click={() => changeEditingStatus()}>Włącz edytowanie</button>
  {/if}
  <form on:submit|preventDefault={async () => await onSubmit()}>
    <div>
      <label for="building-address-city-name">Miejscowość</label>
      <select bind:value={buildingAddressDTO.cityName} disabled={readMode}>
        {#each cities as city}
          <option value={city.id}>{city.name}</option>
        {/each}
      </select>
    </div>
    <div>
      <label for="property-manager-name">Nazwa ulicy</label>
      <input
        type="text"
        bind:value={buildingAddressDTO.streetName}
        disabled={readMode}
      />
      <label for="building-address-building-number">Numer budynku</label>
      <input
        type="text"
        bind:value={buildingAddressDTO.buildingNumber}
        disabled={readMode}
      />
    </div>
    <div>
      <select bind:value={buildingType} disabled={readMode}>
        {#each buildingTypes as btype}
          <option value={btype}>{btype}</option>
        {/each}
      </select>
    </div>
    <select bind:value={propertyManagerId} disabled={readMode}>
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
    <button type="submit" disabled={readMode}>Submit</button>
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
