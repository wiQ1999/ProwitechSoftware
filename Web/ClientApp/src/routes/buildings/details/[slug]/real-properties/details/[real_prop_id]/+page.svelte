<script>
  import RealPropertyForm from "$lib/components/RealPropertyForm.svelte";
  import {
    putRealProperty,
    getRealPropertyById,
    checkIfRealPropertiesDiffer,
  } from "$lib/stores/RealProperty";
  import { openModal } from "svelte-modals";
  import BasePopUp from "$lib/components/base/BasePopUp.svelte";
  import { page } from "$app/stores";
  import { onMount } from "svelte";

  let formVisibility = false;
  let href;
  let originalRealProperty;
  let UpdateRealPropertyCommand = {
    id: "",
    buildingId: "",
    PropertyAddressWithVenueNumberDTO: {
      venueNumber: "",
      staircaseNumber: "",
    },
  };
  onMount(async () => {
    href = `/buildings/details/${$page.params.slug}/real-properties/getAll`;
    let res = await getRealPropertyById($page.params.real_prop_id);
    if (res instanceof Response) {
      originalRealProperty = await res.json();
      UpdateRealPropertyCommand = {
        id: originalRealProperty.id,
        buildingId: originalRealProperty.building.id,
        PropertyAddressWithVenueNumberDTO: {
          venueNumber: originalRealProperty.propertyAddress.venueNumber,
          staircaseNumber: originalRealProperty.propertyAddress.staircaseNumber,
        },
      };
    }
    formVisibility = true;
  });
  const updateRealProperty = async () => {
    let differ = checkIfRealPropertiesDiffer(
      originalRealProperty,
      UpdateRealPropertyCommand
    );
    if (!differ) {
      openModal(BasePopUp, {
        title: "Brak akcji",
        message: "Dane Nieruchomości nie zostały zmienione",
      });
      return;
    }
    let result = await putRealProperty(
      UpdateRealPropertyCommand.id,
      UpdateRealPropertyCommand
    );
    if (result instanceof Response) {
      openModal(BasePopUp, {
        title: "Sukces",
        message: "Pomyślnie edytowano nieruchomość",
        reloadRequired: false,
        redirectionRequired: true,
        redirectionHref: `/buildings/details/${$page.params.slug}/real-properties/getAll`,
      });
    }
  };
</script>

<a {href}>
  <button
    class="bg-red-500 uppercase decoration-none text-black text-base font-semibold py-[1%] mx-auto rounded-md flex w-[60%] justify-center cursor-pointer"
    >Powrót</button
  >
</a>
{#if formVisibility}
  <RealPropertyForm
    onSubmit={updateRealProperty}
    bind:CreateRealPropertyCommand={UpdateRealPropertyCommand}
    editMode={true}
  />
{/if}
