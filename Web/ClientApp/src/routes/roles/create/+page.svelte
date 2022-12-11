<script>
    import { postRole } from "$lib/stores/Roles";
    import { goto } from "$app/navigation";

    let roleName = null;

    async function submitHandler() {
        let id = await postRole(roleName);
        goto(`/roles/${id}/details`);
    }

    function closeHandler() {
        goto("/roles");
    }
</script>

<h3>Dodaj rolę</h3>

<form on:submit|preventDefault={submitHandler}>
    <button type="submit">Utwórz</button>
    <button on:click|preventDefault={closeHandler}>Zamknij</button>

    <br />
    <br />

    <label for="roleName">Nazwa</label>
    <input type="text" bind:value={roleName} />
    <br />
</form>
