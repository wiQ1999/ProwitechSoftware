<script>
    import formNameStore from "$lib/stores/GlobalStore.js";
    import { onMount } from "svelte";
    import { page } from "$app/stores";
    import { getUserById, putUser } from "$lib/stores/Users";
    import { getAllRoles } from "$lib/stores/Roles";

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

        formNameStore.update(() => user?.login ?? "");
    });

    async function submitHandler() {
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
            await putUser(user.id, dto);
            baseUser = Object.assign({}, user);
        }
        changeEditingStatus();
    }

    function checkIfUserChenged() {
        return !(
            user?.id === baseUser?.id &&
            user?.login === baseUser?.login &&
            user?.firstName === baseUser?.firstName &&
            user?.lastName === baseUser?.lastName &&
            user?.email === baseUser?.email &&
            user?.phoneNumber === baseUser?.phoneNumber &&
            user?.role?.id === baseUser?.role?.id
        );
    }

    function editHandler() {
        changeEditingStatus();
    }

    function changeEditingStatus() {
        isEditing = !isEditing;
    }

    function roleInputHangler(event) {
        let role = roles.find((r) => r.id == event.target.value);
        user.role = role;
    }
</script>



<form on:submit|preventDefault={submitHandler} class="w-1/2 mt-[10px] mb-10 mx-auto py-3 px-5 bg-[#f4f7f8] rounded-lg text-center">
    {#if isEditing}
        <button type="submit">Zapisz</button>
    {:else}
        <button on:click|preventDefault={editHandler}>Edytuj</button>
    {/if}

    <fieldset class="border-none">
    <legend class="font-bold text-lg py-5">Szczegóły użytkownika</legend>

    <label for="login" class="block">Login</label>
    <input
        name="login"
        type="text"
        bind:value={user.login}
        disabled={!isEditing}
        required class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]"
    />
    <br />
    <label for="firstName" class="block">Imię</label>
    <input
        name="firstName"
        type="text"
        bind:value={user.firstName}
        disabled={!isEditing}
        required class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]"
    />
    <br />
    <label for="lastName" class="block">Nazwisko</label>
    <input
        name="lastName"
        type="text"
        bind:value={user.lastName}
        disabled={!isEditing}
        required class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]"
    />
    <br />
    <label for="email" class="block">Email</label>
    <input
        name="email"
        type="text"
        bind:value={user.email}
        disabled={!isEditing}
        required class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]"
    />
    <br />
    <label for="phoneNumber" class="block">Numer telefonu</label>
    <input
        name="phoneNumber"
        type="text"
        bind:value={user.phoneNumber}
        disabled={!isEditing}
        required class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]"
    />
    <br />
    <label for="role" class="block">Rola</label>
    <select name="role" on:input={roleInputHangler} disabled={!isEditing} required class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]">
        {#each roles as role}
            {#if user.role != null && user.role.id == role.id}
                <option value={role.id} selected>{role.name}</option>
            {:else}
                <option value={role.id}>{role.name}</option>
            {/if}
        {/each}
    </select>
</fieldset>
</form>
