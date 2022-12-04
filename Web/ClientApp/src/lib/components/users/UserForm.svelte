<script>
  import { onMount } from "svelte";
  import { page } from "$app/stores";
  import { goBack } from "$lib/js-lib/redirectorHelper.js";
  import { getAllRoles } from "$lib/stores/Roles.js";

  export let user = {
    id: null,
    login: null,
    password: null,
    firstName: null,
    lastName: null,
    email: null,
    phoneNumber: null,
    role: {
      id: null,
      name: null,
    },
  };

  let roles = [];
  let isEdit = false;
  let readonlyValue = "disabled";

  onMount(async () => {
    roles = await getAllRoles();
  });

  function editHandler() {
    isEdit = true;
    readonlyValue = "";
  }
</script>

<h1>Użytkownik</h1>

<form on:submit|preventDefault>
  {#if isEdit}
    <button type="submit">Zapisz</button>
  {:else}
    <button on:click={editHandler}>Edytuj</button>
  {/if}

  <button on:click={goBack($page)}>Zamknij</button>
  <br />

  <label for="user.login">Login</label>
  <input type="text" bind:value={user.login} disabled={readonlyValue} />
  <br />
  <label for="user.firstName">Imię</label>
  <input type="text" bind:value={user.firstName} disabled={readonlyValue} />
  <br />
  <label for="user.lastName">Nazwisko</label>
  <input type="text" bind:value={user.lastName} disabled={readonlyValue} />
  <br />
  <label for="user.email">Email</label>
  <input type="text" bind:value={user.email} disabled={readonlyValue} />
  <br />
  <label for="user.phoneNumber">Numer telefonu</label>
  <input type="text" bind:value={user.phoneNumber} disabled={readonlyValue} />
  <br />
  <label for="user.role.id">Rola</label>
  <select bind:value={user.role.id} disabled={readonlyValue}>
    {#each roles as role}
      {#if role.id == user.role.id}
        <option selected value={role.id}>{role.name}</option>
      {/if}
      <option value={role.id}>{role.name}</option>
    {/each}
  </select>
  <br />

  <!-- <label for="user.password">Hasło</label>
  <input
    type="password"
    bind:value={user.password}
    disabled={readonlyValue}
    required
  /> -->
</form>
