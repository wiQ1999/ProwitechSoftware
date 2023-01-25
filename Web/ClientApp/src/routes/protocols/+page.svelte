<script>
  import { onMount } from "svelte";
  import { getToken, hasCreatePermissionFor } from "$lib/js-lib/authManager";
  let buttonAllProtocolsVisibility = false;
  let buttonsVisibility = false;
  let userId;
  onMount(() => {
    let userData = getToken();
    userId = userData.id;

    if (hasCreatePermissionFor("inspectionProtocols")) {
      buttonAllProtocolsVisibility = true;
    }
    buttonsVisibility = true;
  });
</script>

{#if buttonsVisibility}
  {#if buttonAllProtocolsVisibility}
    <a href="/protocols/getAll">
      <button
        class="mx-auto mb-[2%] p-16 rounded-sm w-1/4 bg-[#007acc] text-white font-semibold flex justify-center"
        >Wszystkie protokoły</button
      >
    </a>
  {/if}
  <a href="/protocols/{userId}/performer_protocols">
    <button
      class="mx-auto mb-[2%] p-16 rounded-sm w-1/4 bg-[#007acc] text-white font-semibold flex justify-center"
      >Moje protokoły</button
    >
  </a>
{/if}
