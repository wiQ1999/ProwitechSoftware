<script>
    import { onMount } from "svelte";
    import { postUser } from "$lib/stores/Users.js";
    import { getAllRoles } from "$lib/stores/Roles.js";
    import { goto } from "$app/navigation";

    let user = {
        login: null,
        firstName: null,
        lastName: null,
        email: null,
        phoneNumber: null,
        roleId: null,
        password: null,
    };
    let roles = [];

    onMount(async () => {
        roles = await getAllRoles();
    });

    async function submitHandler() {
        let id = await postUser(user);
        goto(`/users/${id}/details`);
    }

    function closeHandler() {
        goto("/users");
    }
</script>

<h1>Dodaj użytkownika</h1>

<form on:submit|preventDefault={submitHandler}>
    <button type="submit">Utwórz</button>
    <button on:click|preventDefault={closeHandler}>Zamknij</button>

    <br />
    <br />

    <label for="user.login">Login</label>
    <input type="text" bind:value={user.login} required />
    <br />
    <label for="user.password">Hasło</label>
    <input type="password" bind:value={user.password} required />
    <br />
    <label for="user.firstName">Imię</label>
    <input type="text" bind:value={user.firstName} required />
    <br />
    <label for="user.lastName">Nazwisko</label>
    <input type="text" bind:value={user.lastName} required />
    <br />
    <label for="user.email">Email</label>
    <input type="text" bind:value={user.email} />
    <br />
    <label for="user.phoneNumber">Numer telefonu</label>
    <input type="text" bind:value={user.phoneNumber} />
    <br />
    <label for="user.roleId">Rola</label>
    <select bind:value={user.roleId}>
        {#each roles as role}
            <option value={role.id}>{role.name}</option>
        {/each}
    </select>
    <br />
</form>
