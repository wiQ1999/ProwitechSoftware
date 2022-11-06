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
  } from "../../../stores/PropertyManager";
  import ShowPropertyManagerPopUp from "../../../components/ShowPropertyManagerPopUp.svelte";
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
    console.log(response);
    if (response instanceof Response) {
      alert("Pomyślnie usunięto Zarządcę Nieruchomości");
    }
    window.location.reload();
  }
</script>

<div class="display-all-property-managers">
  {#if displayAll}
    <table>
      <tbody>
        {#each managersJSON as manager}
          <tr>
            <td>{manager.name}</td>
            <td>{manager.phoneNumber}</td>
            <td>{manager.fullAddress.buildingAddress.cityName}</td>
            <td>{manager.fullAddress.buildingAddress.streetName}</td>
            <td>{manager.fullAddress.buildingAddress.buildingNumber}</td>
            <td>{manager.fullAddress.buildingAddress.postalCode}</td>
            <td>{manager.fullAddress.localNumber}</td>
            <td>{manager.fullAddress.staircaseNumber}</td>
            <td
              ><button on:click|preventDefault={() => edit(manager.id)}
                >Edytuj</button
              ></td
            >
            <td
              ><button
                on:click|preventDefault={() => displayConfirmPopUp(manager)}
                >Usuń</button
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
    <div class="delete-property-manager-confirm-pop-up">
      <ShowPropertyManagerPopUp
        {PropertyManagerDTO}
        message={showPropertyManagerPopUpMessage}
      />
      <button
        on:click|preventDefault={async () =>
          await deletePropManager(idToDelete)}>TAK, USUŃ</button
      >
      <button on:click|preventDefault={() => window.location.reload()}
        >ANULUJ</button
      >
    </div>{/if}
</div>
