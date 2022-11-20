<script>
    import { onMount } from "svelte";
    import { goto } from "$app/navigation";
    import {
        getAllUsers,
        getUserById,
        deleteUser as deleteUserById,
    } from "../../stores/Users";

    let users = [];
    onMount(async () => {
        users = await getAllUsers();
    });

    function goToAddRow(id) {
        goto(`/users/${id}`);
    }

    function goToEditRow(id) {
        goto(`/users/${id}`);
    }

    async function deleteRow(user) {
        //await deleteUser(user.id);
        alert("Nie zaimplementowano");
    }
</script>

<!-- <button on:click={() => goToAddRow("1")}>Dodaj nowego użytkownika</button> -->

<table>
    <tr>
        <th>Imię</th>
        <th>Nazwisko</th>
        <th>Email</th>
        <th>Rola</th>
    </tr>
    {#each users as user}
        <tr on:dblclick={goToEditRow(user.id)}>
            <td>{user.firstName ?? ""}</td>
            <td>{user.lastName ?? ""}</td>
            <td>{user.email ?? ""}</td>
            <td>{user.role.name ?? ""}</td>
            <td>
                <button on:click={getUserById(user.id)}> Szczegóły </button>
            </td>
            <td>
                <button on:click{deleteRow(user)}> Usuń </button>
            </td>
        </tr>
    {/each}
</table>

<style>
    td {
        border-bottom: 2px solid;
    }
</style>
