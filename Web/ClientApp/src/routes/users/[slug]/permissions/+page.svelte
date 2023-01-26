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

        if (user.role) rolePermissions = await getForRole(user.role.id);

        userPermissions = await getForUser($page.params.slug);

        console.log(rolePermissions);
        console.log(userPermissions);
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
</script>

<h1>Uprawnienia dla użytkownika:</h1>

<form on:submit|preventDefault={submitHandler}>
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
                    {#if userPerm.create === null}
                        <input
                            type="checkbox"
                            bind:checked={rolePermissions[i].create}
                        />
                    {:else}
                        <input type="checkbox" bind:checked={userPerm.create} />
                    {/if}
                </td>

                <td>
                    <input type="checkbox" bind:checked={userPerm.read} />
                </td>
                <td>
                    <input type="checkbox" bind:checked={userPerm.update} />
                </td>
                <td>
                    <input type="checkbox" bind:checked={userPerm.delete} />
                </td>
            </tr>
        {/each}
    </table>

    <button type="submit">Zapisz</button>
</form>
