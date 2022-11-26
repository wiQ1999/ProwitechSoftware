<header>
  
  <nav>
    <a href="/">Home</a>
    <a href="/about">O nas</a>
    <a href="/sverdle">Ustawienia</a>
    <a href="/Building/getAll">Budynki</a>
    <a href="/PropertyManager/getAll">Zarządcy</a>
  </nav>

</header>
<main>
  <slot>
    <!-- elementy strony -->
  </slot>
</main>

<style>
  
  :global(body) {
    background-color: white;
    color: black;
    margin: 0;
  }

  main{
    padding:5% 5% 0 5%;
  }

  nav{
    text-align: center;
    background-color: rgba(0,0,0,0.5);
    padding: 5% 0;
  }

  a{
    text-decoration: none;
    color: black;
    padding: 3% 5%;
    margin: 0 1%;
    border: 2px solid black;
    background-color: #b4e8a5;
    border-radius: 20px;
    width:15%;
    
  }

  a:hover{
    background-color: #91e07b;
  }

</style>

