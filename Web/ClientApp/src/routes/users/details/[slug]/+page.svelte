<script>
    import { onMount } from "svelte";
    import { page } from "$app/stores";
    import { getUserById, putUser } from "$lib/stores/Users";
    import { getAllRoles } from "$lib/stores/Roles";
    import { goto } from "$app/navigation";

    let newPassword = {
        id: null,
        password: null,
    };
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

    function changePasswordHandler() {
        alert("changePasswordHandler");
        isPasswordChanging = true;
    }

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

{#if isPasswordChanging}
    <h2>Zmiana hasła</h2>
    <label for="newPassword.password">Hasło</label>
    <input type="password" bind:value={newPassword.password} />
{:else}
    <h2>Użytkownik</h2>

    <form on:submit|preventDefault={submitHandler}>
        <button on:click|preventDefault={changePasswordHandler}
            >Zmień hasło</button
        >
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
        <label for="user.firstName">Imię</label>
        <input
            type="text"
            bind:value={user.firstName}
            disabled={readonlyValue}
        />
        <br />
        <label for="user.lastName">Nazwisko</label>
        <input
            type="text"
            bind:value={user.lastName}
            disabled={readonlyValue}
        />
        <br />
        <label for="user.email">Email</label>
        <input type="text" bind:value={user.email} disabled={readonlyValue} />
        <br />
        <label for="user.phoneNumber">Numer telefonu</label>
        <input
            type="text"
            bind:value={user.phoneNumber}
            disabled={readonlyValue}
        />
        <br />
        <label for="user.role.id">Rola</label>
        <select bind:value={user.role.id} disabled={readonlyValue}>
            {#each roles as role}
                {#if role.id == user.role.id}
                    <option selected value={role.id}>{role.name}</option>
                {/if}
                <option value={role.id}>{role.name}</option>
            {/each}
        </select>
        <br />

        <!-- <label for="user.password">Hasło</label>
  <input
    type="password"
    bind:value={user.password}
    disabled={readonlyValue}
    required
  /> -->
    </form>
{/if}
