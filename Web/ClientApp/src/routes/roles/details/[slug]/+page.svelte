<script>
    import { onMount } from "svelte";
    import { page } from "$app/stores";
    import { getUserById, putUser } from "$lib/stores/Users";
    import { getAllRoles } from "$lib/stores/Roles";
    import { goto } from "$app/navigation";

    let user = {
        id: null,
        login: null,
        firstName: null,
        lastName: null,
        email: null,
        phoneNumber: null,
        role: {
            id: null,
            name: null,
        },
    };
    let roles = [];
    let isPasswordChanging = false;
    let isEditing = false;
    let readonlyValue = "disabled";

    onMount(async () => {
        user = await getUserById($page.params.slug);
        roles = await getAllRoles();
    });

    async function submitHandler() {
        alert("submitHandler");
        let dto = {
            login: user.login,
            firstName: user.firstName,
            lastName: user.lastName,
            email: user.email,
            phoneNumber: user.phoneNumber,
            roleId: user.role.id,
            id: user.id,
        };

        await putUser(user.id, dto);
        isEditing = false;
        readonlyValue = "disabled";
    }

    function editHandler() {
        isEditing = true;
        readonlyValue = "";
    }

    function closeHandler() {
        alert("closeHandler");
        //goto("/users");
    }
</script>

<h2>Rola</h2>

<form on:submit|preventDefault={submitHandler}>
    {#if isEditing}
        <button type="submit">Zapisz</button>
    {:else}
        <button on:click={editHandler}>Edytuj</button>
    {/if}
    <button on:click|preventDefault={closeHandler}>Zamknij</button>

    <br />
    <br />

    <label for="user.login">Login</label>
    <input type="text" bind:value={user.login} disabled={readonlyValue} />
    <br />
</form>
