<script>
  import { page } from "$app/stores";
  import { getPropertyManagerById } from "$lib/stores/PropertyManager";
  import PostalCodeForm from "$lib/components/PostalCodeForm.svelte";
  let redirectionHref;
  let buildingAddressDTO;
  let upperInfo = "";
  const prepareForm = async () => {
    redirectionHref = `/propertyManagers/details/${$page.params.slug}`;
    let propertyManagerResponse = await getPropertyManagerById(
      $page.params.slug
    );
    if (propertyManagerResponse instanceof Response) {
      let propertyManager = await propertyManagerResponse.json();
      let buildingAddress = propertyManager.fullAddress.buildingAddress;

      buildingAddressDTO = {
        id: buildingAddress.id,
        cityName: buildingAddress.cityName,
        streetName: buildingAddress.streetName,
        buildingNumber: buildingAddress.buildingNumber,
        postalCode: buildingAddress.postalCode,
      };
      upperInfo = `Edycja kodu pocztowego Zarządcy Nieruchomości "${propertyManager.name}" o adresie budynku: `;
    }
  };
</script>

<a href={redirectionHref} class="bg-red-500 uppercase decoration-none text-black text-base py-[1%] mx-auto rounded-md flex w-[60%] justify-center cursor-pointer">POWRÓT</a>
<PostalCodeForm
  {upperInfo}
  {redirectionHref}
  {buildingAddressDTO}
  {prepareForm}
/>
