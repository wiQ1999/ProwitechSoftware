<script>
  // struktura PropertyManagerDTO
  //   let PropertyManagerDTO = {
  //     id: "",
  //     name: "",
  //     phoneNumber: "",
  //     fullAddress: {
  //       buildingAddress: {
  //         cityName: "",
  //         streetName: "",
  //         buildingNumber: "",
  //         postalCode: "",
  //       },
  //       localNumber: "",
  //       staircaseNumber: "",
  //     },
  //   };

  import { onMount } from "svelte";
  import {
    getAllPropertyManagers,
    deletePropertyManager,
  } from "$lib/stores/PropertyManager";
  import ShowPropertyManagerPopUp from "$lib/components/ShowPropertyManagerPopUp.svelte";
  let displayAll;
  let displayPopUp;
  let displayGetAllProblem;
  let errorMessage =
    "Nie udało się pobrać danych o Zarządcach Nieruchomości z bazy danych";
  let managersJSON;
  let PropertyManagerDTO;
  let idToDelete;
  let showPropertyManagerPopUpMessage =
    "Jesteś pewny, że chcesz usunąć poniższego Zarządcę Nieruchomości?";

  onMount(async () => {
    let managers = await getAllPropertyManagers();
    if (managers instanceof Error) {
      displayAll = false;
      displayGetAllProblem = true;
    } else if (managers instanceof Response) {
      managersJSON = await managers.json();
      displayAll = true;
    }
  });
  function edit(id) {
    // localStorage.setItem("manager_to_update_id", id);
    window.location.href = `/PropertyManager/update/${id}`;
  }
  function displayConfirmPopUp(manager) {
    PropertyManagerDTO = {
      name: manager.name,
      phoneNumber: manager.phoneNumber,
      fullAddress: {
        buildingAddress: {
          cityName: manager.fullAddress.buildingAddress.cityName,
          streetName: manager.fullAddress.buildingAddress.streetName,
          buildingNumber: manager.fullAddress.buildingAddress.buildingNumber,
          postalCode: manager.fullAddress.buildingAddress.postalCode,
        },
        localNumber: manager.fullAddress.localNumber,
        staircaseNumber: manager.fullAddress.staircaseNumber,
      },
    };
    idToDelete = manager.id;
    displayAll = false;
    displayPopUp = true;
  }
  async function deletePropManager(id) {
    let response = await deletePropertyManager(id);
    if (response instanceof Response) {
      alert("Pomyślnie usunięto Zarządcę Nieruchomości");
    }
    window.location.reload();
  }
</script>

<div class="mx-[5%] w-[90%] text-center">
  <a href="/PropertyManager/create">
    <button class="mx-auto p-4 rounded-md w-1/2 bg-[#007acc]">Dodaj Zarządcę</button>
  </a>
</div>

<div class="display-all-property-managers">
  {#if displayAll}
    <table class="my-[2%] mx-auto bg-white border-2 border-slate-600 rounded-sm w-[90%] text-left">
      <tbody class="[&>*:nth-child(odd)]:bg-[#dee8f5]">
        <tr class="text-xs font-bold border-b-2 border-slate-600 p-2">
          <td>Nazwa zarządcy</td>
          <td>Numer telefonu</td>
          <td colspan="4">Adres zarządcy</td>
          <td>Nr lokalu</td>
          <td>Nr klatki</td>
          <td colspan="2"> </td>
        </tr>
        {#each managersJSON as manager}
          <tr >
            <td>{manager.name}</td>
            <td>{manager.phoneNumber}</td>
            <td>{manager.fullAddress.buildingAddress.postalCode}</td>
            <td>{manager.fullAddress.buildingAddress.cityName}</td>
            <td>{manager.fullAddress.buildingAddress.streetName}</td>
            <td>{manager.fullAddress.buildingAddress.buildingNumber}</td>
            
            <td>{#if !manager.fullAddress.localNumber} - {/if} {manager.fullAddress.localNumber}</td>
            
            <td>{#if !manager.fullAddress.staircaseNumber} - {/if} {manager.fullAddress.staircaseNumber}</td>
            <td
              ><button class="bg-yellow-500 decoration-none text-black text-base py-[1%] m-[5%] rounded-md justify-center cursor-pointer flex w-[50px] h-[25px]"
                on:click|preventDefault={() => edit(manager.id)}
                ><div class="edit icon" /></button
              ></td
            >
            <td
              ><button class="bg-red-500 decoration-none text-black text-base p-[1%] m-[5%] rounded-md justify-center cursor-pointer flex w-[50px] h-[25px]"
                on:click|preventDefault={() => displayConfirmPopUp(manager)}
                ><div class="trash icon" /></button
              ></td
            >
            <!-- <button on:click|preventDefault={async () => await continueAdding()}
          >Kontynuuj</button
        > -->
          </tr>
        {/each}
      </tbody>
    </table>
  {:else if displayGetAllProblem}
    {errorMessage}
  {:else if displayPopUp}
    <div class="w-[100%] h-[100%] m-0 p-0 top-0 left-0 fixed bg-black/80">
      <div class="w-[50%] h-[50%] relative my-5 mx-auto bg-white rounded-2xl">
        <ShowPropertyManagerPopUp
          {PropertyManagerDTO}
          message={showPropertyManagerPopUpMessage}
        />
        <button
          class="bg-green-500 uppercase decoration-none text-black text-base py-[1%] mx-auto rounded-md flex w-[60%] justify-center cursor-pointer"
          on:click|preventDefault={async () =>
            await deletePropManager(idToDelete)}>TAK, USUŃ</button
        >
        <button
          class="bg-red-500 uppercase decoration-none text-black text-base py-[1%] my-[5%] mx-auto rounded-md flex w-[60%] justify-center cursor-pointer"
          on:click|preventDefault={() => window.location.reload()}
          >ANULUJ</button
        >
      </div>
    </div>{/if}
</div>

<style>
  .edit.icon {
    color: #000;
    position: absolute;
    margin-left: 4px;
    margin-top: 7px;
    width: 14px;
    height: 2px;
    border-radius: 1px;
    border: solid 1px currentColor;
    -webkit-transform: rotate(-45deg);
    transform: rotate(-45deg);
  }

  .edit.icon:before {
    content: "";
    position: absolute;
    left: -12px;
    top: -1px;
    width: 0px;
    height: 0px;
    border-left: solid 5px transparent;
    border-right: solid 5px currentColor;
    border-top: solid 2px transparent;
    border-bottom: solid 2px transparent;
  }

  .trash.icon {
    color: #000;
    position: absolute;
    margin-left: 5px;
    margin-top: 7px;
    width: 9px;
    height: 10px;
    border-left: solid 1px currentColor;
    border-right: solid 1px currentColor;
    border-bottom: solid 1px currentColor;
    border-radius: 0 0 2px 2px;
  }

  .trash.icon:before {
    content: "";
    position: absolute;
    left: -4px;
    top: -2px;
    width: 17px;
    height: 1px;
    background-color: currentColor;
  }

  .trash.icon:after {
    content: "";
    position: absolute;
    left: 0px;
    top: -5px;
    width: 7px;
    height: 2px;
    border-left: solid 1px currentColor;
    border-right: solid 1px currentColor;
    border-top: solid 1px currentColor;
    border-radius: 4px 4px 0 0;
  }
</style>
