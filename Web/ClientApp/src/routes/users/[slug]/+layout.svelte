<script>
    import { page } from "$app/stores";
</script>

<br />

<div>
    <!--kontener dla dużych ekranów wyświetlający się po lewej a dla mniejszych jako menu rozwijane?-->
    <a href="/users/{$page.params.slug}/details">Szczegóły</a>
    <br />
    <a href="/users/{$page.params.slug}/password-change">Zmiana hasła</a>
</div>
<div>
    <slot />
</div>
