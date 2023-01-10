<script>
  import { page } from "$app/stores";
  import { onMount } from "svelte";
  import PostalCodeForm from "$lib/components/PostalCodeForm.svelte";
  let redirectionHref;
  onMount(() => {
    redirectionHref = `/buildings/details/${$page.params.slug}`;
  });
</script>

<a href={redirectionHref}>POWRÓT</a>
<PostalCodeForm
  upperInfo={"Edycja kodu pocztowego adresu budynku"}
  buildingId={$page.params.slug}
  {redirectionHref}
/>
