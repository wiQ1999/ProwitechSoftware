<script>
    import { onMount } from "svelte";
    import { page } from "$app/stores";
    import { getRoleById } from "$lib/stores/Roles";

    let role = {
        id: null,
        name: null,
    };

    onMount(async () => {
        role = await getRoleById($page.params.slug);
    });
</script>
