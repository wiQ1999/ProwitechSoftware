<script>
  import { goto } from "$app/navigation";
  import { openModal } from "svelte-modals";
  import BasePopUp from "$lib/components/base/BasePopUp.svelte";
  import { getAuthenticated } from "$lib/stores/Authentication";
  import { setToken } from "$lib/js-lib/authManager.js";

  let login = "";
  let pwd = "";

  async function submitHandler() {
    const json = await getAuthenticated(login, pwd);

    if (json.isGenerated) {
      setToken(json.token);
      goto("/users");
    } else {
      openModal(BasePopUp, {
        title: "Błąd logowania",
        message: "Niepoprawny login lub hasło",
        reloadRequired: true,
      });
    }
  }
</script>

<main>
  <slot>
    <section class="flex flex-col justify-center items-center flex-2/3">
      <div
        class="w-3/4 mx-auto my-0 pt-8 bg-white border-2 border-silver border-solid"
      >
        <form on:submit|preventDefault={submitHandler} class="m-0">
          <label
            class="block w-1/2 px-2 py-2 mx-[25%] my-0 text-left text-[#696969] text-base"
            for="username">Nazwa użytkownika:</label
          >
          <input
            class="block w-1/2 px-2 py-2 mx-[25%] my-0 outline-0 border-2 focus:border-[#0078c8] text-lg "
            type="text"
            placeholder="Podaj nazwę użytkownika"
            id="username"
            required
            bind:value={login}
          />
          <label
            class="block w-1/2 px-2 py-2 mx-[25%] my-0 text-left text-[#696969] text-base"
            for="password">Hasło:</label
          >
          <input
            class="block w-1/2 px-2 py-2 mx-[25%] my-0 outline-0 border-2 focus:border-[#0078c8] text-lg"
            type="password"
            placeholder="Podaj hasło"
            id="password"
            required
            pattern=".&#123;8,}"
            title="Musi zawierać co najmniej osiem znaków"
            bind:value={pwd}
          />
          <div class="bg-[#ecf2f5] w-[100%] py-[1%] px-[2%] mt-4">
            <input
              class="w-1/5 px-3 py-4 border-2 border-solid border-[#005f85] text-white bg-[#007acc] relative left-[40%] cursor-pointer"
              type="submit"
              value="Loguj!"
            />
          </div>
        </form>
      </div>
    </section>
  </slot>
</main>
