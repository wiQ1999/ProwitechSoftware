<script>
    import { postRole } from "$lib/stores/Roles";
    import { goto } from "$app/navigation";

    let role = {
        name: null,
    };

    async function submitHandler() {
        let id = await postRole(role);
        goto(`/roles/details/${id}`);
    }

    function closeHandler() {
        goto("/roles");
    }
</script>

<h2>Dodaj rolę</h2>
<form on:submit|preventDefault={submitHandler}>
    <button type="submit">Utwórz</button>
    <button on:click|preventDefault={closeHandler}>Zamknij</button>

    <br />
    <br />

    <label for="role.name">Nazwa</label>
    <input type="text" bind:value={role.name} />
    <br />
</form>
