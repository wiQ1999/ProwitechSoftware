<script>
    import { onMount } from "svelte";
    import { getAllUsers } from "../../stores/Users";

    let roles = [];

    onMount(async () => {
        roles = await getAllUsers();
    });
</script>

<h1>TEST</h1>
{#each roles as role}
    <p>{role.firstName}</p>
{/each}
