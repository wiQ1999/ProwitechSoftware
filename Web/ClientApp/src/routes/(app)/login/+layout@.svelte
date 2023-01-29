<script>
    import { Modals, closeModal } from "svelte-modals";
</script>

<main class="pt-[2%] pb-[4%]">
    <Modals>
        <div slot="backdrop" class="backdrop" on:click={closeModal} />
    </Modals>

    <slot />
</main>
