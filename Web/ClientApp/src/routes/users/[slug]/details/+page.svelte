<script>
    import { onMount } from "svelte";
    import { page } from "$app/stores";
    import { getUserById, putUser } from "$lib/stores/Users";
    import { getAllRoles } from "$lib/stores/Roles";
    import { goto } from "$app/navigation";

    let baseUser;
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
    let isEditing = false;

    onMount(async () => {
        baseUser = await getUserById($page.params.slug);
        user = Object.assign({}, baseUser);
        roles = await getAllRoles();
    });

    function submitHandler() {
        if (checkIfUserChenged()) {
            let dto = {
                login: user.login,
                firstName: user.firstName,
                lastName: user.lastName,
                email: user.email,
                phoneNumber: user.phoneNumber,
                roleId: user.role.id,
                id: user.id,
            };
            putUser(user.id, dto);
            baseUser = user;
        }
        changeEditingStatus();
    }

    function checkIfUserChenged() {
        return (
            user?.id !== baseUser?.id ||
            user?.login !== baseUser?.login ||
            user?.firstName !== baseUser?.firstName ||
            user?.lastName !== baseUser?.lastName ||
            user?.email !== baseUser?.email ||
            user?.phoneNumber !== baseUser?.phoneNumber ||
            user?.role?.id !== baseUser?.role?.id
        );
    }

    function editHandler() {
        changeEditingStatus();
    }

    function changeEditingStatus() {
        isEditing = !isEditing;
    }

    function closeHandler() {
        goto("/users");
    }

    function roleInputHangler(event) {
        let role = roles.find((r) => r.id == event.target.value);
        user.role = role;
    }
</script>

<h2>Użytkownik {user.login}</h2>

<form on:submit|preventDefault={submitHandler}>
    {#if isEditing}
        <button type="submit">Zapisz</button>
    {:else}
        <button on:click|preventDefault={editHandler}>Edytuj</button>
    {/if}
    <button on:click|preventDefault={closeHandler}>Zamknij</button>

    <br />
    <br />

    <label for="login">Login</label>
    <input
        name="login"
        type="text"
        bind:value={user.login}
        disabled={!isEditing}
    />
    <br />
    <label for="firstName">Imię</label>
    <input
        name="firstName"
        type="text"
        bind:value={user.firstName}
        disabled={!isEditing}
    />
    <br />
    <label for="lastName">Nazwisko</label>
    <input
        name="lastName"
        type="text"
        bind:value={user.lastName}
        disabled={!isEditing}
    />
    <br />
    <label for="email">Email</label>
    <input
        name="email"
        type="text"
        bind:value={user.email}
        disabled={!isEditing}
    />
    <br />
    <label for="phoneNumber">Numer telefonu</label>
    <input
        name="phoneNumber"
        type="text"
        bind:value={user.phoneNumber}
        disabled={!isEditing}
    />
    <br />
    <label for="role">Rola</label>
    <select name="role" on:input={roleInputHangler} disabled={!isEditing}>
        {#each roles as role}
            {#if user.role != null && user.role.id == role.id}
                <option value={role.id} selected>{role.name}</option>
            {:else}
                <option value={role.id}>{role.name}</option>
            {/if}
        {/each}
    </select>
</form>
