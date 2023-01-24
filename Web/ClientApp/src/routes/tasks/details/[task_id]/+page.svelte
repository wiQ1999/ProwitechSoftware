<script>
  import { openModal } from "svelte-modals";
  import BasePopUp from "$lib/components/base/BasePopUp.svelte";
  import { page } from "$app/stores";
  import { onMount } from "svelte";

  import InspectionTaskForm from "$lib/components/InspectionTaskForm.svelte";
  import {
    getInspectionTaskById,
    putInspectionTask,
    checkIfTasksDiffer,
  } from "$lib/stores/InspectionTask";
  import { getBuildingById } from "$lib/stores/Building";
  let editMode = true;
  let formVisibility = false;
  let href = `/tasks/getAll`;
  let originalInspectionTask;
  let building;
  let showProtocolsButton = false;
  let UpdateInspectionTaskCommand = {
    id: "",
    taskDelegatorId: "",
    taskPerformerId: "",
    status: "",
    buildingId: "",
    dueStartDateTime: "",
    startDateTime: "",
    endDateTime: "",
  };
  onMount(async () => {
    let res = await getInspectionTaskById($page.params.task_id);
    if (res instanceof Error) return;
    originalInspectionTask = await res.json();

    UpdateInspectionTaskCommand = {
      id: originalInspectionTask.id,
      taskDelegatorId: originalInspectionTask.taskDelegator.id,
      taskPerformerId: originalInspectionTask.taskPerformer.id,
      status: originalInspectionTask.status,
      buildingId: originalInspectionTask.building.id,
      dueStartDateTime: originalInspectionTask.dueStartDateTime,
    };

    if (
      UpdateInspectionTaskCommand.status == "zakonczone" ||
      UpdateInspectionTaskCommand.status == "zakończone"
    )
      showProtocolsButton = true;

    let buildingResponse = await getBuildingById(
      originalInspectionTask.building.id
    );
    if (buildingResponse instanceof Response) {
      building = await buildingResponse.json();
    }
    formVisibility = true;
  });
  const updateInspectionTask = async () => {
    //TODO
    //ZMIENIĆ DANE TASKDELEGATORA NA ID OSOBY ZALOGOWANEJ
    UpdateInspectionTaskCommand.taskDelegatorId =
      "DB789183-4BD0-4D3C-AF40-548AC88FBDEB";
    let differ = checkIfTasksDiffer(
      originalInspectionTask,
      UpdateInspectionTaskCommand
    );
    if (!differ) {
      openModal(BasePopUp, {
        title: "Brak akcji",
        message: "Dane Zadania nie zostały zmienione",
      });
      return;
    }
    let result = await putInspectionTask(
      UpdateInspectionTaskCommand.id,
      UpdateInspectionTaskCommand
    );
    if (result instanceof Response) {
      openModal(BasePopUp, {
        title: "Sukces",
        message: "Pomyślnie edytowano Zadanie",
        reloadRequired: true,
      });
    }
  };
</script>

<a {href}>
  <button
    class="bg-red-500 uppercase decoration-none text-black text-base font-semibold py-[1%] mx-auto rounded-md flex w-[60%] justify-center cursor-pointer"
    >Powrót</button
  >
</a>
{#if formVisibility}
  <InspectionTaskForm
    onSubmit={updateInspectionTask}
    bind:CreateInspectionTaskCommand={UpdateInspectionTaskCommand}
    {building}
    {editMode}
  />
{/if}
{#if showProtocolsButton}
  <div
    class="w-1/2 my-[10px] mx-auto py-3 px-5 bg-[#f4f7f8] rounded-lg text-center"
  >
    <a href="/tasks/details/{$page.params.task_id}/protocols">
      <button
        class="flex font-semibold border-2 border-[#0078c8] hover:bg-blue-400 mt-4 p-4 mx-auto rounded-md"
        >Protokoły</button
      >
    </a>
  </div>
{/if}
