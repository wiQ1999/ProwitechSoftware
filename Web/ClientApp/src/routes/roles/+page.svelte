<script>
    import { onMount } from "svelte";
    import { getAllRoles, postRole } from "../../stores/Roles";

    let newRoleDto = {
        name: "",
    };

    async function onSubmitCreateNewRow() {
        alert(newRoleDto.name);
        await postRole(newRoleDto);
    }

    let roles = [];
    onMount(async () => {
        roles = await getAllRoles();
    });

    async function deleteRow(user) {
        alert("Nie zaimplementowano");
    }
</script>

<form on:submit|preventDefault={onSubmitCreateNewRow}>
    <label for={newRoleDto.name}>Nazwa</label>
    <input type="text" bind:value={newRoleDto.name} />
    <button type="submit">Submit</button>
</form>

<table>
    <tr>
        <th>Nazwa</th>
    </tr>
    {#each roles as role}
        <tr>
            <td>{role.name ?? ""}</td>
            <td>
                <button on:click|preventDefault={() => deleteRow(role)}>
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
