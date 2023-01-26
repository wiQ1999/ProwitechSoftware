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

    $: test = userPermissions.every((c) => c === true); // ? sumowanie i sprawdzićczy reaguje na zmianę

    onMount(async () => {
        const user = await getUserById($page.params.slug);

        if (user.role) rolePermissions = await getForRole(user.role.id);

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

    function tableOnChange() {
        console.log("TABLE");
    }

    function mergePermissions(index, property) {
        switch (property.toLower()) {
            case "":
                break;

            default:
                break;
        }

        return false;
    }
</script>

<h1>Uprawnienia użytkownika:</h1>
{test}
<form on:submit|preventDefault={submitHandler}>
    <table on:change={tableOnChange}>
        <tr>
            <th>Zasób</th>
            <th>Dodawanie</th>
            <th>Odczytywanie</th>
            <th>Aktualizowanie</th>
            <th>Usuwanie</th>
        </tr>

        {#each userPermissions as userPerm}
            <tr>
                <td>{userPerm.source}</td>

                <td>
                    <input type="checkbox" bind:checked={userPerm.create} />
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

<br />
<br />

{#if rolePermissions.length > 0}
    <h1>Scalone urpawnienia użytkownika i roli:</h1>

    <table>
        <tr>
            <th>Zasób</th>
            <th>Dodawanie</th>
            <th>Odczytywanie</th>
            <th>Aktualizowanie</th>
            <th>Usuwanie</th>
        </tr>

        {#each Array(rolePermissions.length) as _, i}
            <tr>
                <td>{rolePermissions[i].source}</td>

                <td>
                    <input
                        type="checkbox"
                        checked={() => mergePermissions(i, "create")}
                        disabled
                    />
                </td>
                <td>
                    <input
                        type="checkbox"
                        checked={() => mergePermissions(i, "read")}
                        disabled
                    />
                </td>
                <td>
                    <input
                        type="checkbox"
                        checked={() => mergePermissions(i, "update")}
                        disabled
                    />
                </td>
                <td>
                    <input
                        type="checkbox"
                        checked={() => mergePermissions(i, "delete")}
                        disabled
                    />
                </td>
            </tr>
        {/each}
    </table>
{/if}
