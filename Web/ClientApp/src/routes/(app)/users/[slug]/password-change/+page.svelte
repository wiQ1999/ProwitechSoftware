<script>
    import { page } from "$app/stores";
    import { putUserPassword } from "$lib/stores/Users";

    let password = {
        new: null,
        repeat: null,
    };

    function submitHandler() {
        if (validateForm()) {
            let id = $page.params.slug;
            let dto = {
                id: id,
                password: password.new,
            };

            putUserPassword(id, dto);
            //popup o powodzeniu
            alert("Pomyślnie zmieniono hasło.");
        }

        resetForm();
    }

    async function validateForm() {
        if (password.new !== password.repeat) {
            //popup o błędzie
            await alert("Hasła muszą być takie same.");
            return false;
        }

        return true;
    }

    function resetForm() {
        password.new = null;
        password.repeat = null;
    }
</script>

<form on:submit|preventDefault={submitHandler} class="w-1/2 mt-[10px] mb-10 mx-auto py-3 px-5 bg-[#f4f7f8] rounded-lg text-center">
    

    <fieldset class="border-none">
    <legend class="font-bold text-lg py-5">Zmiana hasła użytkownika</legend>

    <label for="password" class="block">Nowe hasło</label>
    <input type="password" bind:value={password.new} required class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8]"/>
    <br />
    <label for="repeat" class="block">Powtórz hasło</label>
    <input type="password" bind:value={password.repeat} required class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8]"/>

    <button type="submit" class="w-[100%] border-2 border-[#0078c8] p-2 mb-5 hover:bg-blue-400">Zapisz</button>
</fieldset>
</form>
