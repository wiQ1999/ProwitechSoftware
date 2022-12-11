<script>
    import formNameStore from "$lib/stores/GlobalStore.js";
    import { page } from "$app/stores";
    import { goto } from "$app/navigation";

    function closeHandler() {
        goto("/users");
    }
</script>

<br />

<div>
    <!--kontener dla dużych ekranów wyświetlający się po lewej a dla mniejszych jako menu rozwijane?-->
    <a href="/users/{$page.params.slug}/details">Szczegóły</a>
    <br />
    <a href="/users/{$page.params.slug}/password-change">Zmiana hasła</a>
</div>
<div>
    <b>Użytkownik {$formNameStore}</b>
    <button on:click|preventDefault={closeHandler}>Zamknij</button>

    <br />
    <br />

    <slot />
</div>
