<script>
  import { closeModal } from "svelte-modals";
  export let isOpen;

  export let title;
  export let message;
  export let onOkay = async () => {};
  export let undoSingleColorSelection = false;
  export let selectedElementHtmlDomId = 0;
  export let undoMultipleColorSelection = false;
  export let selectedClassName = "";

  const _onOkay = async () => {
    closeModal();
    await onOkay();
  };
  const _onCancel = () => {
    closeModal();
    if (undoSingleColorSelection) {
      document
        .getElementById(selectedElementHtmlDomId)
        .removeAttribute("style");
    }
    if (undoMultipleColorSelection) {
      const rowsElems = Array.from(
        document.getElementsByClassName(selectedClassName)
      );
      rowsElems.forEach((rowElem) => {
        rowElem.removeAttribute("style");
      });
    }
  };
</script>

{#if isOpen}
  <div role="dialog" class="fixed top-0 bottom-0 right-0 left-0 flex justify-center items-center pointer-events-none">
    <div class="min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between pointer-events-none">
      <h2 class="text-center text-2xl">{title}</h2>
      <p class="text-center mt-4">{message}</p>
      <div class="mt-8 flex justify-end">
        <button on:click={_onOkay} class="bg-green-500 uppercase decoration-none text-black text-base py-[1%] my-[5%] mx-auto rounded-md flex w-[60%] justify-center">OK</button>
        <button on:click={_onCancel} class="bg-red-500 uppercase decoration-none text-black text-base py-[1%] my-[5%] mx-auto rounded-md flex w-[60%] justify-center">Anuluj</button>
      </div>
    </div>
  </div>
{/if}
