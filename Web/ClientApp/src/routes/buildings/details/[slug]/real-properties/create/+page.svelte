<script>
  import RealPropertyForm from "$lib/components/RealPropertyForm.svelte";
  import { postRealProperty } from "$lib/stores/RealProperty";
  import { openModal } from "svelte-modals";
  import BasePopUp from "$lib/components/base/BasePopUp.svelte";
  import { page } from "$app/stores";

  let CreateRealPropertyCommand = {
    buildingId: $page.params.slug,
    PropertyAddressWithVenueNumberDTO: {
      venueNumber: "",
      staircaseNumber: "",
    },
  };
  const createRealProperty = async () => {
    let result = await postRealProperty(CreateRealPropertyCommand);
    if (result instanceof Response) {
      openModal(BasePopUp, {
        title: "Sukces",
        message: "Pomyślnie dodano nieruchomość",
        reloadRequired: false,
        redirectionRequired: true,
        redirectionHref: `/buildings/details/${$page.params.slug}/real-properties`,
      });
    }
  };
</script>

<RealPropertyForm
  onSubmit={createRealProperty}
  bind:CreateRealPropertyCommand
/>
