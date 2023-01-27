<script>
    import { onMount } from "svelte";
    import { page } from "$app/stores";
    import { getForRole, postOrPutForRole } from "$lib/stores/Permissions";
    import { openModal } from "svelte-modals";
    import BasePopUp from "$lib/components/base/BasePopUp.svelte";

    let rolePermissions = [];

    onMount(async () => {
        rolePermissions = await getForRole($page.params.slug);
    });

    async function submitHandler() {
        const dto = { roleId: $page.params.slug, permissions: rolePermissions };
        const result = await postOrPutForRole($page.params.slug, dto);

        if (result) {
            openModal(BasePopUp, {
                title: "Zapisano uprawnienia",
                message: "Zapisywanie uprawnień dla roli powiodło się.",
            });
        }
    }

    function changePreoprtyValue(index, property) {
        const permission = rolePermissions[index];

        if (property === "create") {
            if (permission.create === true)
                rolePermissions[index].create = false;
            else rolePermissions[index].create = true;
        } else if (property === "read") {
            if (permission.read === true) rolePermissions[index].read = false;
            else rolePermissions[index].read = true;
        } else if (property === "update") {
            if (permission.update === true)
                rolePermissions[index].update = false;
            else rolePermissions[index].update = true;
        } else {
            if (permission.delete === true)
                rolePermissions[index].delete = false;
            else rolePermissions[index].delete = true;
        }
    }
</script>

<h1>Uprawnienia roli:</h1>

<form on:submit|preventDefault={submitHandler}>
    <table>
        <tr>
            <th>Zasób</th>
            <th>Dodawanie</th>
            <th>Odczytywanie</th>
            <th>Aktualizowanie</th>
            <th>Usuwanie</th>
        </tr>

        {#each rolePermissions as permission, i}
            <tr>
                <td>{permission.source}</td>
                <td>
                    <button
                        type="button"
                        on:click={() => changePreoprtyValue(i, "create")}
                    >
                        <div>{rolePermissions[i].create ? "TAK" : "NIE"}</div>
                    </button>
                </td>
                <td>
                    <button
                        type="button"
                        on:click={() => changePreoprtyValue(i, "read")}
                    >
                        <div>{rolePermissions[i].read ? "TAK" : "NIE"}</div>
                    </button>
                </td>
                <td>
                    <button
                        type="button"
                        on:click={() => changePreoprtyValue(i, "update")}
                    >
                        <div>{rolePermissions[i].update ? "TAK" : "NIE"}</div>
                    </button>
                </td>
                <td>
                    <button
                        type="button"
                        on:click={() => changePreoprtyValue(i, "delete")}
                    >
                        <div>{rolePermissions[i].delete ? "TAK" : "NIE"}</div>
                    </button>
                </td>
            </tr>
        {/each}
    </table>

    <button type="submit">Zapisz</button>
</form>
