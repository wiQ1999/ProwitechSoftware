<script>
    import formNameStore from "$lib/stores/GlobalStore.js";
    import { page } from "$app/stores";
    import { goto } from "$app/navigation";

    function closeHandler() {
        goto("/roles");
    }

    function openMenu() {
        let button = document.getElementById('openableButton');
        if(!button.hidden) button.hidden = true;
        else button.hidden = false;
        }

</script>

<br />

<div class="absolute ml-[3%] mr-[78%] w-[20%] text-left">
    <button on:mouseenter={openMenu} on:mouseleave={openMenu} class="bg-blue-500 p-2 text-2xl"><i class="fa fa-align-justify"></i></button>
    <!--kontener dla dużych ekranów wyświetlający się po lewej a dla mniejszych jako menu rozwijane?-->
    <div on:mouseenter={openMenu} on:mouseleave={openMenu} id="openableButton" hidden class="relative text-center bg-blue-500"> 
        <a href="/roles/{$page.params.slug}/details">Szczegóły</a>
        <br />
        Rola: <b>{$formNameStore}</b>
        <br />
        <button on:click|preventDefault={closeHandler}>Zamknij</button>
    </div>
</div>
<div>
    <slot />
</div>
