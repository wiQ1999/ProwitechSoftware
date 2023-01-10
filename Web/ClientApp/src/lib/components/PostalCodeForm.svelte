<script>
  import { page } from "$app/stores";
  import { onMount } from "svelte";
  import { getBuildingById, updateBuilding } from "$lib/stores/Building.js";
  import { updateBuildingAddressPostalCode } from "$lib/stores/BuildingAddress.js";
  import { openModal } from "svelte-modals";
  import BasePopUp from "$lib/components/base/BasePopUp.svelte";

  export let buildingId;
  export let upperInfo = "";
  export let redirectionHref = "";

  let building;
  let postalCodeOriginal = "";
  let postalCodeFromUpdate = "";
  let buildingAddressDTO = {
    cityName: "",
    streetName: "",
    buildingNumber: "",
  };
  let buildingAddressId;
  onMount(async () => {
    await prepareForm($page.params.slug);
  });

  async function prepareForm(buildingId) {
    let buildingResponse = await getBuildingById(buildingId);
    if (buildingResponse instanceof Response) {
      building = await buildingResponse.json();
      console.log(building);
      postalCodeOriginal = building.buildingAddress.postalCode;
      postalCodeFromUpdate = structuredClone(postalCodeOriginal);
      buildingAddressId = building.buildingAddress.id;
      console.log(buildingAddressId);
      buildingAddressDTO = {
        cityName: building.buildingAddress.cityName,
        streetName: building.buildingAddress.streetName,
        buildingNumber: building.buildingAddress.buildingNumber,
      };
    }
  }
  const updatePostalCode = async () => {
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
      return;
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
    }
  };
  function checkIfPostalCodesDiffer(oldCode, newCode) {
    if (oldCode == newCode) return false;
    return true;
  }
</script>

<div>
  <div class="postal-code-building-address-info">
    {upperInfo}
    {buildingAddressDTO.streetName}
    {buildingAddressDTO.buildingNumber},
    {buildingAddressDTO.cityName}
  </div>

  <form on:submit|preventDefault={updatePostalCode}>
    <label for="postal-code-value">Kod pocztowy</label>
    <input type="text" bind:value={postalCodeFromUpdate} />
    <button
      type="submit"
      class="py-5 px-10 bg-[#0078c8] text-lg font-normal rounded-md w-[90%] mb-3 justify-center cursor-pointer"
      >EDYTUJ</button
    >
  </form>
</div>
