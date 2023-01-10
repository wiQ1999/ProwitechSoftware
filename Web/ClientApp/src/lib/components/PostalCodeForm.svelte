<script>
  import { page } from "$app/stores";
  import { onMount } from "svelte";
  import { updateBuildingAddressPostalCode } from "$lib/stores/BuildingAddress.js";
  import { openModal } from "svelte-modals";
  import BasePopUp from "$lib/components/base/BasePopUp.svelte";

  export let upperInfo = "";
  export let redirectionHref = "";
  export let buildingAddressDTO = {
    id: "",
    cityName: "",
    streetName: "",
    buildingNumber: "",
    postalCode: "",
  };
  export let prepareForm = async () => {};

  let postalCodeOriginal = "";
  let postalCodeFromUpdate = "";

  let buildingAddressId;
  onMount(async () => {
    await prepareForm();
    prepareVariables();
  });

  function prepareVariables() {
    postalCodeOriginal = buildingAddressDTO.postalCode;
    postalCodeFromUpdate = structuredClone(postalCodeOriginal);
    buildingAddressId = buildingAddressDTO.id;
  }
  const updatePostalCode = async () => {
    let updateResult = await tryToUpdatePostalCode();
    // if (updateResult == -1) {
    //   setTimeout(() => {
    //     window.location.reload();
    //   }, 2000);
    // }
  };
  const tryToUpdatePostalCode = async () => {
    let codesDiffer = checkIfPostalCodesDiffer(
      postalCodeOriginal,
      postalCodeFromUpdate
    );
    if (!codesDiffer) {
      openModal(BasePopUp, {
        title: "BRAK AKCJI",
        message: "Nowy kod pocztowy nie różni się od starego!",
        reloadRequired: false,
      });
      return 0;
    }
    let updated = await updateBuildingAddressPostalCode(
      buildingAddressId,
      postalCodeFromUpdate
    );
    if (updated instanceof Response) {
      openModal(BasePopUp, {
        title: "Udana akcja",
        message: "Pomyślnie edytowano kod pocztowy",
        reloadRequired: false,
        redirectionRequired: true,
        redirectionHref: redirectionHref,
      });
      return 1;
    } else {
      return -1;
    }
  };

  function checkIfPostalCodesDiffer(oldCode, newCode) {
    if (oldCode == newCode) return false;
    return true;
  }
</script>

<div>
  <form on:submit|preventDefault={updatePostalCode} class="w-[50%] my-3 mx-auto py-3 px-5 bg-[#f4f7f8] rounded-lg text-center">
    <fieldset class="border-none">
      <legend class="font-semibold text-lg py-5"> {upperInfo} </legend>
      <div class="postal-code-building-address-info text-2xl font-semibold mb-5">
        {buildingAddressDTO.streetName}
        {buildingAddressDTO.buildingNumber},
        {buildingAddressDTO.cityName}
      </div>
      <label for="postal-code-value" class="block">Kod pocztowy</label>
      <input type="text" bind:value={postalCodeFromUpdate} class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8]"/>
      <button
      type="submit"
      class="py-5 px-10 bg-[#0078c8] text-lg font-normal rounded-md w-[90%] mb-3 justify-center cursor-pointer"
      >EDYTUJ</button
    >
  </form>
</div>
