<script>
    import { onMount } from "svelte";
    import { page } from "$app/stores";
    import { getRoleById, putRole } from "$lib/stores/Roles";
    import { goto } from "$app/navigation";

    let role = {
        id: null,
        name: null,
    };
    let isEditing = false;

    onMount(async () => {
        role = await getRoleById($page.params.slug);
    });

    async function submitHandler() {
        await putRole($page.params.slug, role);
        changeEditingStatus();
    }

    function editHandler() {
        changeEditingStatus();
    }

    function closeHandler() {
        goto("/roles");
    }

    function changeEditingStatus() {
        isEditing = !isEditing;
    }
</script>

<h2>Rola {role.name}</h2>
<form on:submit|preventDefault={submitHandler}>
    {#if isEditing}
        <button type="submit">Zapisz</button>
    {:else}
        <button on:click|preventDefault={editHandler}>Edytuj</button>
    {/if}
    <button on:click|preventDefault={closeHandler}>Zamknij</button>

    <br />
    <br />

    <label for="role.name">Nazwa</label>
    <input type="text" bind:value={role.name} disabled={!isEditing} />
    <br />
</form>
