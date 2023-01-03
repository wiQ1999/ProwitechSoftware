<script>
  import { onMount } from "svelte";
  import { getAllRoles, deleteRole } from "$lib/stores/Roles";
  import { goto } from "$app/navigation";
  import BaseList from "$lib/components/base/BaseList.svelte";
  import { openModal } from "svelte-modals";
  import BaseConfirmPopUp from "$lib/components/base/BaseConfirmPopUp.svelte";

    let collection = [];
    onMount(async () => {
        collection = await getAllRoles();
    });

  const headerDictionary = {
    Nazwa: "name",
  };

  function addHandler(event) {
    goto(`/roles/create`);
  }

  function detailHandler(event) {
    goto(`/roles/${event.detail.row.id}/details`);
  }

  async function deleteHandler(event) {
    openModal(BaseConfirmPopUp, {
      title: "Potwierdź akcję",
      message: "Czy na pewno chcesz usunąć wybraną rolę?",
      onOkay: async () => await deleteRoleAndReload(event.detail.row.id),
    });
  }

  async function deleteRoleAndReload(id) {
    await deleteRole(id);
    window.location.reload();
  }

  async function deleteSelectedHandler(event) {
    const rows = event.detail.rows;
    openModal(BaseConfirmPopUp, {
      title: "Potwierdź akcję",
      message: "Czy na pewno chcesz usunąć zaznaczone role?",
      onOkay: async () => await deleteSelectedAndReload(rows),
    });
  }
  async function deleteSelectedAndReload(rows) {
    if (rows == null) return;

    for (let i = 0; i < rows.length; i++) {
      await deleteRole(rows[i].id);
    }

    window.location.reload();
  }
</script>

<BaseList
  {collection}
  {headerDictionary}
  on:listAdd={addHandler}
  on:listDetail={detailHandler}
  on:listDelete={deleteHandler}
  on:listDeleteSelected={deleteSelectedHandler}
/>
