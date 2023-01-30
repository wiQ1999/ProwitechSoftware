<script>
    import formNameStore from "$lib/stores/GlobalStore.js";
    import { page } from "$app/stores";
    import { goto } from "$app/navigation";

    function closeHandler() {
        goto("/users");
    }

    function openMenu() {
        let button = document.getElementById('openableButton');
        if(!button.hidden) button.hidden = true;
        else button.hidden = false;
        }


</script>

<div class="absolute ml-[3%] mr-[78%] w-[20%] text-left">
    <button on:mouseenter={openMenu} on:mouseleave={openMenu} class="bg-blue-500 p-2 text-2xl"><i class="fa fa-align-justify"></i></button>
    <div on:mouseenter={openMenu} on:mouseleave={openMenu} id="openableButton" hidden class="text-center bg-blue-500"> 
        <!--kontener dla dużych ekranów wyświetlający się po lewej a dla mniejszych jako menu rozwijane?-->
        <a href="/users/{$page.params.slug}/details">Szczegóły</a>
        <br />
        <a href="/users/{$page.params.slug}/password-change">Zmiana hasła</a>
        <br />
        <a href="/users/{$page.params.slug}/permissions">Uprawnienia</a>
        <br />
        <b>Użytkownik {$formNameStore}</b>
        <br />
        <button on:click|preventDefault={closeHandler} class="bg-red-500 w-[100%]">Zamknij</button>
    </div>
</div>



<div>
    <br />
    <br />

    <slot />
</div>
