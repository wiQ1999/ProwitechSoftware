<script>
    export let collection = [];
    export let headers = [];
    export let properties = [];

    function getDataFrmRow(row, property) {
        if (!property && property == "") {
            throw "Invalid argument named 'property'";
        }

        if (property[0] == ".") {
            property = property.slice(1);
        }

        let result = row;
        const props = property.split(".");

        for (let i = 0; i < props.length; i++) {
            result = Reflect.get(result, props[i]);
        }

        return result;
    }
</script>

<table>
    <tr>
        {#each headers as header}
            <th>{header}</th>
        {/each}
    </tr>
    {#each collection as row}
        <!-- on:dblclick={goToEditRow(row.id)}-->
        <tr>
            {#each properties as prop}
                <td>{getDataFrmRow(row, prop) ?? ""}</td>
            {/each}
            <!-- <td>
                <button on:click={getUserById(row.id)}> Szczegóły </button>
            </td>
            <td>
                <button on:click{deleteRow(user)}> Usuń </button>
            </td> -->
        </tr>
    {/each}
</table>
