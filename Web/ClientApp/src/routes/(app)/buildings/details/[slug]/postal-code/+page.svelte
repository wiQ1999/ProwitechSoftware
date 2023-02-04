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
      buildingAddressDTO = {
        id: building.buildingAddress.id,
        cityName: building.buildingAddress.cityName,
        streetName: building.buildingAddress.streetName,
        buildingNumber: building.buildingAddress.buildingNumber,
        postalCode: building.buildingAddress.postalCode,
      };
    }
  };

    function closeHandler() {
        goto("/buildings/getAll");
    }

    function openMenu() {
        let button = document.getElementById('openableButton');
        if(!button.hidden) button.hidden = true;
        else button.hidden = false;
        }
</script>

<div class="absolute ml-[3%] mt-5 mr-[78%] w-[20%] text-left">
  <button on:mouseenter={openMenu} on:mouseleave={openMenu} class="bg-blue-500 p-2 text-2xl"><i class="fa fa-align-justify"></i></button>
  <div on:mouseenter={openMenu} on:mouseleave={openMenu} hidden id="openableButton" class="text-center bg-blue-500"> 
      <!--kontener dla dużych ekranów wyświetlający się po lewej a dla mniejszych jako menu rozwijane?-->
      <a href="/buildings/details/{$page.params.slug}">Szczegóły</a>
      <br />
      <a href="/buildings/details/{$page.params.slug}/postal-code">Kod pocztowy</a>
      <br />
      <a href="/buildings/details/{$page.params.slug}/protocols">Protokoły</a>
      <br />
      <a href="/buildings/details/{$page.params.slug}/real-properties/getAll">Lokale</a>
      <br />
      <button on:click|preventDefault={closeHandler} class="bg-red-500 w-[100%]">Zamknij</button>
  </div>
</div>
<a href={redirectionHref} class="bg-red-500 uppercase decoration-none text-black text-base font-semibold py-[1%] mx-auto rounded-md flex w-[60%] justify-center cursor-pointer">POWRÓT</a>
<PostalCodeForm
  upperInfo={"Edycja kodu pocztowego adresu budynku"}
  {redirectionHref}
  {buildingAddressDTO}
  {prepareForm}
/>
