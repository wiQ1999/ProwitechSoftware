<script>
  import RealPropertyForm from "$lib/components/RealPropertyForm.svelte";
  import {
    putRealProperty,
    getRealPropertyById,
  } from "$lib/stores/RealProperty";
  import { openModal } from "svelte-modals";
  import BasePopUp from "$lib/components/base/BasePopUp.svelte";
  import { page } from "$app/stores";
  import { onMount } from "svelte";

  let formVisibility = false;
  let UpdateRealPropertyCommand = {
    id: "",
    buildingId: "",
    PropertyAddressWithVenueNumberDTO: {
      venueNumber: "",
      staircaseNumber: "",
    },
  };
  onMount(async () => {
    let res = await getRealPropertyById($page.params.real_prop_id);
    if (res instanceof Response) {
      let realProperty = await res.json();
      UpdateRealPropertyCommand = {
        id: realProperty.id,
        buildingId: realProperty.building.id,
        PropertyAddressWithVenueNumberDTO: {
          venueNumber: realProperty.propertyAddress.venueNumber,
          staircaseNumber: realProperty.propertyAddress.staircaseNumber,
        },
      };
      console.log(realProperty);
    }
    formVisibility = true;
  });
  const updateRealProperty = async () => {
    UpdateRealPropertyCommand.id = $page.params.real_prop_id;
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
        redirectionHref: `/buildings/details/${$page.params.slug}/real-properties`,
      });
    }
  };
</script>

{#if formVisibility}
  <RealPropertyForm
    onSubmit={updateRealProperty}
    bind:CreateRealPropertyCommand={UpdateRealPropertyCommand}
    editMode={true}
  />
{/if}
