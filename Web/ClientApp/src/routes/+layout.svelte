<script>
  import { Modals, closeModal } from "svelte-modals";
  import "../app.css";
  //TODO ZMIENIAJ HREF W NAVBARZE W ZALEŻNOŚCI OD TEGO, KTO ZALOGOWANY
  let personLoggedInId = "030B7529-173C-41A8-953D-75BA46B7FC21";
</script>

<header class="flex flex-col">
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

    <a
      href="/users"
      data-item="Użytkownicy"
      class="decoration-none uppercase text-2xl text-[#8f8f8f] font-semibold tracking-widest relative
    before:absolute before:content-[attr(data-item)] before:text-[#007acc] before:top-0 before:left-0 before:bottom-0 before:w-0 before:overflow-hidden before:hover:w-[100%]"
      >Użytkownicy</a
    >

    <a
      href="/roles"
      data-item="Role"
      class="decoration-none uppercase text-2xl text-[#8f8f8f] font-semibold tracking-widest relative
    before:absolute before:content-[attr(data-item)] before:text-[#007acc] before:top-0 before:left-0 before:bottom-0 before:w-0 before:overflow-hidden before:hover:w-[100%]"
      >Role</a
    >

    <a
      href="/buildings/getAll"
      data-item="Budynki"
      class="decoration-none uppercase text-2xl md:text-md text-[#8f8f8f] font-semibold tracking-widest relative
    before:absolute before:content-[attr(data-item)] before:text-[#007acc] before:top-0 before:left-0 before:bottom-0 before:w-0 before:overflow-hidden before:hover:w-[100%]"
      >Budynki</a
    >

    <a
      href="/propertyManagers/getAll"
      data-item="Zarządcy"
      class="decoration-none uppercase text-2xl text-[#8f8f8f] font-semibold tracking-widest relative
    before:absolute before:content-[attr(data-item)] before:text-[#007acc] before:top-0 before:left-0 before:bottom-0 before:w-0 before:overflow-hidden before:hover:w-[100%]"
      >Zarządcy</a
    >

    <a
      href="/tasks/getAll"
      data-item="Wszystkie zadania"
      class="decoration-none uppercase text-2xl text-[#8f8f8f] font-semibold tracking-widest relative
    before:absolute before:content-[attr(data-item)] before:text-[#007acc] before:top-0 before:left-0 before:bottom-0 before:w-0 before:overflow-hidden before:hover:w-[100%]"
      >Wszystkie zadania</a
    >
    <!-- TODO -->
    <!-- AHREF = TASKS/[PERFORMED_ID]/PERFORMER_TASKS -->
    <a
      href="/tasks/{personLoggedInId}/performer_tasks"
      data-item="Moje zadania"
      class="decoration-none uppercase text-2xl text-[#8f8f8f] font-semibold tracking-widest relative
    before:absolute before:content-[attr(data-item)] before:text-[#007acc] before:top-0 before:left-0 before:bottom-0 before:w-0 before:overflow-hidden before:hover:w-[100%]"
      >Moje zadania</a
    >
  </nav>
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
