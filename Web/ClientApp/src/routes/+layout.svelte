<script>
  import { Modals, closeModal } from "svelte-modals";
  import { onMount } from "svelte";
  import "../app.css";
  import { getToken, hasCreatePermissionFor } from "$lib/js-lib/authManager";
  let usersVisibility = false;
  let rolesVisibility = false;
  let buildingsVisibility = false;
  let propertyManagersVisibility = false;
  let getAllProtocolsHref = false;
  let getAllHref = false;
  let navbarVisibility = false;
  let tasksHref;
  let protocolsHref;
  onMount(() => {
    let userData = getToken();
    let userId = userData.id;
    console.log(userData);
    usersVisibility = hasCreatePermissionFor("users");
    rolesVisibility = hasCreatePermissionFor("roles");
    buildingsVisibility = hasCreatePermissionFor("buildings");
    propertyManagersVisibility = hasCreatePermissionFor("propertyManagers");
    if (hasCreatePermissionFor("inspectionTasks")) {
      tasksHref = "/tasks/getAll";
    } else {
      tasksHref = `/tasks/${userId}/performer_tasks`;
    }
    if (hasCreatePermissionFor("inspectionProtocols")) {
      protocolsHref = "/protocols/getAll";
    } else {
      protocolsHref = `/protocols/${userId}/performer_protocols`;
    }
    navbarVisibility = true;
  });
</script>

<header class="flex flex-col">
  {#if navbarVisibility}
    <nav
      class="bg-white py-[5%] my-2 mx-4 rounded-lg justify-center flex content-center gap-[50px] border-4 border-[#007acc] shadow-lg"
    >
      <a
        href="/"
        data-item="Home"
        class="decoration-none uppercase text-2xl text-[#8f8f8f] font-semibold tracking-widest relative
    before:absolute before:content-[attr(data-item)] before:text-[#007acc] before:top-0 before:left-0 before:bottom-0 before:w-0 before:overflow-hidden before:hover:w-[100%]"
        >Home</a
      >

      <a
        href="/about"
        data-item="Autorzy"
        class="decoration-none uppercase text-2xl text-[#8f8f8f] font-semibold tracking-widest relative
    before:absolute before:content-[attr(data-item)] before:text-[#007acc] before:top-0 before:left-0 before:bottom-0 before:w-0 before:overflow-hidden before:hover:w-[100%]"
        >Autorzy</a
      >
      {#if usersVisibility}
        <a
          href="/users"
          data-item="Użytkownicy"
          class="decoration-none uppercase text-2xl text-[#8f8f8f] font-semibold tracking-widest relative
    before:absolute before:content-[attr(data-item)] before:text-[#007acc] before:top-0 before:left-0 before:bottom-0 before:w-0 before:overflow-hidden before:hover:w-[100%]"
          >Użytkownicy</a
        >
      {/if}
      {#if rolesVisibility}
        <a
          href="/roles"
          data-item="Role"
          class="decoration-none uppercase text-2xl text-[#8f8f8f] font-semibold tracking-widest relative
    before:absolute before:content-[attr(data-item)] before:text-[#007acc] before:top-0 before:left-0 before:bottom-0 before:w-0 before:overflow-hidden before:hover:w-[100%]"
          >Role</a
        >
      {/if}
      {#if buildingsVisibility}
        <a
          href="/buildings/getAll"
          data-item="Budynki"
          class="decoration-none uppercase text-2xl md:text-md text-[#8f8f8f] font-semibold tracking-widest relative
    before:absolute before:content-[attr(data-item)] before:text-[#007acc] before:top-0 before:left-0 before:bottom-0 before:w-0 before:overflow-hidden before:hover:w-[100%]"
          >Budynki</a
        >
      {/if}
      {#if propertyManagersVisibility}
        <a
          href="/propertyManagers/getAll"
          data-item="Zarządcy"
          class="decoration-none uppercase text-2xl text-[#8f8f8f] font-semibold tracking-widest relative
    before:absolute before:content-[attr(data-item)] before:text-[#007acc] before:top-0 before:left-0 before:bottom-0 before:w-0 before:overflow-hidden before:hover:w-[100%]"
          >Zarządcy</a
        >
      {/if}
      <a
        href={tasksHref}
        data-item="Zadania"
        class="decoration-none uppercase text-2xl text-[#8f8f8f] font-semibold tracking-widest relative
    before:absolute before:content-[attr(data-item)] before:text-[#007acc] before:top-0 before:left-0 before:bottom-0 before:w-0 before:overflow-hidden before:hover:w-[100%]"
        >Zadania</a
      >

      <a
        href={protocolsHref}
        data-item="Protokoły"
        class="decoration-none uppercase text-2xl text-[#8f8f8f] font-semibold tracking-widest relative
    before:absolute before:content-[attr(data-item)] before:text-[#007acc] before:top-0 before:left-0 before:bottom-0 before:w-0 before:overflow-hidden before:hover:w-[100%]"
        >Protokoły</a
      >
    </nav>
  {/if}
</header>

<main class="pt-[2%] pb-[4%]">
  <Modals>
    <div slot="backdrop" class="backdrop" on:click={closeModal} />
  </Modals>

  <slot>
    <!-- elementy strony -->
  </slot>
</main>

<footer
  class="bg-[#007acc] text-2xl text-white text-center
             border-t-4 border-red-500
             fixed
             w-[100%]
             bottom-0
             p-2"
>
  Strona stworzona przez studentów WSB Poznań - Hannę Filipowską, Wiktora
  Szczeszek oraz Huberta Nowaka. ©
</footer>
