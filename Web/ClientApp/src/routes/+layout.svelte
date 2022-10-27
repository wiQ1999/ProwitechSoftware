<header>
  <nav>
    <a href="/">Home</a>
    <a href="/about">About</a>
    <a href="/settings">Settings</a>
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
</style>
