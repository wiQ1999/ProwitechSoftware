<script>
    import { onMount } from "svelte";
    import { page } from "$app/stores";
    import { getUserById } from "$lib/stores/Users";
    import {
        getForRole,
        getForUser,
        postOrPutForUser,
    } from "$lib/stores/Permissions";
    import BaseEditableForm from "$lib/components/base/BaseEditableForm.svelte";

    let rolePermissions = [];
    let baseUserPermissions = [];
    let userPermissions = [];
    let isEditing = false;

    onMount(async () => {
        const user = await getUserById($page.params.slug);

        if (user.role) {
            rolePermissions = await getForRole(user.role.id);
        }

        baseUserPermissions = await getForUser($page.params.slug);
        userPermissions = JSON.parse(JSON.stringify(baseUserPermissions));
    });

    async function onSubmitHandler() {
        if (checkIfUserPermissionsChanged()) {
            const dto = {
                userId: $page.params.slug,
                permissions: userPermissions,
            };
            await postOrPutForUser($page.params.slug, dto);
            baseUserPermissions = JSON.parse(JSON.stringify(userPermissions));
        }

        isEditing = false;
    }

    function checkIfUserPermissionsChanged() {
        for (let i = 0; i < userPermissions.length; i++) {
            const userPerm = userPermissions[i];
            const baseUserPerm = baseUserPermissions[i];

            if (
                userPerm.create !== baseUserPerm.create ||
                userPerm.read !== baseUserPerm.read ||
                userPerm.update !== baseUserPerm.update ||
                userPerm.delete !== baseUserPerm.delete
            ) {
                return true;
            }
        }

        return false;
    }

    function onEditingStopHandler() {
        userPermissions = JSON.parse(JSON.stringify(baseUserPermissions));
    }

    function changePropertyValue(index, property) {
        const permission = userPermissions[index];
        const propertyValue = Reflect.get(permission, property);

        if (propertyValue === null) {
            Reflect.set(userPermissions[index], property, true);
        } else if (propertyValue === true) {
            Reflect.set(userPermissions[index], property, false);
        } else {
            Reflect.set(userPermissions[index], property, null);
        }

        userPermissions[index] = userPermissions[index];
    }
</script>

<BaseEditableForm
    bind:isEditing
    formName="Uprawnienia użytkownika"
    {onEditingStopHandler}
    {onSubmitHandler}
>
    <table class="w-[98%] p-[1%] border-2 border-black">
        <tr class="border-b-2 border-black">
            <th class="border-r-2 border-black">Zasób</th>
            <th class="border-r-2 border-black">Dodawanie</th>
            <th class="border-r-2 border-black">Odczytywanie</th>
            <th class="border-r-2 border-black">Aktualizowanie</th>
            <th>Usuwanie</th>
        </tr>

        {#each userPermissions as userPerm, i}
            <tr>
                <td class="font-semibold border-r-2 border-black">{userPerm.source}</td>

                <td class="border-r-2 border-black">
                    <button
                        type="button"
                        on:click={() => changePropertyValue(i, "create")}
                        disabled={!isEditing}
                        
                    >
                        {#if userPerm.create === null}
                            <div class="text-gray-400">
                                {#if rolePermissions.length > 0}
                                    {rolePermissions[i].create ? "√" : "X"}
                                {:else}
                                    BRAK
                                {/if}
                            </div>
                        {:else}
                            <div class="text-black">
                                {userPerm.create ? "√" : "X"}
                            </div>
                        {/if}
                    </button>
                </td>
                <td class="border-r-2 border-black">
                    <button
                        type="button"
                        on:click={() => changePropertyValue(i, "read")}
                        disabled={!isEditing}
                    >
                        {#if userPerm.read === null}
                            <div class="text-gray-400">
                                {#if rolePermissions.length > 0}
                                    {rolePermissions[i].read ? "√" : "X"}
                                {:else}
                                    BRAK
                                {/if}
                            </div>
                        {:else}
                            <div class="text-black">
                                {userPerm.read ? "√" : "X"}
                            </div>
                        {/if}
                    </button>
                </td>
                <td class="border-r-2 border-black">
                    <button
                        type="button"
                        on:click={() => changePropertyValue(i, "update")}
                        disabled={!isEditing}
                    >
                        {#if userPerm.update === null}
                            <div class="text-gray-400">
                                {#if rolePermissions.length > 0}
                                    {rolePermissions[i].update ? "√" : "X"}
                                {:else}
                                    BRAK
                                {/if}
                            </div>
                        {:else}
                            <div class="text-black">
                                {userPerm.update ? "√" : "X"}
                            </div>
                        {/if}
                    </button>
                </td>
                <td>
                    <button
                        type="button"
                        on:click={() => changePropertyValue(i, "delete")}
                        disabled={!isEditing}
                    >
                        {#if userPerm.delete === null}
                            <div class="text-gray-400">
                                {#if rolePermissions.length > 0}
                                    {rolePermissions[i].delete ? "√" : "X"}
                                {:else}
                                    BRAK
                                {/if}
                            </div>
                        {:else}
                            <div class="text-black">
                                {userPerm.delete ? "√" : "X"}
                            </div>
                        {/if}
                    </button>
                </td>
            </tr>
        {/each}
    </table>
</BaseEditableForm>
