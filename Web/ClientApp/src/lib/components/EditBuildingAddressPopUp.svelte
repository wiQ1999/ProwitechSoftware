<script>
  import { updateBuildingAddressAgain } from "$lib/stores/BuildingAddress";
  import { onMount } from "svelte";

  export let corrdinates_not_found_message;
  export let updateBuildingAddressDTO;
  export let continueEdition = async () => {};
  export let buildingAddressId;
  export let buildingAddressChanged;

  async function returnToParent() {
    buildingAddressChanged = true;
    result_window_show = false;
    await continueEdition();
  }
  onMount(() => {
    result_window_show = false;
    question_window_show = true;
    buttonContinueVisibility = true;
    buttonErrorVisibility = false;
  });
  let result_window_show;
  let question_window_show;
  let buttonContinueVisibility;
  let buttonErrorVisibility;

  let result_message = "";

  let force_option = {
    info: "TAK - dodaj współrzędne mimo to",
    optionalArguments: {
      force: true,
      onlyAddress: false,
    },
  };
  let only_address_option = {
    info: "NIE - zaktualizuj adres bez współrzędnych",
    optionalArguments: {
      force: false,
      onlyAddress: true,
    },
  };
  let abandon_option = {
    info: "NIE - zrezygnuj z edycji adresu i powróć do strony głównej",
  };

  async function displayUpdateOutcome(
    updateBuildingAddressDTO,
    optionalArguments,
    onlyAddress = false
  ) {
    question_window_show = false;

    let updateBuildingAddressResultAgain = await updateBuildingAddressAgain(
      updateBuildingAddressDTO,
      optionalArguments,
      onlyAddress
    );
    if (updateBuildingAddressResultAgain instanceof Error) {
      result_message =
        "W wyniku błędu nie udało się edytować adresu budynku w bazie danych";
      buttonErrorVisibility = true;
      buttonContinueVisibility = false;
    } else if (updateBuildingAddressResultAgain instanceof Response) {
      let updateBuildingAddressResultAgainJSON =
        await updateBuildingAddressResultAgain.json();
      prepareResultMessageButtonsAndId(updateBuildingAddressResultAgainJSON);
    }
  }

  function prepareResultMessageButtonsAndId(
    updateBuildingAddressResultAgainJSON
  ) {
    if (
      updateBuildingAddressResultAgainJSON.webApiStatus ==
        "ADDED_DESPITE_COORDINATE_ISSUE" ||
      updateBuildingAddressResultAgainJSON.webApiStatus ==
        "ADDED_TO_DB_WITHOUT_COORDINATES"
    ) {
      buildingAddressId =
        updateBuildingAddressResultAgainJSON.addedBuildingAddress.id;
      buttonErrorVisibility = false;
      buttonContinueVisibility = true;
    }

    if (
      updateBuildingAddressResultAgainJSON.webApiStatus ==
      "ADDED_DESPITE_COORDINATE_ISSUE"
    ) {
      result_message = `Adres budynku po aktualizacji w bazie danych:
      \n ${updateBuildingAddressResultAgainJSON.addedBuildingAddress.streetName} ${updateBuildingAddressResultAgainJSON.addedBuildingAddress.buildingNumber}, ${updateBuildingAddressResultAgainJSON.addedBuildingAddress.postalCode} ${updateBuildingAddressResultAgainJSON.addedBuildingAddress.cityName}`;
    } else if (
      updateBuildingAddressResultAgainJSON.webApiStatus ==
      "ADDED_TO_DB_WITHOUT_COORDINATES"
    ) {
      result_message = `Adres budynku po aktualizacji w bazie danych:
      \n ${updateBuildingAddressResultAgainJSON.addedBuildingAddress.streetName} ${updateBuildingAddressResultAgainJSON.addedBuildingAddress.buildingNumber}, ${updateBuildingAddressResultAgainJSON.addedBuildingAddress.cityName}`;
      buildingAddressId =
        updateBuildingAddressResultAgainJSON.addedBuildingAddress.id;
    } else {
      console.log(updateBuildingAddressResultAgainJSON);
      result_message = `Problem z edycją adresu: ${updateBuildingAddressResultAgainJSON}`;
      buildingAddressId = null;
      buttonErrorVisibility = true;
      buttonContinueVisibility = false;
    }
    result_window_show = true;
  }
</script>

<div class="w-[100%] h-[100%] fixed m-0 p-0 top-0 left-0 bg-black/70">
<div class="w-[50%] h-[50%] relative my-[10%] mx-auto bg-white rounded-2xl p-[2%]">
  {#if question_window_show}
    <div class="question-window">
      <p> {corrdinates_not_found_message} </p>
      <button
        on:click|preventDefault={() =>
          displayUpdateOutcome(
            updateBuildingAddressDTO,
            force_option.optionalArguments
          )}>{force_option.info}</button
      >
      <button
        on:click|preventDefault={() =>
          displayUpdateOutcome(
            updateBuildingAddressDTO,
            only_address_option.optionalArguments,
            true
          )}>{only_address_option.info}</button
      >
      <a href="/" class="bg-blue-400 uppercase decoration-none text-black text-base py-[1%] my-[5%] mx-auto w-[100%] rounded-md border-0 flex justify-center cursor-pointer">{abandon_option.info}</a>
    </div>
  {/if}
  {#if result_window_show}
    <div class="result-window">
      {result_message}
      {#if buttonContinueVisibility}
        <button on:click|preventDefault={async () => await returnToParent()} class="bg-green-400 uppercase decoration-none text-black text-base py-[1%] my-[5%] mx-auto w-[100%] rounded-md border-0 flex justify-center cursor-pointer"
          >Kontynuuj</button
        >
      {/if}
      {#if buttonErrorVisibility}
        <button on:click|preventDefault={() => window.location.reload()} class="bg-yellow-400 uppercase decoration-none text-black text-base py-[1%] my-[5%] mx-auto w-[100%] rounded-md border-0 flex justify-center cursor-pointer"
          >Spróbuj ponownie</button
        >
      {/if}
    </div>
  {/if}
</div>
</div>
