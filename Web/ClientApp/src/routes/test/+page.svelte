<script>
    import BaseList from "$lib/components/base/BaseList.svelte";

    //Z API
    const collection = [
        {
            id: "1",
            name: "Wiktor",
            surname: "Szczeszek",
            age: 23,
            address: {
                city: "Opalenica",
                street: "Poprzeczna",
                number: 2,
            },
        },
        {
            id: "2",
            name: "Zdzisiu",
            surname: "Trąbka",
            age: 43,
            address: {
                city: "Poznań",
                street: "Polna",
                number: 55,
            },
        },
        {
            id: "3",
            name: "Jarek",
            surname: "Koparek",
            age: 54,
            address: {
                city: "Wrocław",
                street: "Mieszkaniowa",
                number: 8,
            },
        },
        {
            id: "4",
            name: "Marek",
            surname: "Wozidło",
            age: 33,
            address: {
                city: "Bydgoszcz",
                street: "Drzewiasta",
                number: 112,
            },
        },
        {
            id: "5",
            name: "Jan",
            surname: "Nowak",
            age: 19,
            address: {
                city: "Poznań",
                street: "Rolna",
                number: 1,
            },
        },
    ];

    const headerDictionary = {
        ID: "id",
        Imię: "name",
        Nazwisko: "surname",
        Wiek: "age",
        Miasto: "address.city",
    };

    function addHandler(event) {
        alert("addHandler");
    }

    function detailHandler(event) {
        alert("detailHandler");
    }

    function deleteHandler(event) {
        alert("deleteHandler");
    }
</script>

<BaseList
    {collection}
    {headerDictionary}
    on:listAdd={addHandler}
    on:listDetail={detailHandler}
    on:listDelete={deleteHandler}
/>
