<script>
    import { onMount } from "svelte";
    import { page } from "$app/stores";
    import { getForRole, postOrPutForRole } from "$lib/stores/Permissions";
    import { getAuthenticated } from "$lib/stores/Authentication";
    import BaseEditableForm from "$lib/components/base/BaseEditableForm.svelte";

    let baseRolePermissions = [];
    let rolePermissions = [];
    let isEditing = false;

    onMount(async () => {
        baseRolePermissions = await getForRole($page.params.slug);
        rolePermissions = JSON.parse(JSON.stringify(baseRolePermissions));
    });

    async function onSubmitHandler() {
        if (!checkIfRolePermissionsChanged()) return;

        const dto = {
            roleId: $page.params.slug,
            permissions: rolePermissions,
        };

        const permissionsResult = await postOrPutForRole(
            $page.params.slug,
            dto
        );

        if (permissionsResult === undefined) return;

        baseRolePermissions = JSON.parse(JSON.stringify(rolePermissions));

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
    <table class="w-[98%] p-[1%] border-2 border-black">
        <tr class="border-b-2 border-black">
            <th class="border-r-2 border-black">Zasób</th>
            <th class="border-r-2 border-black">Dodawanie</th>
            <th class="border-r-2 border-black">Odczytywanie</th>
            <th class="border-r-2 border-black">Aktualizowanie</th>
            <th>Usuwanie</th>
        </tr>

        {#each rolePermissions as permission, i}
            <tr>
                <td class="font-semibold border-r-2 border-black"
                    >{permission.source}</td
                >
                <td class="border-r-2 border-black">
                    <button
                        type="button"
                        on:click={() => changePropertyValue(i, "create")}
                        disabled={!isEditing}
                    >
                        {permission.create ? "√" : "X"}
                    </button>
                </td>
                <td class="border-r-2 border-black">
                    <button
                        type="button"
                        on:click={() => changePropertyValue(i, "read")}
                        disabled={!isEditing}
                    >
                        {rolePermissions[i].read ? "√" : "X"}
                    </button>
                </td>
                <td class="border-r-2 border-black">
                    <button
                        type="button"
                        on:click={() => changePropertyValue(i, "update")}
                        disabled={!isEditing}
                    >
                        {rolePermissions[i].update ? "√" : "X"}
                    </button>
                </td>
                <td class="border-r-2 border-black">
                    <button
                        type="button"
                        on:click={() => changePropertyValue(i, "delete")}
                        disabled={!isEditing}
                    >
                        {rolePermissions[i].delete ? "√" : "X"}
                    </button>
                </td>
            </tr>
        {/each}
    </table>
</BaseEditableForm>
