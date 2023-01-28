<script>
  import { HttpMethodError } from "$lib/js-lib/errors";
  import { postBuildingAddressAgain } from "$lib/stores/BuildingAddress.js";

  export let corrdinates_not_found_message;
  export let addedBuildingAddress;
  export let functionToInvokeAfterAdding = () => {};
  export let buildingAddressId;

  let result_window_show = false;
  let question_window_show = true;
  let buttonContinueVisibility = true;
  let buttonErrorVisibility = false;

  let result_message = "";

  let force_option = {
    info: "TAK - dodaj współrzędne mimo to",
    optionalArguments: {
      force: true,
      onlyAddress: false,
    },
  };
  let only_address_option = {
    info: "NIE - dodaj adres bez współrzędnych",
    optionalArguments: {
      force: false,
      onlyAddress: true,
    },
  };
  let abandon_option = {
    info: "NIE - zrezygnuj z dodawania adresu i powróć do strony głównej",
  };
  async function addBuildingAddress(optionalArguments, onlyAddress) {
    let buildingAddressPostResultAgain = await postBuildingAddressAgain(
      addedBuildingAddress,
      optionalArguments,
      onlyAddress
    );

    question_window_show = false;

    if (buildingAddressPostResultAgain instanceof Error) {
      result_message =
        "W wyniku błędu nie udało się dodać adresu budynku do bazy danych";
      buttonErrorVisibility = true;
      buttonContinueVisibility = false;
    } else if (buildingAddressPostResultAgain instanceof Response) {
      let buildingAddressPostResultAgainJSON =
        await buildingAddressPostResultAgain.json();
      if (
        buildingAddressPostResultAgainJSON.webApiStatus ==
        "ADDED_DESPITE_COORDINATE_ISSUE"
      ) {
        result_message = `Dodano do bazy poniższy adres:
      \n ${buildingAddressPostResultAgainJSON.addedBuildingAddress.streetName} ${buildingAddressPostResultAgainJSON.addedBuildingAddress.buildingNumber}, ${buildingAddressPostResultAgainJSON.addedBuildingAddress.postalCode} ${buildingAddressPostResultAgainJSON.addedBuildingAddress.cityName}`;
        buildingAddressId =
          buildingAddressPostResultAgainJSON.addedBuildingAddress.id;
      } else if (
        buildingAddressPostResultAgainJSON.webApiStatus ==
        "ADDED_TO_DB_WITHOUT_COORDINATES"
      ) {
        result_message = `Dodano do bazy poniższy adres:
      \n ${buildingAddressPostResultAgainJSON.addedBuildingAddress.streetName} ${buildingAddressPostResultAgainJSON.addedBuildingAddress.buildingNumber}, ${buildingAddressPostResultAgainJSON.addedBuildingAddress.cityName}`;
        buildingAddressId =
          buildingAddressPostResultAgainJSON.addedBuildingAddress.id;
      } else {
        result_message = `Problem z dodaniem adresu: ${buildingAddressPostResultAgainJSON}`;
        buttonErrorVisibility = true;
        buttonContinueVisibility = false;
      }
    }
    result_window_show = true;
  }
  async function continueAdding() {
    result_window_show = false;
    await functionToInvokeAfterAdding();
  }
</script>

<div class="fixed top-0 left-0 h-[100%] w-[100%] bg-black/70">
  <div
    class="w-[50%] h-[50%] my-[10%] mx-auto p-[2%] bg-white rounded-lg text-center justify-center"
  >
    {#if question_window_show}
      <div class="w-[100%] h-[50%]">
        {corrdinates_not_found_message}
        <button
          class="bg-green-400 uppercase decoration-none text-black text-base py-[1%] my-[5%] mx-auto w-[100%] rounder-md border-0 flex justify-center cursor-pointer"
          on:click|preventDefault={() =>
            addBuildingAddress(force_option.optionalArguments, false)}
          >{force_option.info}</button
        >
        <button
          class="bg-red-400 uppercase decoration-none text-black text-base py-[1%] my-[5%] mx-auto w-[100%] rounder-md border-0 flex justify-center cursor-pointer"
          on:click|preventDefault={() =>
            addBuildingAddress(only_address_option.optionalArguments, true)}
          >{only_address_option.info}</button
        >
        <a href="/buildings/getAll">
          <button
            class="bg-blue-400 uppercase decoration-none text-black text-base py-[1%] my-[5%] mx-auto w-[100%] rounder-md border-0 flex justify-center cursor-pointer"
            >{abandon_option.info}</button
          >
        </a>
      </div>
    {/if}
    {#if result_window_show}
      <div class="result-window w-[100%] h-[50%]">
        {result_message}
        {#if buttonContinueVisibility}
          <button
            on:click|preventDefault={async () => await continueAdding()}
            class="bg-green-400 uppercase decoration-none text-black text-base py-[1%] my-[5%] mx-auto w-[100%] rounder-md border-0 flex justify-center cursor-pointer"
            >Kontynuuj</button
          >
        {/if}
        {#if buttonErrorVisibility}
          <button
            on:click|preventDefault={() => window.location.reload()}
            class="bg-yellow-400 uppercase decoration-none text-black text-base py-[1%] my-[5%] mx-auto w-[100%] rounder-md border-0 flex justify-center cursor-pointer"
            >Spróbuj ponownie</button
          >
          <a href="/Building/getAll">
            <button
              class="bg-blue-400 uppercase decoration-none text-black text-base py-[1%] my-[5%] mx-auto w-[100%] rounder-md border-0 flex justify-center cursor-pointer"
            >
              Powrót do listy budynków
            </button>
          </a>
        {/if}
      </div>
    {/if}
  </div>
</div>
