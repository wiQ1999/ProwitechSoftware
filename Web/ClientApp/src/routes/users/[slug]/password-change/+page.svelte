<script>
    import { onMount } from "svelte";
    import { page } from "$app/stores";
    import { getUserById, putUser } from "$lib/stores/Users";
    import { getAllRoles } from "$lib/stores/Roles";
    import { goto } from "$app/navigation";

    function submitHandler() {
        alert("SUBMIT");
    }
</script>

<br />
<br />

<form on:submit={submitHandler}>
    <button type="submit">Zapisz</button>
    <br />
    <label for="password">Hasło</label>
    <input type="password" />
    <br />
    <label for="repeat">Powtórz hasło</label>
    <input type="password" />
</form>
