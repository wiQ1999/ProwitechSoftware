<script>
    export let formName = "";
    export let isEditing = false;
    export let onEditingStartHandler = () => {};
    export let onEditingStopHandler = () => {};
    export let onSubmitHandler = () => {};

    function onEditingStartHandlerWithStatus() {
        changeEditingStatus();
        onEditingStartHandler();
    }

    function onEditingStopHandlerWithStatus() {
        changeEditingStatus();
        onEditingStopHandler();
    }

    function changeEditingStatus() {
        isEditing = !isEditing;
    }
</script>

<form
    on:submit|preventDefault={async () => onSubmitHandler()}
    class="w-1/2 mt-[10px] mb-10 mx-auto py-3 px-5 bg-[#f4f7f8] rounded-lg text-center"
>
    <p class="font-bold text-2xl py-5">{formName}</p>

    {#if isEditing}
        <button
            type="button"
            on:click={onEditingStopHandlerWithStatus}
            class="flex font-semibold bg-blue-400 mb-4 p-4 mx-auto rounded-md text-white"
            >Zakończ edycję
        </button>
    {:else}
        <button
            type="button"
            on:click={onEditingStartHandlerWithStatus}
            class="flex font-semibold bg-blue-400 mb-4 p-4 mx-auto rounded-md text-white"
            >Włącz edycję
        </button>
    {/if}

    <slot />

    {#if isEditing}
        <button
            type="submit"
            class="py-5 px-10 border-2 border-[#0078c8] font-semibold text-lg rounded-md w-[90%] mb-3 justify-center cursor-pointer hover:bg-blue-400"
            >ZATWIERDŹ
        </button>
    {/if}
</form>
