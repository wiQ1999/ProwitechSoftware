<script>
  import { Modals, closeModal } from "svelte-modals";
</script>

<header>
  <nav>
    <a href="/">Home</a>
    <a href="/about">About</a>
    <a href="/settings">Settings</a>
  </nav>
</header>
<main>
  <Modals>
    <div slot="backdrop" class="backdrop" on:click={closeModal} />
  </Modals>
  <slot>
    <!-- elementy strony -->
  </slot>
</main>

<style>
  :global(body) {
    background-color: white;
    color: black;
  }
  .backdrop {
    position: fixed;
    top: 0;
    bottom: 0;
    right: 0;
    left: 0;
    background: rgba(0, 0, 0, 0.5);
  }
</style>
