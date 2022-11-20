<script>
    import { onMount } from "svelte";
    import {
        postRole,
        getAllRoles,
        putRole,
        deleteRole,
    } from "../../stores/Roles";

    let newRoleName;
    let roles = [];
    let roleToUpdate;

    onMount(async () => {
        roles = await getAllRoles();
    });

    async function postRoleAndReload() {
        await postRole(newRoleName);
        window.location.reload();
    }

    async function putRoleAndReload() {
        await putRole(roleToUpdate.id, roleToUpdate);
        window.location.reload();
    }

    async function delteRoleAndReload() {
        await deleteRole(roleToUpdate.id, roleToUpdate);
        window.location.reload();
    }
</script>

<br />

<h3>Dodaj nową rolę</h3>
<form on:submit={() => postRoleAndReload()}>
    <label for={newRoleName}>Nazwa</label>
    <input type="text" bind:value={newRoleName} />
    <button type="submit">Submit</button>
</form>

<br />

<h3>Lista ról</h3>
<form on:submit={() => delteRoleAndReload()}>
    <table>
        <tr>
            <th>Nazwa</th>
        </tr>
        {#each roles as role}
            <tr>
                <td>
                    <input type="text" required bind:value={role.name} />
                </td>
                <td>
                    <!-- <button
                        on:click={() => {
                            roleToUpdate = role;
                        }}
                        type="submit"
                    >
                        Aktualizuj
                    </button> -->
                </td>

                <td>
                    <button
                        on:click={() => {
                            roleToUpdate = role;
                        }}
                        type="submit"
                    >
                        Usuń
                    </button>
                </td>
            </tr>
        {/each}
    </table>
</form>

<style>
    td {
        border-bottom: 2px solid;
    }
</style>
