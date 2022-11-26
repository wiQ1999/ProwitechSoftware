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

<div class="display-all-property-managers">
  <a href="/PropertyManager/create" class="button">Dodaj Zarządcę</a>
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
            <button on:click|preventDefault={() => edit(manager.id)}>
              <td>Edytuj</td>
            </button>
            <button on:click|preventDefault={() => displayConfirmPopUp(manager)}>
              <td>Usuń</td>
            </button>
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
    text-align: center;
  }

  table {
    margin: 5% auto;
    border: 2px solid black;
    width: 90%;
  }

  .headline {
    font-weight: bold;
    background-color: lightblue;
  }
  td {
    border: 2px solid black;
    padding: 5px 0;
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
    width: 50%;
  }

  .confirm {
    background-color: lightgreen;
  }

  .reject {
    background-color: lightcoral;
  }
</style>
