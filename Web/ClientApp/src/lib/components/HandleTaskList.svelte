<script>
  import { createEventDispatcher } from "svelte";

  export let collection = [];
  export let headerDictionary = {};
  export let tableRowsClassName = "base-list";
  export let listName = "";
  export let firstButtonVisibility = false;
  export let secondButtonVisibility = false;
  export let firstButtonMessage = "DODAJ";
  export let secondButtonMessage = "EDYTUJ";

  let dispatch = createEventDispatcher();

  function firstButtonAction(row) {
    dispatch("firstButtonAction", { row });
  }

  function secondButtonAction(row) {
    let id = `${tableRowsClassName}-${row.id}`;
    markOutSelectedRow(id);
    dispatch("secondButtonAction", { row });
  }
  function markOutSelectedRow(id) {
    document.getElementById(id).style.backgroundColor = "red";
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
    // result = setPolishSigns(result);
    return setResultFormatIfItIsDateTime(property, result) ?? "";
  }
  function setResultFormatIfItIsDateTime(propertyName, propertyValue) {
    if (propertyName.includes("DateTime")) {
      if (propertyValue == "0001-01-01T00:00:00") return null;
      let d = new Date(propertyValue);
      return new Intl.DateTimeFormat("pl-PL", {
        dateStyle: "short",
        timeStyle: "short",
      }).format(d);
    }
    return propertyValue;
  }
  // function setPolishSigns(propertyValue) {
  //   if (propertyValue == "zakonczone") return "zakończone";
  //   return propertyValue;
  // }
  function setButtonMessage(collectionItem) {
    if (collectionItem.status == "nowe") return "ROZPOCZNIJ ZADANIE";
    if (collectionItem.status == "w toku") return "KONTYNUUJ ZADANIE";
    if (collectionItem.status == "zakonczone") return "SZCZEGÓŁY ZADANIA";
    return firstButtonMessage;
  }
</script>

<br />
<!-- <div class="ml-[2.5%] opacity-50 z-[-1] text-black xl:text-[30px] md:text-lg text-sm tracking-wide">
  {listName}
</div> -->
<div
  class="absolute ml-[2.5%] opacity-50 z-[-1] text-black xl:text-[30px] md:text-lg text-sm tracking-wide"
>
  {listName}
</div>
<table
  class="my-[2%] mx-auto bg-white border-2 border-slate-600 rounded-sm w-[95%] text-left pl-2"
>
  <tbody class="[&>*:nth-child(even)]:bg-[#dee8f5]">
    <tr class="text-sm font-bold border-b-2 border-slate-600 p-2">
      {#each getHeaderNames() as header}
        <th class="pl-2">{header.startsWith("_") ? "" : header}</th>
      {/each}
    </tr>
    {#each collection as row, i}
      <tr id="{tableRowsClassName}-{row.id}" class={tableRowsClassName}>
        {#each getHeaderProperties() as property}
          <td class="pl-2 border-r-2 border-slate-600"
            >{getDataFrmRow(row, property)}</td
          >
        {/each}
        <td>
          {#if firstButtonVisibility}
            <button
              on:click={firstButtonAction(row)}
              class="bg-blue-400 decoration-none text-white font-semibold text-sm py-2 my-1 rounded-sm justify-center cursor-pointer flex w-[90%] h-[50%]"
            >
              {setButtonMessage(row)}
            </button>
          {/if}
        </td>
        <td>
          {#if secondButtonVisibility}
            <button
              on:click={secondButtonAction(row, i)}
              class="bg-red-500 decoration-none text-white font-semibold text-sm py-2 my-1 rounded-sm justify-center cursor-pointer flex w-[90%] h-[50%]"
            >
              {secondButtonMessage}
            </button>
          {/if}
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
  >
{/if}
