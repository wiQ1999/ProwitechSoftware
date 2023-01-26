<script>
  import { closeModal } from "svelte-modals";
  import { goto } from "$app/navigation";
  // provided by <Modals />
  export let isOpen;

  export let title;
  export let message;
  export let reloadRequired = false;
  export let redirectionRequired = false;
  export let redirectionHref = "";

  const handleClick = () => {
    closeModal();
    if (reloadRequired) {
      window.location.reload();
    }
    if (redirectionRequired) {
      goto(redirectionHref);
    }
  };
</script>

{#if isOpen}
  <div
    role="dialog"
    class="fixed top-0 bottom-0 right-0 left-0 flex justify-center items-center bg-black/70 z-10"
  >
    <div
      class="min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between z-10"
    >
      <h2 class="text-center text-2xl">{title}</h2>
      <p class="text-center mt-4">{message}</p>
      <div class="mt-8 flex justify-end">
        <button
          on:click={handleClick}
          class="bg-blue-500 uppercase decoration-none text-black text-base py-[1%] my-[5%] mx-auto rounded-md flex w-[60%] justify-center"
          >OK</button
        >
      </div>
    </div>
  </div>
{/if} 

<!-- {#if isOpen}
  <div role="dialog" class="modal">
    <div class="contents">
      <h2>{title}</h2>
      <p>{message}</p>
      <div class="actions">
        <button on:click={handleClick}>OK</button>
      </div>
    </div>
  </div>
{/if} -->
