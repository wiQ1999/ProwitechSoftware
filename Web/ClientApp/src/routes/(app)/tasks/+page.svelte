<script>
  import { onMount } from "svelte";
  import { getToken, hasCreatePermissionFor } from "$lib/js-lib/authManager";
  let buttonAllTasksVisibility = false;
  let buttonsVisibility = false;
  let userId;
  onMount(() => {
    let userData = getToken();
    userId = userData.id;

    if (hasCreatePermissionFor("inspectionTasks")) {
      buttonAllTasksVisibility = true;
    }
    buttonsVisibility = true;
  });
</script>

{#if buttonsVisibility}
<div class="inline-flex w-[100%] justify-center gap-[10%]" >
  {#if buttonAllTasksVisibility}
    <a href="/tasks/getAll">
      <button
        class="xl:p-[130px] lg:p-[90px] p-[40px]  rounded-sm bg-[#007acc] text-2xl text-white uppercase font-semibold"
        >Wszystkie zadania</button
      >
    </a>
  {/if}
  <a href="/tasks/{userId}/performer_tasks">
    <button
      class="xl:p-[130px] lg:p-[90px] p-[40px] rounded-sm bg-[#007acc] text-2xl text-white uppercase font-semibold"
      >Moje zadania</button
    >
  </a>
</div>
{/if}
