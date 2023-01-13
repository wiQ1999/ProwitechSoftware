<script>
  import { page } from "$app/stores";
  import { onMount } from "svelte";
  import { getBuildingById, updateBuilding } from "$lib/stores/Building.js";
  import PostalCodeForm from "$lib/components/PostalCodeForm.svelte";
  let redirectionHref;
  let buildingAddressDTO;
  const prepareForm = async () => {
    redirectionHref = `/buildings/details/${$page.params.slug}`;
    let buildingResponse = await getBuildingById($page.params.slug);
    if (buildingResponse instanceof Response) {
      let building = await buildingResponse.json();

      console.log(building);
      buildingAddressDTO = {
        id: building.buildingAddress.id,
        cityName: building.buildingAddress.cityName,
        streetName: building.buildingAddress.streetName,
        buildingNumber: building.buildingAddress.buildingNumber,
        postalCode: building.buildingAddress.postalCode,
      };
    }
  };
</script>

<a href={redirectionHref} class="bg-red-500 uppercase decoration-none text-black text-base font-semibold py-[1%] mx-auto rounded-md flex w-[60%] justify-center cursor-pointer">POWRÓT</a>
<PostalCodeForm
  upperInfo={"Edycja kodu pocztowego adresu budynku"}
  {redirectionHref}
  {buildingAddressDTO}
  {prepareForm}
/>
