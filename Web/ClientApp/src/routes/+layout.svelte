<header>
  <nav>
  <a href="/">Home</a>
    <a href="/about">O nas</a>
    <a href="/settings">Ustawienia</a>
    <a href="/Building">Budynki</a>
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
  }

  header, main{
    padding-top:4%;
  }

  nav{
    text-align: center;
  }

  a{
    text-decoration: none;
    color: black;
    padding: 3% 5%;
    margin: 0 1%;
    border: 2px solid black;
    background-color: #b4e8a5;
    border-radius: 20px;
    
  }

  a:hover{
    background-color: #91e07b;
  }
</style>
