<script>
  import { onMount } from "svelte";
  import { goto } from "$app/navigation";
  import { getAllUsers, deleteUser } from "$lib/stores/Users";
  import BaseList from "$lib/components/base/BaseList.svelte";
  import { openModal } from "svelte-modals";
  import BaseConfirmPopUp from "$lib/components/base/BaseConfirmPopUp.svelte";

  let collection = [];
  let tableRowsClassName = "users-base-list";
  onMount(async () => {
    collection = await getAllUsers();
  });

  const headerDictionary = {
    login: "login",
    Imię: "firstName",
    Nazwisko: "lastName",
    Email: "email",
    Rola: "role.name",
  };

  function addHandler(event) {
    goto(`/users/create`);
  }

  function detailHandler(event) {
    goto(`/users/${event.detail.row.id}/details`);
  }

  async function deleteHandler(event) {
    openModal(BaseConfirmPopUp, {
      title: "Potwierdź akcję",
      message: "Czy na pewno chcesz usunąć wybranego użytkownika?",
      onOkay: async () => await deleteAndReload(event.detail.row.id),
      undoSingleColorSelection: true,
      selectedElementHtmlDomId: `${tableRowsClassName}-${event.detail.row.id}`,
    });
  }
  async function deleteAndReload(id) {
    await deleteUser(id);
    window.location.reload();
  }

  async function deleteSelectedHandler(event) {
    const rows = event.detail.rows;
    openModal(BaseConfirmPopUp, {
      title: "Potwierdź akcję",
      message: "Czy na pewno chcesz usunąć zaznaczonych użytkowników?",
      onOkay: async () => await deleteSelectedAndReload(rows),
      undoMultipleColorSelection: true,
      selectedClassName: tableRowsClassName,
    });
  }
  async function deleteSelectedAndReload(rows) {
    if (rows == null) return;

    for (let i = 0; i < rows.length; i++) {
      await deleteUser(rows[i].id);
    }

    window.location.reload();
  }
</script>

<BaseList
  listName={"UŻYTKOWNICY"}
  {collection}
  {headerDictionary}
  {tableRowsClassName}
  on:listAdd={addHandler}
  on:listDetail={detailHandler}
  on:listDelete={deleteHandler}
  on:listDeleteSelected={deleteSelectedHandler}
/>
