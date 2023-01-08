<script>
    import formNameStore from "$lib/stores/GlobalStore.js";
    import { page } from "$app/stores";
    import { goto } from "$app/navigation";

    function closeHandler() {
        goto("/roles");
    }
</script>

<br />

<div>
    <!--kontener dla dużych ekranów wyświetlający się po lewej a dla mniejszych jako menu rozwijane?-->
    <a href="/roles/{$page.params.slug}/details">Szczegóły</a>
</div>
<div>
    <b>Rola {$formNameStore}</b>
    <button on:click|preventDefault={closeHandler}>Zamknij</button>

    <br />
    <br />

    <slot />
</div>
