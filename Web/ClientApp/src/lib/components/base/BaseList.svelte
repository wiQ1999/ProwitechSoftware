<script>
    import { createEventDispatcher } from "svelte";
    let dispatch = createEventDispatcher();

    export let collection = [];
    export let headerDictionary = {};

    let isChecked = false;
    let checkCollection = [];

    initializeCheckCollection(isChecked);

    function initializeCheckCollection(value) {
        for (let i = 0; i < collection.length; i++) {
            checkCollection[i] = value;
        }
    }

    function onAdd() {
        dispatch("listAdd");
    }

    function onDetail(row) {
        dispatch("listDetail", { row });
    }

    function onDelete(row) {
        dispatch("listDelete", { row });
    }

    function getHeaderNames() {
        return Object.keys(headerDictionary);
    }

    function getHeaderProperties() {
        return Object.values(headerDictionary);
    }

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

<br />

<button>Usuń</button>
<button on:click={onAdd}>Dodaj</button>

<table>
    <tr>
        <th>
            <input
                type="checkbox"
                bind:checked={isChecked}
                on:change={initializeCheckCollection(isChecked)}
            />
        </th>
        {#each getHeaderNames() as header}
            <th>{header}</th>
        {/each}
    </tr>
    {#each collection as row, i}
        <!-- on:dblclick={goToEditRow(row.id)}-->
        <tr>
            <td>
                <input type="checkbox" bind:checked={checkCollection[i]} />
            </td>
            {#each getHeaderProperties() as property}
                <td>{getDataFrmRow(row, property) ?? ""}</td>
            {/each}
            <td>
                <button on:click={onDetail(row)}> Szczegóły </button>
            </td>
            <td>
                <button on:click={onDelete(row)}> Usuń </button>
            </td>
        </tr>
    {/each}
</table>
