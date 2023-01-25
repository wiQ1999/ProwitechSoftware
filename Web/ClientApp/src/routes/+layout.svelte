<script>
  import { Modals, closeModal } from "svelte-modals";
  import { onMount } from "svelte";
  import "../app.css";
  import { getToken, hasCreatePermissionFor, clearToken } from "$lib/js-lib/authManager";
  import { goto } from "$app/navigation";
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
      tasksHref = "/tasks";
    } else {
      tasksHref = `/tasks/${userId}/performer_tasks`;
    }
    if (hasCreatePermissionFor("inspectionProtocols")) {
      protocolsHref = "/protocols";
    } else {
      protocolsHref = `/protocols/${userId}/performer_protocols`;
    }
    navbarVisibility = true;
  });


  function logoutHandler() {
    clearToken();
    goto(`/login`);

  }
</script>

<header class="flex flex-col">
  {#if navbarVisibility}
    <nav
      class="bg-white py-[4%] my-2 mx-4 rounded-lg justify-center flex content-center xl:gap-[50px] lg:gap-[30px] sm:gap-[15px] gap-[10px] border-4 border-[#007acc] shadow-lg"
    >
      <a
        href="/"
        data-item="Home"
        class="decoration-none uppercase xl:text-2xl md:text-xl text-base text-[#8f8f8f] font-semibold xl:tracking-widest md:tracking-wide tracking-tight relative
    before:absolute before:content-[attr(data-item)] before:text-[#007acc] before:top-0 before:left-0 before:bottom-0 before:w-0 before:overflow-hidden before:hover:w-[100%]"
        >Home</a
      >
      {#if usersVisibility}
        <a
          href="/users"
          data-item="Użytkownicy"
          class="decoration-none uppercase xl:text-2xl md:text-xl text-[#8f8f8f] font-semibold xl:tracking-widest md:tracking-wide tracking-tight relative
    before:absolute before:content-[attr(data-item)] before:text-[#007acc] before:top-0 before:left-0 before:bottom-0 before:w-0 before:overflow-hidden before:hover:w-[100%]"
          >Użytkownicy</a
        >
      {/if}
      {#if rolesVisibility}
        <a
          href="/roles"
          data-item="Role"
          class="decoration-none uppercase xl:text-2xl md:text-xl text-[#8f8f8f] font-semibold xl:tracking-widest md:tracking-wide tracking-tight relative
    before:absolute before:content-[attr(data-item)] before:text-[#007acc] before:top-0 before:left-0 before:bottom-0 before:w-0 before:overflow-hidden before:hover:w-[100%]"
          >Role</a
        >
      {/if}
      {#if buildingsVisibility}
        <a
          href="/buildings/getAll"
          data-item="Budynki"
          class="decoration-none uppercase xl:text-2xl md:text-xl md:text-md text-[#8f8f8f] font-semibold xl:tracking-widest md:tracking-wide tracking-tight relative
    before:absolute before:content-[attr(data-item)] before:text-[#007acc] before:top-0 before:left-0 before:bottom-0 before:w-0 before:overflow-hidden before:hover:w-[100%]"
          >Budynki</a
        >
      {/if}
      {#if propertyManagersVisibility}
        <a
          href="/propertyManagers/getAll"
          data-item="Zarządcy"
          class="decoration-none uppercase xl:text-2xl md:text-xl text-[#8f8f8f] font-semibold xl:tracking-widest md:tracking-wide tracking-tight relative
    before:absolute before:content-[attr(data-item)] before:text-[#007acc] before:top-0 before:left-0 before:bottom-0 before:w-0 before:overflow-hidden before:hover:w-[100%]"
          >Zarządcy</a
        >
      {/if}
      <a
        href={tasksHref}
        data-item="Zadania"
        class="decoration-none uppercase xl:text-2xl md:text-xl text-[#8f8f8f] font-semibold xl:tracking-widest md:tracking-wide tracking-tight relative
    before:absolute before:content-[attr(data-item)] before:text-[#007acc] before:top-0 before:left-0 before:bottom-0 before:w-0 before:overflow-hidden before:hover:w-[100%]"
        >Zadania</a
      >

      <a
        href={protocolsHref}
        data-item="Protokoły"
        class="decoration-none uppercase xl:text-2xl md:text-xl text-[#8f8f8f] font-semibold xl:tracking-widest md:tracking-wide tracking-tight relative
    before:absolute before:content-[attr(data-item)] before:text-[#007acc] before:top-0 before:left-0 before:bottom-0 before:w-0 before:overflow-hidden before:hover:w-[100%]"
        >Protokoły</a
      >
      <div class="absolute right-[5%] font-semibold">
        Witaj, username <br />
      <button class="font-normal border-black border-2 p-2" on:click={logoutHandler}>
        Wyloguj
      </button>
    </div>
    
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
  class="bg-[#007acc] lg:text-lg md:text-base text-sm text-white text-center
             border-t-4 border-red-500
             fixed
             w-[100%]
             bottom-0
             p-1"
>
  Strona stworzona przez studentów WSB Poznań - Hannę Filipowską, Wiktora
  Szczeszek oraz Huberta Nowaka. ©
</footer>
