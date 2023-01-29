<script>
    import { onMount } from "svelte";
    import { page } from "$app/stores";
    import { getForRole, postOrPutForRole } from "$lib/stores/Permissions";
    import BaseEditableForm from "$lib/components/base/BaseEditableForm.svelte";

    let baseRolePermissions = [];
    let rolePermissions = [];
    let isEditing = false;

    onMount(async () => {
        baseRolePermissions = await getForRole($page.params.slug);
        rolePermissions = JSON.parse(JSON.stringify(baseRolePermissions));
    });

    async function onSubmitHandler() {
        if (checkIfRolePermissionsChanged()) {
            const dto = {
                roleId: $page.params.slug,
                permissions: rolePermissions,
            };
            await postOrPutForRole($page.params.slug, dto);
            baseRolePermissions = JSON.parse(JSON.stringify(rolePermissions));
        }

        isEditing = false;
    }

    function checkIfRolePermissionsChanged() {
        for (let i = 0; i < rolePermissions.length; i++) {
            const rolePerm = rolePermissions[i];
            const baseRolePerm = baseRolePermissions[i];

            if (
                rolePerm.create !== baseRolePerm.create ||
                rolePerm.read !== baseRolePerm.read ||
                rolePerm.update !== baseRolePerm.update ||
                rolePerm.delete !== baseRolePerm.delete
            ) {
                return true;
            }
        }

        return false;
    }

    function onEditingStopHandler() {
        rolePermissions = JSON.parse(JSON.stringify(baseRolePermissions));
    }

    function changePropertyValue(index, property) {
        const permission = rolePermissions[index];
        const propertyValue = Reflect.get(permission, property);

        if (propertyValue) {
            Reflect.set(rolePermissions[index], property, false);
        } else {
            Reflect.set(rolePermissions[index], property, true);
        }

        rolePermissions[index] = rolePermissions[index];
    }
</script>

<BaseEditableForm
    bind:isEditing
    formName="Uprawnienia roli"
    {onSubmitHandler}
    {onEditingStopHandler}
>
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
                        on:click={() => changePropertyValue(i, "create")}
                        disabled={!isEditing}
                    >
                        {permission.create ? "TAK" : "NIE"}
                    </button>
                </td>
                <td>
                    <button
                        type="button"
                        on:click={() => changePropertyValue(i, "read")}
                        disabled={!isEditing}
                    >
                        {rolePermissions[i].read ? "TAK" : "NIE"}
                    </button>
                </td>
                <td>
                    <button
                        type="button"
                        on:click={() => changePropertyValue(i, "update")}
                        disabled={!isEditing}
                    >
                        {rolePermissions[i].update ? "TAK" : "NIE"}
                    </button>
                </td>
                <td>
                    <button
                        type="button"
                        on:click={() => changePropertyValue(i, "delete")}
                        disabled={!isEditing}
                    >
                        {rolePermissions[i].delete ? "TAK" : "NIE"}
                    </button>
                </td>
            </tr>
        {/each}
    </table>
</BaseEditableForm>
