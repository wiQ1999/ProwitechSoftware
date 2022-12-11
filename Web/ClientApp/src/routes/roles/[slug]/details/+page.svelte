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

<h3>Szczegóły</h3>

<form on:submit|preventDefault={submitHandler}>
    {#if isEditing}
        <button type="submit">Zapisz</button>
    {:else}
        <button on:click|preventDefault={editHandler}>Edytuj</button>
    {/if}

    <br />
    <br />

    <label for="role.name">Nazwa</label>
    <input type="text" bind:value={role.name} disabled={!isEditing} />
    <br />
</form>
