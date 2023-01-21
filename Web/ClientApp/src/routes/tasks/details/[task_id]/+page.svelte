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
    if (res instanceof Response) {
      originalInspectionTask = await res.json();

      UpdateInspectionTaskCommand = {
        id: originalInspectionTask.id,
        taskDelegatorId: originalInspectionTask.taskDelegator.id,
        taskPerformerId: originalInspectionTask.taskPerformer.id,
        status: originalInspectionTask.status,
        buildingId: originalInspectionTask.building.id,
        dueStartDateTime: originalInspectionTask.dueStartDateTime,
      };
    }
    let buildingResponse = await getBuildingById(
      originalInspectionTask.building.id
    );
    if (buildingResponse instanceof Response) {
      building = await buildingResponse.json();
    }
    formVisibility = true;
  });
  const updateInspectionTask = async () => {
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
