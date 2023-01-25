<script>
    import { onMount } from "svelte";
    import { page } from "$app/stores";
    import { getForRole, postOrPutForRole } from "$lib/stores/Permissions";
    import { openModal } from "svelte-modals";
    import BasePopUp from "$lib/components/base/BasePopUp.svelte";

    let permissions = [];

    onMount(async () => {
        permissions = await getForRole($page.params.slug);
    });

    async function submitHandler() {
        const dto = { roleId: $page.params.slug, permissions: permissions };
        const result = await postOrPutForRole($page.params.slug, dto);

        if (result) {
            openModal(BasePopUp, {
                title: "Zapisano uprawnienia",
                message: "Zapisywanie uprawnień dla roli powiodło się.",
            });
        }
    }
</script>

<h1>Uprawnienia dla roli</h1>

<form on:submit|preventDefault={submitHandler}>
    <table>
        <tr>
            <th>Zasób</th>
            <th>Dodawanie</th>
            <th>Odczytywanie</th>
            <th>Aktualizowanie</th>
            <th>Usuwanie</th>
        </tr>

        {#each permissions as permission}
            <tr>
                <td>{permission.source}</td>
                <td
                    ><input
                        type="checkbox"
                        bind:checked={permission.create}
                    /></td
                >
                <td><input type="checkbox" bind:checked={permission.read} /></td
                >
                <td
                    ><input
                        type="checkbox"
                        bind:checked={permission.update}
                    /></td
                >
                <td
                    ><input
                        type="checkbox"
                        bind:checked={permission.delete}
                    /></td
                >
            </tr>
        {/each}
    </table>

    <button type="submit">Zapisz</button>
</form>
