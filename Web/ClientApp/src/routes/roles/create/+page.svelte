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

<form on:submit|preventDefault={submitHandler} class="w-1/2 my-[10px] mx-auto py-3 px-5 bg-[#f4f7f8] rounded-lg text-center">
    <button on:click|preventDefault={closeHandler} class="py-5 px-10 bg-red-500 text-lg font-normal rounded-md w-[20%] mb-3 flexbox justify-center cursor-pointer">Zamknij</button>
    <button type="submit" class="py-5 px-10 bg-[#0078c8] text-lg font-normal rounded-md w-[70%] mb-3 flexbox justify-center cursor-pointer">Utwórz</button>

    <legend class="font-bold text-2xl py-5">Dodaj rolę</legend>

    <label for="roleName" class="block">Nazwa</label>
    <input type="text" bind:value={roleName} class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] text-[#8a97a9] border-2 focus:border-[#0078c8]"/>
    <br />
</form>
