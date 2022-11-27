<script>
    import { onMount } from "svelte";
    import { goto } from "$app/navigation";
    import { getAllUsers, deleteUser } from "$lib/stores/Users";
    import BaseList from "$lib/components/base/BaseList.svelte";

    let collection = [];
    onMount(async () => {
        collection = await getAllUsers();
    });

    const headerDictionary = {
        Imię: "firstName",
        Nazwisko: "lastName",
        Emial: "email",
        "Numer tel.": "phoneNumber",
        Rola: "role.name",
    };

    function addHandler(event) {
        goto(`/users/create`);
    }

    function detailHandler(event) {
        goto(`/users/details/${event.detail.row.id}`);
    }

    function deleteHandler(event) {
        deleteUser(event.detail.row.id);
        window.location.reload();
    }

    function deleteSelectedHandler(event) {
        alert("deleteSelectedHandler");
        console.log(event.detail.rows);
    }
</script>

<BaseList
    {collection}
    {headerDictionary}
    on:listAdd={addHandler}
    on:listDetail={detailHandler}
    on:listDelete={deleteHandler}
    on:listDeleteSelected={deleteSelectedHandler}
/>
