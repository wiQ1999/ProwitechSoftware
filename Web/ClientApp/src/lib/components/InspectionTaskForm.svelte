<script>
  import { onMount } from "svelte";
  import Map from "$lib/components/Map.svelte";
  import { getAllUsers } from "$lib/stores/Users";
  import { getAllBuildings } from "$lib/stores/Building";
  import { prepareDateTime } from "$lib/js-lib/helpers";

  export let onSubmit = async () => {};
  export let CreateInspectionTaskCommand = {
    taskDelegatorId: "",
    taskPerformerId: "",
    buildingId: "",
    dueStartDateTime: "",
  };
  export let editMode = false;
  export let building = null;
  let formVisibility;
  let upper_message = "Dodaj Zadanie";
  let button_turn_on_edition_message = "Włącz edycję";
  let readMode = false;
  let submitButtonMessage = "DODAJ";

  let users = [];
  let buildings = [];
  let today = prepareDateTime(new Date(), true);

  onMount(async () => {
    if (!editMode) CreateInspectionTaskCommand.dueStartDateTime = today;
    //TODO sprawdzić, kto wszedł tutaj, jeśli nie admin, pokaż błąd
    readMode = editMode;

    //TODO może zmienić na getUsersWithSpecificRole?
    let usersResponse = await getAllUsers();
    for (let element of usersResponse) {
      users.push({
        id: element.id,
        firstName: element.firstName,
        lastName: element.lastName,
        login: element.login,
      });
    }
    let buildingsResponse = await getAllBuildings();
    if (buildingsResponse instanceof Error) return;

    buildingsResponse = await buildingsResponse.json();

    for (let element of buildingsResponse) {
      buildings.push({
        id: element.id,
        streetName: element.buildingAddress.streetName,
        number: element.buildingAddress.buildingNumber,
        cityName: element.buildingAddress.cityName,
      });
    }

    if (editMode) {
      submitButtonMessage = "ZATWIERDŹ";
      upper_message = "Szczegóły Zadania";
    }
    formVisibility = true;
  });
  function changeEditingStatus() {
    readMode = !readMode;
    if (button_turn_on_edition_message == "Włącz edycję") {
      button_turn_on_edition_message = "Zakończ edycję";
    } else {
      button_turn_on_edition_message = "Włącz edycję";
    }
    if (readMode) upper_message = "Szczegóły Zadania";
    else upper_message = "Edycja Zadania";
  }
</script>

{#if formVisibility}
  <form
    on:submit|preventDefault={async () => await onSubmit()}
    class="w-[50%] my-3 mx-auto py-3 px-5 bg-[#f4f7f8] rounded-lg text-center"
  >
    <fieldset class="border-none">
      <legend class="font-bold text-lg py-5"> {upper_message} </legend>
      {#if editMode}
        <button
          on:click|preventDefault={() => changeEditingStatus()}
          class="flex font-semibold bg-blue-400 mb-4 p-4 mx-auto rounded-md text-white"
          >{button_turn_on_edition_message}</button
        >
      {/if}
      <label for="inspection-task-building" class="block">Budynek</label>
      <select
        bind:value={CreateInspectionTaskCommand.buildingId}
        disabled={readMode}
        required
        class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]"
      >
        {#each buildings as building}
          <option value={building.id}
            >{building.streetName} {building.number} | {building.cityName}
          </option>
        {/each}
      </select>
      <label for="inspection-task-performer" class="block"
        >Wykonujący Zadanie</label
      >
      <select
        bind:value={CreateInspectionTaskCommand.taskPerformerId}
        disabled={readMode}
        required
        class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]"
      >
        {#each users as user}
          <option value={user.id}
            >{user.firstName} {user.lastName} {user.login}
          </option>
        {/each}
      </select>

      <label for="inspection-task-due-start-time" class="block"
        >Planowany czas rozpoczęcia</label
      >
      <input
        type="datetime-local"
        min={today}
        bind:value={CreateInspectionTaskCommand.dueStartDateTime}
        disabled={readMode}
        class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]"
      />
    </fieldset>
    {#if !readMode}
      <button
        type="submit"
        class="py-5 px-10 border-2 border-[#0078c8] font-semibold text-lg rounded-md w-[90%] mb-3 justify-center cursor-pointer hover:bg-blue-400"
        >{submitButtonMessage}</button
      >
    {/if}
  </form>
  {#if readMode}
    <Map {building} displayLink={false} />
  {/if}
{/if}
