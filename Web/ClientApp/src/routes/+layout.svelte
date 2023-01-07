<script>
  	import "../app.css";
</script>

<header class="flex flex-col">
  <nav class="bg-white py-[5%] my-2 mx-4 rounded-lg justify-center flex content-center gap-[50px] border-4 border-[#007acc] shadow-lg">
    <a href="/" data-item="Home" class="decoration-none uppercase text-2xl text-[#8f8f8f] font-semibold tracking-widest relative
    before:absolute before:content-[attr(data-item)] before:text-[#007acc] before:top-0 before:left-0 before:bottom-0 before:w-0 before:overflow-hidden before:hover:w-[100%]">Home</a>
    <a href="/about" data-item="Autorzy" class="decoration-none uppercase text-2xl text-[#8f8f8f] font-semibold tracking-widest relative
    before:absolute before:content-[attr(data-item)] before:text-[#007acc] before:top-0 before:left-0 before:bottom-0 before:w-0 before:overflow-hidden before:hover:w-[100%]">Autorzy</a>
    <a href="/sverdle" data-item="Ustawienia" class="decoration-none uppercase text-2xl text-[#8f8f8f] font-semibold tracking-widest relative
    before:absolute before:content-[attr(data-item)] before:text-[#007acc] before:top-0 before:left-0 before:bottom-0 before:w-0 before:overflow-hidden before:hover:w-[100%]">Ustawienia</a>
    <a href="/Building/getAll" data-item="Budynki" class="decoration-none uppercase text-2xl text-[#8f8f8f] font-semibold tracking-widest relative
    before:absolute before:content-[attr(data-item)] before:text-[#007acc] before:top-0 before:left-0 before:bottom-0 before:w-0 before:overflow-hidden before:hover:w-[100%]">Budynki</a>
    <a href="/PropertyManager/getAll" data-item="Zarządcy" class="decoration-none uppercase text-2xl text-[#8f8f8f] font-semibold tracking-widest relative
    before:absolute before:content-[attr(data-item)] before:text-[#007acc] before:top-0 before:left-0 before:bottom-0 before:w-0 before:overflow-hidden before:hover:w-[100%]">Zarządcy</a>
  </nav>

</header>

<main class="py-[2%]">
  <slot>
    <!-- elementy strony -->
  </slot>
</main>

<footer class="bg-[#007acc] text-2xl text-white text-center
             border-t-4 border-red-500
             fixed
             w-[100%]
             bottom-0
             p-2">
      Strona stworzona przez studentów WSB Poznań - Hannę Filipowską, Wiktora Szczeszek oraz Huberta Nowaka. ©
</footer>
