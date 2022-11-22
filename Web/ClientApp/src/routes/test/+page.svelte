<script>
    import BaseList from "$lib/components/base/BaseList.svelte";

    //Z API
    const collection = [
        {
            person: {
                name: "Wiktor",
                surname: "Szczeszek",
                age: 23,
                address: {
                    city: "Opalenica",
                    street: "Poprzeczna",
                    number: 2,
                },
            },
        },
        {
            person: {
                name: "Zdzisiu",
                surname: "Trąbka",
                age: 43,
                address: {
                    city: "Poznań",
                    street: "Polna",
                    number: 55,
                },
            },
        },
        {
            person: {
                name: "Jarek",
                surname: "Koparek",
                age: 54,
                address: {
                    city: "Wrocław",
                    street: "Mieszkaniowa",
                    number: 8,
                },
            },
        },
        {
            person: {
                name: "Marek",
                surname: "Wozidło",
                age: 33,
                address: {
                    city: "Bydgoszcz",
                    street: "Drzewiasta",
                    number: 112,
                },
            },
        },
        {
            person: {
                name: "Jan",
                surname: "Nowak",
                age: 19,
                address: {
                    city: "Poznań",
                    street: "Rolna",
                    number: 1,
                },
            },
        },
    ];

    const headers = ["Imię", "Nazwisko", "Wiek", "Miasto"];
    const properties = [
        "person.name",
        "person.surname",
        "person.age",
        "person.address.city",
    ];
</script>

<BaseList {collection} {headers} {properties} />
