<script>
  import { onMount } from "svelte";
  import { getAllPropertyManagers } from "$lib/stores/PropertyManager";
  import Map from "$lib/components/Map.svelte";

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
  let upper_message = "Dodaj budynek";
  export let building = null;

  let formVisibility;
  let propertyManagers = [];
  let button_turn_on_edition_message = "Włącz edycję";
  let submitButtonMessage = "DODAJ";

  let cities = [
    { id: "Bydgoszcz", name: "Bydgoszcz" },
    { id: "Poznań", name: "Poznań" },
    { id: "Wrocław", name: "Wrocław" },
  ];
  let buildingTypes = [
    { id: "WIELOLOKALOWY", name: "wielolokalowy" },
    { id: "JEDNOLOKALOWY", name: "jednolokalowy" },
  ];

  onMount(async () => {
    readMode = editMode;
    let propertyManagersResult = await getAllPropertyManagers();
    if (propertyManagersResult instanceof Error) {
      // displayAll = false;
      // displayGetAllProblem = true;
      return;
    }
    if (editMode) {
      submitButtonMessage = "ZATWIERDŹ";
      upper_message = "Szczegóły budynku";
    }

    let propertyManagersResultJSON = await propertyManagersResult.json();
    console.log(propertyManagersResultJSON);

    for (let element of propertyManagersResultJSON) {
      propertyManagers.push({
        id: element.id,
        name: element.name,
        fullAddressInShort: {
          cityName: element.fullAddress?.buildingAddress.cityName,
          streetName: element.fullAddress?.buildingAddress.streetName,
          buildingNumber: element.fullAddress?.buildingAddress.buildingNumber,
          postalCode: element.fullAddress?.buildingAddress.postalCode,
          venueNumber: element.fullAddress?.propertyAddress?.venueNumber,
          staircaseNumber:
            element.fullAddress?.propertyAddress?.staircaseNumber,
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
        venueNumber: null,
        staircaseNumber: null,
      },
    });
    formVisibility = true;

    // getAllPropertyManagers
  });
  function changeEditingStatus() {
    readMode = !readMode;
    if (button_turn_on_edition_message == "Włącz edycję") {
      button_turn_on_edition_message = "Zakończ edycję";
    } else {
      button_turn_on_edition_message = "Włącz edycję";
    }
    if (readMode) upper_message = "Szczegóły budynku";
    else upper_message = "Edycja budynku";
    // editMode = false;
  }
</script>

{#if formVisibility}
  
  <form
    on:submit|preventDefault={async () => await onSubmit()}
    class="w-[50%] my-3 mx-auto py-3 px-5 bg-[#f4f7f8] rounded-lg text-center"
  >
    <fieldset class="border-none">
      <legend class="font-bold text-lg py-5"> {upper_message} </legend>
      {#if editMode}
    <button
      on:click|preventDefault={() => changeEditingStatus()}
      class="flex font-semibold bg-blue-400 mb-4 p-4 mx-auto rounded-md text-white"
      >{button_turn_on_edition_message}</button
    >
  {/if}
      <label for="building-address-city-name" class="block">Miejscowość</label>
      <select bind:value={buildingAddressDTO.cityName} disabled={readMode} required class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]">
        {#each cities as city}
          <option value={city.id}>{city.name}</option>
        {/each}
      </select>

      <label for="property-manager-name" class="block">Nazwa ulicy</label>
      <input
        type="text"
        bind:value={buildingAddressDTO.streetName}
        disabled={readMode}
        required class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]"
      />
      <label for="building-address-building-number" class="block"
        >Numer budynku</label
      >
      <input
        type="text"
        bind:value={buildingAddressDTO.buildingNumber}
        disabled={readMode}
        required class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]"
      />
      <label for="building-type">Typ budynku</label>

      <select bind:value={buildingType} disabled={readMode} required class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]">
        {#each buildingTypes as btype}
          <option value={btype.id}>{btype.name}</option>
        {/each}
      </select>

    <label for="building-property-manager" class="block">Zarządca Nieruchomości</label>
    <select bind:value={propertyManagerId} disabled={readMode} required class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]">

      {#each propertyManagers as propman}
        <option value={propman.id}
          >{propman.name}
          {#if propman.fullAddressInShort.streetName}
          | {propman.fullAddressInShort.streetName}
          {/if}
          {#if propman.fullAddressInShort.buildingNumber}
          {propman.fullAddressInShort.buildingNumber}
          {/if}
          {#if propman.fullAddressInShort.staircaseNumber}
          kl. {propman.fullAddressInShort.staircaseNumber}
          {/if}
          {#if propman.fullAddressInShort.venueNumber}
          m. {propman.fullAddressInShort.venueNumber}
          {/if}
          {#if propman.fullAddressInShort.postalCode}
          | {propman.fullAddressInShort.postalCode}
          {/if}
          {#if propman.fullAddressInShort.cityName}
          | {propman.fullAddressInShort.cityName}
          {/if}
          </option
        >
      {/each}
    </select>

    </fieldset>
    {#if !readMode}
      <button
        type="submit"
        class="py-5 px-10 border-2 border-[#0078c8] font-semibold text-lg rounded-md w-[90%] mb-3 justify-center cursor-pointer hover:bg-blue-400"
        >{submitButtonMessage}</button
      >
    {/if}
    
  </form>
  {#if readMode}
    <Map {building} displayLink={false} />
  {/if}
{/if}
