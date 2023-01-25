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
  {#if buttonAllTasksVisibility}
    <a href="/tasks/getAll">
      <button
        class="mx-auto mb-[2%] p-16 rounded-sm w-1/4 bg-[#007acc] text-white font-semibold flex justify-center"
        >Wszystkie zadania</button
      >
    </a>
  {/if}
  <a href="/tasks/{userId}/performer_tasks">
    <button
      class="mx-auto mb-[2%] p-16 rounded-sm w-1/4 bg-[#007acc] text-white font-semibold flex justify-center"
      >Moje zadania</button
    >
  </a>
{/if}
