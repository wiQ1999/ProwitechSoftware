<script>
  import { onMount } from "svelte";
  import { page } from "$app/stores";
  import {
    getAllBuildings,
    deleteBuilding,
    getBuildingById,
  } from "$lib/stores/Building";

  export let onSubmit = async () => {};
  export let CreateRealPropertyCommand = {
    buildingId: "",
    PropertyAddressWithVenueNumberDTO: {
      venueNumber: "",
      staircaseNumber: "",
    },
  };
  export let editMode = false;
  let formVisibility;
  let upper_message = "Dodaj Nieruchomość";
  let buildingInfo;
  let building;
  let button_turn_on_edition_message = "Włącz edycję";
  let readMode = false;
  let submitButtonMessage = "DODAJ";
  let realPropertyForEdition = null;
  let realPropertyWithoutChanges = null;

  onMount(async () => {
    readMode = editMode;

    let buildingResponse = await getBuildingById($page.params.slug);

    if (buildingResponse instanceof Error) return;

    building = await buildingResponse.json();
    buildingInfo = `${building.buildingAddress.streetName} ${building.buildingAddress.buildingNumber}, ${building.buildingAddress.cityName}`;
    if (editMode) {
      submitButtonMessage = "ZATWIERDŹ";
      upper_message = "Szczegóły Nieruchomości";
      realPropertyForEdition = structuredClone(CreateRealPropertyCommand);
      realPropertyWithoutChanges = structuredClone(CreateRealPropertyCommand);
    }
    formVisibility = true;
  });
  function changeEditingStatus() {
    readMode = !readMode;
    if (button_turn_on_edition_message == "Włącz edycję") {
      button_turn_on_edition_message = "Zakończ edycję";
      CreateRealPropertyCommand = realPropertyForEdition;
    } else {
      button_turn_on_edition_message = "Włącz edycję";
      CreateRealPropertyCommand = realPropertyWithoutChanges;
    }
    if (readMode) upper_message = "Szczegóły Nieruchomości";
    else upper_message = "Edycja Nieruchomości";
  }
</script>

{#if formVisibility}
  <div
    class="text-center lg:my-16 my-14 opacity-50 z-[-1] text-black xl:text-[30px] md:text-lg text-sm tracking-wide"
  >
    {buildingInfo}
  </div>
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
      <label for="building-address-city-name" class="block">Numer lokalu</label>
      <input
        type="text"
        bind:value={CreateRealPropertyCommand.PropertyAddressWithVenueNumberDTO
          .venueNumber}
        disabled={readMode}
        required
        class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]"
      />

      <label for="property-manager-name" class="block"
        >Numer klatki schodowej (opcjonalnie)</label
      >
      <input
        type="text"
        bind:value={CreateRealPropertyCommand.PropertyAddressWithVenueNumberDTO
          .staircaseNumber}
        disabled={readMode}
        class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]"
      />
    </fieldset>
    {#if !readMode}
      <button
        type="submit"
        class="py-5 px-10 border-2 border-[#0078c8] font-semibold text-lg rounded-md w-[90%] mb-3 justify-center cursor-pointer hover:bg-blue-400"
        >{submitButtonMessage}</button
      >
    {/if}
  </form>
{/if}
