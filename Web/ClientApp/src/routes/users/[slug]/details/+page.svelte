<script>
    import formNameStore from "$lib/stores/GlobalStore.js";
    import { onMount } from "svelte";
    import { page } from "$app/stores";
    import { getUserById, putUser } from "$lib/stores/Users";
    import { getAllRoles } from "$lib/stores/Roles";

    let baseUser = {};
    let user = {};
    let roles = [];
    let isEditing = false;

    onMount(async () => {
        baseUser = await getUserById($page.params.slug);
        user = { ...baseUser };
        roles = await getAllRoles();

        user.role = roles.find((r) => r.id === user.role?.id);

        formNameStore.update(() => user.login ?? "");
    });

    async function submitHandler() {
        if (checkIfUserChenged()) {
            let dto = {
                login: user.login,
                firstName: user.firstName,
                lastName: user.lastName,
                email: user.email,
                phoneNumber: user.phoneNumber,
                roleId: user.role?.id,
                id: user.id,
            };

            const result = await putUser(user.id, dto);

            if (result) {
                baseUser = { ...user };
            }
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

    function clearRoleInputHandler() {
        user.role = null;
    }

    function editHandler() {
        changeEditingStatus();
    }

    function changeEditingStatus() {
        isEditing = !isEditing;
    }
</script>

<form
    on:submit|preventDefault={submitHandler}
    class="w-1/2 mt-[10px] mb-10 mx-auto py-3 px-5 bg-[#f4f7f8] rounded-lg text-center"
>
    <fieldset class="border-none">
        <legend class="font-bold text-2xl py-5">Szczegóły użytkownika</legend>

        <label for="login" class="block">Login</label>
        <input
            name="login"
            type="text"
            bind:value={user.login}
            disabled={!isEditing}
            required
            class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]"
        />

        <br />

        <label for="firstName" class="block">Imię</label>
        <input
            name="firstName"
            type="text"
            bind:value={user.firstName}
            disabled={!isEditing}
            class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]"
        />

        <br />

        <label for="lastName" class="block">Nazwisko</label>
        <input
            name="lastName"
            type="text"
            bind:value={user.lastName}
            disabled={!isEditing}
            class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]"
        />

        <br />

        <label for="email" class="block">Email</label>
        <input
            name="email"
            type="text"
            bind:value={user.email}
            disabled={!isEditing}
            class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]"
        />

        <br />

        <label for="phoneNumber" class="block">Numer telefonu</label>
        <input
            name="phoneNumber"
            type="text"
            bind:value={user.phoneNumber}
            disabled={!isEditing}
            class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]"
        />

        <br />

        <div>
            <label for="role" class="block">Rola</label>
            <select
                name="role"
                bind:value={user.role}
                disabled={!isEditing}
                class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]"
            >
                {#each roles as role}
                    <option value={role}>{role.name}</option>
                {/each}
            </select>

            <button
                type="button"
                on:click={clearRoleInputHandler}
                disabled={!isEditing}
                >X
            </button>
        </div>

        {#if isEditing}
            <button
                type="submit"
                class="w-[100%] border-2 border-[#0078c8] p-2 mb-5 hover:bg-blue-400"
                >Zapisz
            </button>
        {:else}
            <button
                type="button"
                on:click={editHandler}
                class="w-[100%] border-2 border-[#0078c8] p-2 mb-5 hover:bg-blue-400"
                >Edytuj
            </button>
        {/if}
    </fieldset>
</form>
