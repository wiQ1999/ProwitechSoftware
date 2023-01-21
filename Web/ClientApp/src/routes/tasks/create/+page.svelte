<script>
  import InspectionTaskForm from "$lib/components/InspectionTaskForm.svelte";
  import { openModal } from "svelte-modals";
  import BasePopUp from "$lib/components/base/BasePopUp.svelte";
  import { postInspectionTask } from "$lib/stores/InspectionTask";

  let href = `/tasks/getAll`;
  let CreateInspectionTaskCommand = {
    taskDelegatorId: "",
    taskPerformerId: "",
    buildingId: "",
    dueStartDateTime: "",
  };
  const createInspectionTask = async () => {
    //TODO pobierz Id osoby zalogowanej jako delegatora
    CreateInspectionTaskCommand.taskDelegatorId =
      "DB789183-4BD0-4D3C-AF40-548AC88FBDEB";
    let result = await postInspectionTask(CreateInspectionTaskCommand);
    if (result instanceof Response) {
      openModal(BasePopUp, {
        title: "Sukces",
        message: "Pomyślnie dodano Zadanie",
        reloadRequired: false,
        redirectionRequired: true,
        redirectionHref: href,
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
<InspectionTaskForm
  onSubmit={createInspectionTask}
  bind:CreateInspectionTaskCommand
/>
