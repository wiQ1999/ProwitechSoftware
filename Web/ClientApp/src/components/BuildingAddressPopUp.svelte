<script>
  import { postBuildingAddress } from "../stores/BuildingAddress.js";
  import { HttpMethodError } from "../js-lib/errors.js";

  export let corrdinates_not_found_message;
  export let addedBuildingAddress;

  let result_window_show = false;
  let question_window_show = true;

  let result_message = "";
  let addBuildingAddressDTOagain = {
    cityName: "",
    streetName: "",
    buildingNumber: "",
  };
  let addBuildingAddressDTOWithLongAndLat = {
    cityName: "",
    streetName: "",
    buildingNumber: "",
    longitude: 0.0,
    latitude: 0.0,
  };

  let force_option = {
    info: "TAK - dodaj współrzędne mimo to",
    optionalArguments: {
      force: true,
      onlyAddress: false,
    },
  };
  let only_address_option = {
    info: "NIE - dodaj adres bez współrzędnych i kodu pocztowego",
    optionalArguments: {
      force: false,
      onlyAddress: true,
    },
  };
  let abandon_option = {
    info: "NIE - zrezygnuj z dodawania adresu i powróć do strony głównej",
  };

  async function postBuildingAddressAgain(
    optionalArguments,
    onlyAddress = false
  ) {
    let buildingAddressPostResultAgain;
    if (onlyAddress) {
      addBuildingAddressDTOagain.cityName = addedBuildingAddress.cityName;
      addBuildingAddressDTOagain.streetName = addedBuildingAddress.streetName;
      addBuildingAddressDTOagain.buildingNumber =
        addedBuildingAddress.buildingNumber;

      buildingAddressPostResultAgain = await postBuildingAddress(
        addBuildingAddressDTOagain,
        optionalArguments
      );
    } else {
      addBuildingAddressDTOWithLongAndLat.cityName =
        addedBuildingAddress.cityName;
      addBuildingAddressDTOWithLongAndLat.streetName =
        addedBuildingAddress.streetName;
      addBuildingAddressDTOWithLongAndLat.buildingNumber =
        addedBuildingAddress.buildingNumber;
      addBuildingAddressDTOWithLongAndLat.longitude =
        addedBuildingAddress.longitude;
      addBuildingAddressDTOWithLongAndLat.latitude =
        addedBuildingAddress.latitude;

      buildingAddressPostResultAgain = await postBuildingAddress(
        addBuildingAddressDTOWithLongAndLat,
        optionalArguments
      );
    }
    question_window_show = false;
    if (buildingAddressPostResultAgain instanceof HttpMethodError) {
      result_message = buildingAddressPostResultAgain;
    } else {
      if (buildingAddressPostResultAgain.webApiStatus == "ADDED_TO_DB") {
        if (onlyAddress) {
          result_message = `Dodano do bazy poniższy adres:
      \n ${buildingAddressPostResultAgain.addedBuildingAddress.streetName} ${buildingAddressPostResultAgain.addedBuildingAddress.buildingNumber}, ${buildingAddressPostResultAgain.addedBuildingAddress.cityName}`;
        } else {
          result_message = `Dodano do bazy poniższy adres:
      \n ${buildingAddressPostResultAgain.addedBuildingAddress.streetName} ${buildingAddressPostResultAgain.addedBuildingAddress.buildingNumber}, ${buildingAddressPostResultAgain.addedBuildingAddress.postalCode} ${buildingAddressPostResultAgain.addedBuildingAddress.cityName}`;
        }
      } else {
        result_message = `Problem z dodaniem adresu: ${buildingAddressPostResultAgain}`;
      }
    }
    result_window_show = true;
  }
</script>

<div class="Building-address-POP-UP">
  {#if question_window_show}
    <div class="question-window">
      {corrdinates_not_found_message}
      <button
        on:click|preventDefault={postBuildingAddressAgain(
          force_option.optionalArguments,
          false
        )}>{force_option.info}</button
      >
      <button
        on:click|preventDefault={postBuildingAddressAgain(
          only_address_option.optionalArguments,
          true
        )}>{only_address_option.info}</button
      >
      <a href="/index" class="button">{abandon_option.info}</a>
    </div>
  {/if}
  {#if result_window_show}
    <div class="result-window">
      {result_message}
    </div>
  {/if}
</div>
