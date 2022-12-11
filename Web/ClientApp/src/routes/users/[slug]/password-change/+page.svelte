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

<h3>Zmiana hasła</h3>

<form on:submit|preventDefault={submitHandler}>
    <button type="submit">Zapisz</button>

    <br />
    <br />

    <label for="password">Nowe hasło</label>
    <input type="password" bind:value={password.new} />
    <br />
    <label for="repeat">Powtórz hasło</label>
    <input type="password" bind:value={password.repeat} />
</form>
