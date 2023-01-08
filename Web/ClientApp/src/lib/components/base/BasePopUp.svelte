<script>
  import { closeModal } from "svelte-modals";
  // provided by <Modals />
  export let isOpen;

  export let title;
  export let message;
  export let reloadRequired = false;

  const handleClick = () => {
    closeModal();
    if (reloadRequired) {
      window.location.reload();
    }
  };
</script>

{#if isOpen}
  <div role="dialog" class="fixed top-0 bottom-0 right-0 left-0 flex justify-center items-center pointer-events-none">
    <div class="min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between pointer-events-none">
      <h2 class="text-center text-2xl">{title}</h2>
      <p class="text-center mt-4">{message}</p>
      <div class="mt-8 flex justify-end">
        <button on:click={handleClick} class="bg-blue-500 uppercase decoration-none text-black text-base py-[1%] my-[5%] mx-auto rounded-md flex w-[60%] justify-center">OK</button>
      </div>
    </div>
  </div>
{/if}

