<script>
    import formNameStore from "$lib/stores/GlobalStore.js";
    import { onMount } from "svelte";
    import { page } from "$app/stores";
    import { getUserById, putUser } from "$lib/stores/Users";
    import { getAllRoles } from "$lib/stores/Roles";
    import BaseEditableForm from "$lib/components/base/BaseEditableForm.svelte";

    let baseUser = {};
    let user = {};
    let roles = [];
    let isEditing = false;

    onMount(async () => {
        baseUser = await getUserById($page.params.slug);
        user = { ...baseUser };
        roles = await getAllRoles();

        updateRoleSelect();

        formNameStore.update(() => user.login ?? "");
    });

    function updateRoleSelect() {
        user.role = roles.find((r) => r.id === user.role?.id);
    }

    async function onSubmitHandler() {
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

        isEditing = false;
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

    function onEditingStopHandler() {
        user = { ...baseUser };
        updateRoleSelect();
    }

    function clearRoleInputHandler() {
        user.role = null;
    }
</script>

<BaseEditableForm
    bind:isEditing
    formName="Szczegóły użytkownika"
    {onEditingStopHandler}
    {onSubmitHandler}
>
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
        required
        class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]"
    />

    <br />

    <label for="lastName" class="block">Nazwisko</label>
    <input
        name="lastName"
        type="text"
        bind:value={user.lastName}
        disabled={!isEditing}
        required
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
        <div class="flex">
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
            class="px-4 mb-8 font-bold border-silver border-2 disabled:font-normal disabled:text-black disabled:bg-[#e8eeef] hover:bg-gray-200"
            >X
        </button>
    </div>
    </div>
</BaseEditableForm>
