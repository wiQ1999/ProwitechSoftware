<header>
  
  <nav>
    <a href="/" data-item="Home">Home</a>
    <a href="/about" data-item="O nas">O nas</a>
    <a href="/sverdle" data-item="Ustawienia">Ustawienia</a>
    <a href="/Building/getAll" data-item="Budynki">Budynki</a>
    <a href="/PropertyManager/getAll" data-item="Zarządcy">Zarządcy</a>
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
    font-family: Helvetica, sans-serif;
  }

  main{
    padding:5% 5% 0 0;
  }

  nav{
    background-color: white;
    padding: 5% 0;
    margin: 1% 2%;
    border-radius: 8px;
    display: flex;
    justify-content: center;
    gap: 50px;
    box-shadow: 0 3px 5px 0 rgba(0,0,0,0.6), 
                inset 0 -3px 8px 0 rgba(0,0,0,0.3);
  }

  nav a{
    text-decoration: none;
    text-transform: uppercase;
    font-size: 20px;
    font-weight: 500;
    letter-spacing: 2px;
    position: relative;
    color: #8f8f8f;
  }

  nav a::before {
    position: absolute;
    content: attr(data-item);
    color: #007acc;
    top:0;
    left:0;
    bottom:0;
    width:0;
    overflow: hidden;
    transition: 0.3s all ease-in-out;
  }

  nav a:hover::before {
    width: 100%;
  }
</style>

