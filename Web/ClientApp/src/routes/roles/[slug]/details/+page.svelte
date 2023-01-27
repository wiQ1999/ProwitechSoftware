<script>
    import formNameStore from "$lib/stores/GlobalStore.js";
    import { onMount } from "svelte";
    import { page } from "$app/stores";
    import { getRoleById, putRole } from "$lib/stores/Roles";

    let baseRole = {};
    let role = {};
    let isEditing = false;

    onMount(async () => {
        baseRole = await getRoleById($page.params.slug);
        role = { ...baseRole };

        formNameStore.update(() => role.name ?? "");
    });

    async function submitHandler() {
        if (checkIfRoleChanged()) {
            await putRole($page.params.slug, role);
            baseRole = { ...role };
        }
        changeEditingStatus();
    }

    function checkIfRoleChanged() {
        return !(role.id === baseRole.id && role.name === baseRole.name);
    }

    function editHandler() {
        changeEditingStatus();
    }

    function changeEditingStatus() {
        isEditing = !isEditing;
    }
</script>

<form
    on:submit|preventDefault={submitHandler}
    class="w-1/2 my-[10px] mx-auto py-3 px-5 bg-[#f4f7f8] rounded-lg text-center"
>
    <fieldset class="border-none">
        <legend class="font-bold text-lg py-5">Szczegóły roli</legend>

        <label for="role.name" class="block">Nazwa</label>
        <input
            type="text"
            bind:value={role.name}
            disabled={!isEditing}
            required
            class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]"
        />
    </fieldset>

    {#if isEditing}
        <button
            type="submit"
            class="w-[100%] border-2 border-[#0078c8] p-2 mb-5 hover:bg-blue-400"
            >Zakończ edycję
        </button>
    {:else}
        <button
            on:click|preventDefault={editHandler}
            class="w-[100%] border-2 border-[#0078c8] p-2 mb-5 hover:bg-blue-400"
            >Edytuj
        </button>
    {/if}
</form>
