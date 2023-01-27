<script>
    import { onMount } from "svelte";
    import { page } from "$app/stores";
    import { getUserById } from "$lib/stores/Users";
    import {
        getForRole,
        getForUser,
        postOrPutForUser,
    } from "$lib/stores/Permissions";
    import { openModal } from "svelte-modals";
    import BasePopUp from "$lib/components/base/BasePopUp.svelte";

    let rolePermissions = [];
    let userPermissions = [];

    onMount(async () => {
        const user = await getUserById($page.params.slug);

        if (user.role) {
            rolePermissions = await getForRole(user.role.id);
        }

        userPermissions = await getForUser($page.params.slug);
    });

    async function submitHandler() {
        const dto = { userId: $page.params.slug, permissions: userPermissions };
        const result = await postOrPutForUser($page.params.slug, dto);

        if (result) {
            openModal(BasePopUp, {
                title: "Zapisano uprawnienia",
                message: "Zapisywanie uprawnień dla użytkownika powiodło się.",
            });
        }
    }

    function changePreoprtyValue(index, property) {
        const permission = userPermissions[index];

        if (property === "create") {
            if (permission.create === null)
                userPermissions[index].create = true;
            else if (permission.create === true)
                userPermissions[index].create = false;
            else userPermissions[index].create = null;
        } else if (property === "read") {
            if (permission.read === null) userPermissions[index].read = true;
            else if (permission.read === true)
                userPermissions[index].read = false;
            else userPermissions[index].read = null;
        } else if (property === "update") {
            if (permission.update === null)
                userPermissions[index].update = true;
            else if (permission.update === true)
                userPermissions[index].update = false;
            else userPermissions[index].update = null;
        } else {
            if (permission.delete === null)
                userPermissions[index].delete = true;
            else if (permission.delete === true)
                userPermissions[index].delete = false;
            else userPermissions[index].delete = null;
        }
    }
</script>

<h1>Uprawnienia użytkownika:</h1>

<form on:submit|preventDefault={async () => submitHandler()}>
    <table>
        <tr>
            <th>Zasób</th>
            <th>Dodawanie</th>
            <th>Odczytywanie</th>
            <th>Aktualizowanie</th>
            <th>Usuwanie</th>
        </tr>

        {#each userPermissions as userPerm, i}
            <tr>
                <td>{userPerm.source}</td>

                <td>
                    <button
                        type="button"
                        on:click={() => changePreoprtyValue(i, "create")}
                    >
                        {#if userPermissions[i].create === null}
                            <div style="color:gray">
                                {#if rolePermissions.length > 0}
                                    {rolePermissions[i].creat ? "TAK" : "NIE"}
                                {:else}
                                    BRAK
                                {/if}
                            </div>
                        {:else}
                            <div style="color:black">
                                {userPermissions[i].create ? "TAK" : "NIE"}
                            </div>
                        {/if}
                    </button>
                </td>
                <td>
                    <button
                        type="button"
                        on:click={() => changePreoprtyValue(i, "read")}
                    >
                        {#if userPermissions[i].read === null}
                            <div style="color:gray">
                                {#if rolePermissions.length > 0}
                                    {rolePermissions[i].read ? "TAK" : "NIE"}
                                {:else}
                                    BRAK
                                {/if}
                            </div>
                        {:else}
                            <div style="color:black">
                                {userPermissions[i].read ? "TAK" : "NIE"}
                            </div>
                        {/if}
                    </button>
                </td>
                <td>
                    <button
                        type="button"
                        on:click={() => changePreoprtyValue(i, "update")}
                    >
                        {#if userPermissions[i].update === null}
                            <div style="color:gray">
                                {#if rolePermissions.length > 0}
                                    {rolePermissions[i].update ? "TAK" : "NIE"}
                                {:else}
                                    BRAK
                                {/if}
                            </div>
                        {:else}
                            <div style="color:black">
                                {userPermissions[i].update ? "TAK" : "NIE"}
                            </div>
                        {/if}
                    </button>
                </td>
                <td>
                    <button
                        type="button"
                        on:click={() => changePreoprtyValue(i, "delete")}
                    >
                        {#if userPermissions[i].delete === null}
                            <div style="color:gray">
                                {#if rolePermissions.length > 0}
                                    {rolePermissions[i].delete ? "TAK" : "NIE"}
                                {:else}
                                    BRAK
                                {/if}
                            </div>
                        {:else}
                            <div style="color:black">
                                {userPermissions[i].delete ? "TAK" : "NIE"}
                            </div>
                        {/if}
                    </button>
                </td>
            </tr>
        {/each}
    </table>

    <button type="submit">Zapisz</button>
</form>
