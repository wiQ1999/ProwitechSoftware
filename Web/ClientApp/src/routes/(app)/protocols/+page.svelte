<script>
  import { onMount } from "svelte";
  import { getToken, hasCreatePermissionFor } from "$lib/js-lib/authManager";
  let buttonAllProtocolsVisibility = false;
  let buttonsVisibility = false;
  let userId;
  onMount(() => {
    let userData = getToken();
    userId = userData.id;

    if (hasCreatePermissionFor("allInspectionProtocols")) {
      buttonAllProtocolsVisibility = true;
    }
    buttonsVisibility = true;
  });
</script>

{#if buttonsVisibility}
  <div class="mt-[4%] inline-flex w-[100%] justify-center gap-[10%]">
    {#if buttonAllProtocolsVisibility}
      <a href="/protocols/getAll">
        <button
          class="xl:p-[130px] lg:p-[90px] p-[40px]  rounded-sm bg-[#007acc] text-2xl text-white uppercase font-semibold"
          >Wszystkie protokoły</button
        >
      </a>
    {/if}
    <a href="/protocols/{userId}/performer_protocols">
      <button
        class="xl:p-[130px] lg:p-[90px] p-[40px]  rounded-sm bg-[#007acc] text-2xl text-white uppercase font-semibold"
        >Moje protokoły</button
      >
    </a>
  </div>
{/if}
