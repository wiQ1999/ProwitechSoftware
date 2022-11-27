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

<div class="abovetable">
  <div class="plus icon" />
  <a href="/PropertyManager/create" class="button">Dodaj Zarządcę</a>
</div>

<div class="display-all-property-managers">
  {#if displayAll}
    <table>
      <tbody>
        <h2>Zarządcy</h2>
        <tr class="headline">
          <td>Nazwa zarządcy</td>
          <td>Numer telefonu</td>
          <td colspan="4">Adres zarządcy</td>
          <td>Nr lokalu</td>
          <td>Nr klatki</td>
          <td colspan="2" hidden>USUŃ ZAZNACZONE</td>
        </tr>
        {#each managersJSON as manager}
          <tr>
            <td>{manager.name}</td>
            <td>{manager.phoneNumber}</td>
            <td>{manager.fullAddress.buildingAddress.postalCode}</td>
            <td>{manager.fullAddress.buildingAddress.cityName}</td>
            <td>{manager.fullAddress.buildingAddress.streetName}</td>
            <td>{manager.fullAddress.buildingAddress.buildingNumber}</td>
            <td>{manager.fullAddress.localNumber}</td>
            <td>{manager.fullAddress.staircaseNumber}</td>
            <td
              ><button on:click|preventDefault={() => edit(manager.id)}
                ><div class="edit icon" /></button
              ></td
            >
            <td
              ><button
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
    <div class="outside">
      <div class="delete-property-manager-confirm-pop-up">
        <ShowPropertyManagerPopUp
          {PropertyManagerDTO}
          message={showPropertyManagerPopUpMessage}
        />
        <button
          class="confirm"
          on:click|preventDefault={async () =>
            await deletePropManager(idToDelete)}>TAK, USUŃ</button
        >
        <button
          class="reject"
          on:click|preventDefault={() => window.location.reload()}
          >ANULUJ</button
        >
      </div>
    </div>{/if}
</div>

<style>
  div {
    margin: 5% auto;
  }

  table {
    margin: 5% auto;
    border: 2px solid lightslategray;
    border-radius: 8px;
    width: 90%;
    text-align: left;
  }

  .abovetable {
    margin: 5%;
  }

  .headline {
    background-color: #007acc;
    color: white;
  }

  tr:nth-child(odd) {
    background-color: #dee8f5;
  }

  .outside {
    width: 100%;
    height: 100%;
    margin: 0;
    padding: 0;
    position: fixed;
    top: 0;
    left: 0;
    background-color: rgba(0, 0, 0, 0.7);
  }
  .delete-property-manager-confirm-pop-up {
    width: 50%;
    height: 50%;
    position: relative;
    margin: 10% auto;
    background-color: white;
    border-radius: 20px;
    padding: 2%;
  }

  button,
  .button {
    text-decoration: none;
    color: black;
    padding: 1%;
    margin: 5% auto;
    background-color: pink;
    border-radius: 7px;
    border: 0px;
    font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS",
      sans-serif;
    font-size: 12px;
    display: flex;
    justify-content: center;
    cursor: pointer;
  }

  td button {
    width: 50px;
    height: 25px;
    position: relative;
  }

  .confirm {
    background-color: lightgreen;
  }

  .reject {
    background-color: lightcoral;
  }

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

  .plus.icon {
    color: #000;
    position: absolute;
    margin-left: 3px;
    margin-top: 10px;
  }

  .plus.icon:before {
    content: "";
    position: absolute;
    width: 15px;
    height: 1px;
    background-color: currentColor;
  }

  .plus.icon:after {
    content: "";
    position: absolute;
    width: 15px;
    height: 1px;
    background-color: currentColor;
    -webkit-transform: rotate(90deg);
    transform: rotate(90deg);
  }
</style>
