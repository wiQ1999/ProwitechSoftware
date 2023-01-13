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

<form on:submit|preventDefault={submitHandler} class="w-1/2 my-[10px] mx-auto py-3 px-5 bg-[#f4f7f8] rounded-lg text-center">
    <button on:click|preventDefault={closeHandler} class="py-5 px-10 bg-red-500 text-lg font-normal rounded-md w-[20%] mb-3 flexbox justify-center">Zamknij</button>
    <button type="submit" class="py-5 px-10 bg-[#0078c8] text-lg font-normal rounded-md w-[70%] mb-3 flexbox justify-center">Utwórz</button>
    
    <legend class="font-bold text-2xl py-5">Dodaj użytkownika</legend>

    <label for="user.roleId" class="block">Rola</label>
    <select bind:value={user.roleId} class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] text-[#8a97a9] border-2 focus:border-[#0078c8]" >
        {#each roles as role}
            <option value={role.id}>{role.name}</option>
        {/each}
    </select>
    <label for="user.login" class="block">Login</label>
    <input type="text" bind:value={user.login} required class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] text-[#8a97a9] border-2 focus:border-[#0078c8]" />
    <br />
    <label for="user.password" class="block">Hasło</label>
    <input type="password" bind:value={user.password} required class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] text-[#8a97a9] border-2 focus:border-[#0078c8]" />
    <br />
    <label for="user.firstName" class="block">Imię</label>
    <input type="text" bind:value={user.firstName} required class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] text-[#8a97a9] border-2 focus:border-[#0078c8]" />
    <br />
    <label for="user.lastName" class="block">Nazwisko</label>
    <input type="text" bind:value={user.lastName} required class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] text-[#8a97a9] border-2 focus:border-[#0078c8]" />
    <br />
    <label for="user.email" class="block">Email</label>
    <input type="text" bind:value={user.email} class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] text-[#8a97a9] border-2 focus:border-[#0078c8]" />
    <br />
    <label for="user.phoneNumber" class="block">Numer telefonu</label>
    <input type="text" minlength="9" maxlength="9" bind:value={user.phoneNumber} class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] text-[#8a97a9] border-2 focus:border-[#0078c8]" />
    <br />
    
    <br />
</form>
