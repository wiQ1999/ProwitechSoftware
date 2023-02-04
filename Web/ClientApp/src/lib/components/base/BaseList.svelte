<script>
  import { createEventDispatcher } from "svelte";
  import { setResultFormatIfItIsDateTime } from "$lib/js-lib/helpers";
  export let collection = [];
  export let headerDictionary = {};
  export let tableRowsClassName = "base-list";
  export let listName = "";
  export let addButtonVisibility = true;

  let dispatch = createEventDispatcher();
  let isAllChecked = false;
  let checkCollection = [];

  $: isDeleteSelectedDisabled = checkCollection.every((c) => c === false);

  setCheckCollection(isAllChecked);

  function setCheckCollection(boolValue) {
    checkCollection = Array(collection.length).fill(boolValue);
  }

  function onAdd() {
    dispatch("listAdd");
  }

  function onDetail(row) {
    dispatch("listDetail", { row });
  }

  function onDelete(row, index) {
    let id = `${tableRowsClassName}-${row.id}`;
    markOutSelectedRow(id);
    dispatch("listDelete", { row });
  }

  function markOutSelectedRow(id) {
    document.getElementById(id).style.backgroundColor = "red";
  }

  function onDeleteSelected() {
    let rows = [];
    for (let i = 0; i < checkCollection.length; i++) {
      if (checkCollection[i] == true) {
        rows.push(collection[i]);
      }
    }
    changeStyleOfSelectedRows();
    dispatch("listDeleteSelected", { rows });
  }

  function changeStyleOfSelectedRows() {
    const rowsElems = Array.from(
      document.getElementsByClassName(tableRowsClassName)
    );
    rowsElems.forEach((rowElem) => {
      let rowId = rowElem.id;
      let checkboxId = `${rowId}-checkbox`;
      let checkboxElement = document.getElementById(checkboxId);
      if (checkboxElement.checked) {
        rowElem.style.backgroundColor = "red";
      }
    });
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

    const props = property.split(".");
    let result = row;

    for (let i = 0; i < props.length; i++) {
      if (result == null) return "";
      result = Reflect.get(result, props[i]);
    }

    return setResultFormatIfItIsDateTime(property, result) ?? "";
  }
</script>

<br />
<div
  class="absolute ml-[2.5%] opacity-50 z-[-1] text-black xl:text-[30px] md:text-lg text-sm tracking-wide"
>
  {listName}
</div>
{#if addButtonVisibility}
  <button
    on:click={onAdd}
    class="mx-auto mt-[4%] mb-[2%] p-4 rounded-md w-[50%] bg-[#007acc] text-white font-semibold flex justify-center"
    >Dodaj</button
  >
{/if}
{#if isDeleteSelectedDisabled}
  <button
    on:click={onDeleteSelected}
    disabled
    class="mx-auto rounded-sm w-[95%] bg-gray-300 border-2 border-b-0 border-slate-600 flex justify-center pointer-events-none"
    >Usuń zaznaczone</button
  >
{:else}
  <button
    on:click={onDeleteSelected}
    disabled={isDeleteSelectedDisabled}
    class="mx-auto rounded-sm w-[95%] bg-red-500 border-2 border-b-0 border-slate-600 flex justify-center"
    >Usuń zaznaczone</button
  >
{/if}
<table
  class="mb-[2%] mx-auto bg-white border-2 border-slate-600 rounded-sm w-[95%] text-left pl-2 lg:text-base md:text-sm text-xs"
>
  <tbody class="[&>*:nth-child(even)]:bg-[#dee8f5]">
    <tr class="font-bold border-b-2 border-slate-600 p-2">
      <th class="text-center border-r-2 border-slate-600">
        <input
          type="checkbox"
          bind:checked={isAllChecked}
          on:change={setCheckCollection(isAllChecked)}
        />
      </th>
      {#each getHeaderNames() as header}
        <th class="pl-2">{header.startsWith("_") ? "" : header}</th>
      {/each}
    </tr>
    {#each collection as row, i}
      <tr id="{tableRowsClassName}-{row.id}" class={tableRowsClassName}>
        <td class="text-center border-r-2 border-slate-600">
          <input
            type="checkbox"
            bind:checked={checkCollection[i]}
            id="{tableRowsClassName}-{row.id}-checkbox"
          />
        </td>
        {#each getHeaderProperties() as property}
          <td class="pl-2 border-r-2 border-slate-600"
            >{getDataFrmRow(row, property)}</td
          >
        {/each}
        <td>
          <button
            on:click={onDetail(row)}
            class="bg-blue-400 decoration-none text-white font-semibold lg:text-sm text-xs py-2 my-1 ml-2 rounded-sm justify-center cursor-pointer flex w-[90%] h-[50%]"
          >
            Szczegóły
          </button>
        </td>
        <td>
          <button
            on:click={onDelete(row, i)}
            class="bg-red-500 decoration-none text-white font-semibold text-sm py-2 my-1 mr-2 rounded-sm justify-center cursor-pointer flex w-[90%] h-[50%]"
          >
            Usuń
          </button>
        </td>
      </tr>
    {/each}
  </tbody>
</table>

{#if collection.length == 0}
  <div
    class="mb-[2%] mx-auto w-[95%] text-left pl-2 lg:text-base md:text-sm text-xs"
  >
    Brak rekordów
  </div>
{/if}
