<script>
    import { onMount } from "svelte";
    import { page } from "$app/stores";
    import { getRoleById, putRole } from "$lib/stores/Roles";
    import { goto } from "$app/navigation";

    let role = {
        id: null,
        name: null,
    };
    let isEditing = true;

    onMount(async () => {
        role = await getRoleById($page.params.slug);
    });

    async function submitHandler() {
        alert("submitHandler");
        await putRole($page.params.slug, role);
        changeEditingStatus();
    }

    function editHandler() {
        alert("editHandler");
        changeEditingStatus();
    }

    function closeHandler() {
        alert("closeHandler");
        goto("/roles");
    }

    function changeEditingStatus() {
        isEditing = !isEditing;
    }
</script>

<div class="container">
    <div class="references">
        <a href="/roles/details/{$page.params.slug}/users">Użytkownicy</a>
    </div>
    <div class="space" />
    <div class="main-form">
        <h2>Rola</h2>
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
    </div>
</div>

<style>
    .container {
        display: flex;
    }

    .references {
        margin-top: auto;
        margin-bottom: auto;
    }

    .space {
        width: 5ch;
    }
</style>
