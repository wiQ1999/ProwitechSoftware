<script>
  import { onMount } from "svelte";
  export let editMode = false;
  let readMode = false;
  export let onSubmit = () => {};
  export let buildingAddressDTO = {
    cityName: "",
    streetName: "",
    buildingNumber: "",
  };
  export let propertyManagerDTO = {
    name: "",
    phoneNumber: "",
    fullAddress: {
      buildingAddressId: "",
      propertyAddress: {
        venueNumber: "",
        staircaseNumber: "",
      },
    },
  };
  let buildingAddressDTOWithoutChanges = null;
  let buildingAddressDTOForEdition = null;
  let propertyManagerDTOWithoutChanges = null;
  let propertyManagerDTOForEdition = null;

  let cities = [
    { id: "Bydgoszcz", name: "Bydgoszcz" },
    { id: "Poznań", name: "Poznań" },
    { id: "Wrocław", name: "Wrocław" },
  ];
  let button_turn_on_edition_message = "Włącz edycję";
  let form_upper_message = "Dodaj Zarządcę Nieruchomości";
  let submit_button_message = "DODAJ";
  onMount(() => {
    readMode = editMode;
    if (editMode) {
      form_upper_message = "Szczegóły Zarządcy Nieruchomości";
      submit_button_message = "ZATWIERDŹ";
      multiplyObjects();
    }
  });
  function multiplyObjects() {
    buildingAddressDTOWithoutChanges = structuredClone(buildingAddressDTO);
    buildingAddressDTOForEdition = structuredClone(buildingAddressDTO);
    propertyManagerDTOWithoutChanges = structuredClone(propertyManagerDTO);
    propertyManagerDTOForEdition = structuredClone(propertyManagerDTO);
  }
  function changeEditingStatus() {
    readMode = !readMode;
    if (button_turn_on_edition_message == "Włącz edycję") {
      button_turn_on_edition_message = "Zakończ edycję";
      buildingAddressDTO = buildingAddressDTOForEdition;
      propertyManagerDTO = propertyManagerDTOForEdition;
    } else {
      button_turn_on_edition_message = "Włącz edycję";
      buildingAddressDTO = buildingAddressDTOWithoutChanges;
      propertyManagerDTO = propertyManagerDTOWithoutChanges;
    }
    if (readMode) form_upper_message = "Szczegóły Zarządcy Nieruchomości";
    else form_upper_message = "Edycja Zarządcy Nieruchomości";
  }
</script>

<form
  on:submit|preventDefault={onSubmit}
  class="w-1/2 my-[10px] mx-auto py-3 px-5 bg-[#f4f7f8] rounded-lg text-center"
>
  <fieldset class="border-none">
    <legend class="font-bold text-lg py-5">{form_upper_message}</legend>
    {#if editMode}
      <button
        on:click|preventDefault={() => changeEditingStatus()}
        class="flex font-semibold bg-blue-400 mb-4 p-4 mx-auto rounded-md text-white"
        >{button_turn_on_edition_message}</button
      >
    {/if}
    <label for="building-address-city-name" class="block">Miejscowość</label>
    <select
      bind:value={buildingAddressDTO.cityName}
      disabled={readMode}
      class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9] disabled:bg-[#e8eeef]"
    >
      {#each cities as city}
        <!-- {#if city.id == "Poznań"}
          <option value={city.id} selected>{city.name}</option>
        {:else} -->
        <option value={city.id}>{city.name}</option>
        <!-- {/if} -->
      {/each}
    </select>
    <label for="property-manager-name" class="block"
      >Nazwa Zarządcy Nieruchomości</label
    >
    <input
      type="text"
      bind:value={propertyManagerDTO.name}
      disabled={readMode}
      required
      class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]"
    />
    <label for="property-manager-phone-number" class="block"
      >Numer telefonu</label
    >
    <input
      type="text"
      bind:value={propertyManagerDTO.phoneNumber}
      disabled={readMode}
      minlength="9"
      maxlength="9"
      required
      class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]"
    />
    <label for="property-manager-name" class="block">Nazwa ulicy</label>
    <input
      type="text"
      bind:value={buildingAddressDTO.streetName}
      disabled={readMode}
      required
      class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]"
    />
    <label for="building-address-building-number" class="block"
      >Numer budynku</label
    >
    <input
      type="text"
      bind:value={buildingAddressDTO.buildingNumber}
      disabled={readMode}
      required
      class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]"
    />
    <label for="property-manager-local-number" class="block"
      >Numer lokalu (opcjonalnie)</label
    >
    <input
      type="text"
      bind:value={propertyManagerDTO.fullAddress.propertyAddress.venueNumber}
      disabled={readMode}
      class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]"
    />
    <label for="property-manager-staircase-number" class="block"
      >Numer klatki schodowej (opcjonalnie)</label
    >
    <input
      type="text"
      bind:value={propertyManagerDTO.fullAddress.propertyAddress
        .staircaseNumber}
      disabled={readMode}
      class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]"
    />
  </fieldset>
  {#if !readMode}
    <button
      type="submit"
      class="py-5 px-10 border-2 border-[#0078c8] hover:bg-blue-400 text-lg font-semibold rounded-md w-[90%] mb-3 justify-center cursor-pointer"
      disabled={readMode}>{submit_button_message}</button
    >
  {/if}
</form>
