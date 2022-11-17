<script>
    import { onMount } from "svelte";
    import { getAllUsers } from "../../stores/Users";

    let users = [];
    onMount(async () => {
        users = await getAllUsers();
    });

    function edit(id) {
        window.location.href = `/roles/details/${id}`;
    }

    function deletePopUp(user) {
        console.log(user);
    }
</script>

<br />

<table>
    <tr>
        <th>Imię</th>
        <th>Nazwisko</th>
        <th>Email</th>
        <th>Rola</th>
    </tr>
    {#each users as user}
        <tr on:dblclick|preventDefault={() => edit(user.id)}>
            <td>{user.firstName ?? ""}</td>
            <td>{user.lastName ?? ""}</td>
            <td>{user.email ?? ""}</td>
            <td>{user.role.name ?? ""}</td>
            <td>
                <button on:click|preventDefault={() => edit(user.id)}>
                    Szczegóły
                </button>
            </td>
            <td>
                <button on:click|preventDefault={() => deletePopUp(user)}>
                    Usuń
                </button>
            </td>
        </tr>
    {/each}
</table>

<style>
    td {
        border-bottom: 2px solid;
    }
</style>
