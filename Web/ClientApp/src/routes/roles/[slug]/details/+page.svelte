<script>
    import formNameStore from "$lib/stores/GlobalStore.js";
    import { onMount } from "svelte";
    import { page } from "$app/stores";
    import { getRoleById, putRole } from "$lib/stores/Roles";

    let baseRole;
    let role = {
        id: null,
        name: null,
    };
    let isEditing = false;

    onMount(async () => {
        baseRole = await getRoleById($page.params.slug);
        role = Object.assign({}, baseRole);

        formNameStore.update(() => role.name ?? "");
    });

    async function submitHandler() {
        if (checkIfRoleChanged()) {
            await putRole($page.params.slug, role);
            baseRole = Object.assign({}, role);
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


<form on:submit|preventDefault={submitHandler} class="w-1/2 my-[10px] mx-auto py-3 px-5 bg-[#f4f7f8] rounded-lg text-center">
    {#if isEditing}
        <button type="submit">Zapisz</button>
    {:else}
        <button on:click|preventDefault={editHandler}>Edytuj</button>
    {/if}
    
    <fieldset class="border-none">
    <legend class="font-bold text-lg py-5">Szczegóły roli</legend>

    <label for="role.name" class="block">Nazwa</label>
    <input type="text" bind:value={role.name} disabled={!isEditing} required class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] text-[#8a97a9] border-2 focus:border-[#0078c8]"/>
    </fieldset>
</form>
