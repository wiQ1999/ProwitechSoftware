<script>
    import { createEventDispatcher } from "svelte";

    let dispatch = createEventDispatcher();

    let login = "";
    let password = "";
    let password2 = "";
    let firstName = "";
    let lastName = "";
    let phoneNumber = "";

    const registerForm = () => {
        const user = {
            login: login,
            password: password,
            fullName: firstName+" "+lastName,
            id: Math.random(),
        };
        dispatch("addPerson", user);
    };
</script>

<main>
    <form on:submit|preventDefault={registerForm}>
        <label>
            Logowanie: <br />
            <input
                type="text"
                placeholder="Nazwa użytkownika"
                bind:value={login}
            /> <br />
            <input type="password" placeholder="Hasło" bind:value={password} />
            <br />
            <input
                type="password"
                placeholder="Powtórz hasło"
                bind:value={password2}
            /><br />
            <br />
            <input type="text" placeholder="Imię" bind:value={firstName} />
            <br />
            <input type="text" placeholder="Nazwisko" bind:value={lastName} />
            <br />
            <input type="text" placeholder="Telefon" bind:value={phoneNumber} />
        </label>
        <br />
        <input type="submit" value="Rejestruj!" />
    </form>
</main>

<style>
</style>
