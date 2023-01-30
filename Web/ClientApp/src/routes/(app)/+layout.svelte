<script>
  import { Modals, closeModal } from "svelte-modals";
  import { onMount } from "svelte";
  import {
    getToken,
    hasCreatePermissionFor,
    clearToken,
  } from "$lib/js-lib/authManager";

  let usersVisibility = false;
  let rolesVisibility = false;
  let buildingsVisibility = false;
  let propertyManagersVisibility = false;
  let tasksHref;
  let protocolsHref;
  let token;

  onMount(() => {
    token = getToken();

    rolesVisibility = hasCreatePermissionFor("roles");
    usersVisibility = hasCreatePermissionFor("users");
    buildingsVisibility = hasCreatePermissionFor("buildings");
    propertyManagersVisibility = hasCreatePermissionFor("propertyManagers");

    if (hasCreatePermissionFor("inspectionTasks")) {
      tasksHref = "/tasks";
    } else {
      tasksHref = `/tasks/${token?.id}/performer_tasks`;
    }

    if (hasCreatePermissionFor("inspectionProtocols")) {
      protocolsHref = "/protocols";
    } else {
      protocolsHref = `/protocols/${token?.id}/performer_protocols`;
    }
  });

  function logoutHandler() {
    clearToken();
    window.location.href = "/login";
  }

  function openMenu() {
    let button = document.getElementById("openableButtonNavbar");
    if (!button.hidden) button.hidden = true;
    else button.hidden = false;
  }
</script>

<header class="flex flex-col">
  <nav
    class="bg-white py-[4%] my-2 mx-4 rounded-lg justify-center flex content-center 2xl:gap-[50px] xl:gap-[30px] md:gap-[15px] gap-[10px] border-4 border-[#007acc] shadow-lg"
  >
    <a
      href="/"
      data-item="Home"
      class="decoration-none uppercase xl:text-2xl md:text-xl text-base text-[#8f8f8f] font-semibold xl:tracking-widest md:tracking-wide tracking-tight relative before:absolute before:content-[attr(data-item)] before:text-[#007acc] before:top-0 before:left-0 before:bottom-0 before:w-0 before:overflow-hidden before:hover:w-[100%]"
      >Home
    </a>

    {#if rolesVisibility}
      <a
        href="/roles"
        data-item="Role"
        class="decoration-none uppercase xl:text-2xl md:text-xl text-[#8f8f8f] font-semibold xl:tracking-widest md:tracking-wide tracking-tight relative before:absolute before:content-[attr(data-item)] before:text-[#007acc] before:top-0 before:left-0 before:bottom-0 before:w-0 before:overflow-hidden before:hover:w-[100%]"
        >Role
      </a>
    {/if}

    {#if usersVisibility}
      <a
        href="/users"
        data-item="Użytkownicy"
        class="decoration-none uppercase xl:text-2xl md:text-xl text-[#8f8f8f] font-semibold xl:tracking-widest md:tracking-wide tracking-tight relative before:absolute before:content-[attr(data-item)] before:text-[#007acc] before:top-0 before:left-0 before:bottom-0 before:w-0 before:overflow-hidden before:hover:w-[100%]"
        >Użytkownicy
      </a>
    {/if}

    {#if buildingsVisibility}
      <a
        href="/buildings/getAll"
        data-item="Budynki"
        class="decoration-none uppercase xl:text-2xl md:text-xl md:text-md text-[#8f8f8f] font-semibold xl:tracking-widest md:tracking-wide tracking-tight relative before:absolute before:content-[attr(data-item)] before:text-[#007acc] before:top-0 before:left-0 before:bottom-0 before:w-0 before:overflow-hidden before:hover:w-[100%]"
        >Budynki
      </a>
    {/if}

    {#if propertyManagersVisibility}
      <a
        href="/propertyManagers/getAll"
        data-item="Zarządcy"
        class="decoration-none uppercase xl:text-2xl md:text-xl text-[#8f8f8f] font-semibold xl:tracking-widest md:tracking-wide tracking-tight relative before:absolute before:content-[attr(data-item)] before:text-[#007acc] before:top-0 before:left-0 before:bottom-0 before:w-0 before:overflow-hidden before:hover:w-[100%]"
        >Zarządcy
      </a>
    {/if}

    <a
      href={tasksHref}
      data-item="Zadania"
      class="decoration-none uppercase xl:text-2xl md:text-xl text-[#8f8f8f] font-semibold xl:tracking-widest md:tracking-wide tracking-tight relative before:absolute before:content-[attr(data-item)] before:text-[#007acc] before:top-0 before:left-0 before:bottom-0 before:w-0 before:overflow-hidden before:hover:w-[100%]"
      >Zadania
    </a>

    <a
      href={protocolsHref}
      data-item="Protokoły"
      class="decoration-none uppercase xl:text-2xl md:text-xl text-[#8f8f8f] font-semibold xl:tracking-widest md:tracking-wide tracking-tight relative before:absolute before:content-[attr(data-item)] before:text-[#007acc] before:top-0 before:left-0 before:bottom-0 before:w-0 before:overflow-hidden before:hover:w-[100%]"
      >Protokoły
    </a>

    <div class="font-semibold lg:ml-3 ml-1 w-[10%] text-right 2xl:hidden">
      <button class="font-normal lg:p-3 p-1 bg-gray-300" on:click={openMenu}>
        <i class="fa fa-align-justify lg:w-[100%]" />
      </button>
      <div
        on:mouseleave={openMenu}
        id="openableButtonNavbar"
        hidden
        class="relative text-center bg-gray-300 lg:p-2 p-1"
      >
        Witaj, {token?.login ?? ""}<br />
        <button
          class="font-bold hover:bg-gray-400 w-[100%]"
          on:click|preventDefault={logoutHandler}>Wyloguj</button
        >
      </div>
    </div>

    <div class="bg-gray-300 p-2 absolute right-[3%] hidden 2xl:block">
      Witaj, {token?.login ?? ""}<br />
      <button
        class="font-bold hover:bg-gray-400 w-[100%]"
        on:click|preventDefault={logoutHandler}>Wyloguj</button
      >
    </div>
  </nav>
</header>

<main class="pt-[1%] pb-[4%]">
  <Modals>
    <div slot="backdrop" class="backdrop" on:click={closeModal} />
  </Modals>

  <slot />
</main>
