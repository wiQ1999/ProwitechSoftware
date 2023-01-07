<script>
	let login = '';
	let pwd = '';
</script>

<main>
  <slot>
    <!-- elementy strony -->
    <section class="flex flex-col justify-center items-center flex-2/3">
		
        <div class="w-3/4 mx-auto my-0 pt-8 bg-white border-2 border-silver border-solid">
          <form class="m-0">
            <label class="block w-1/2 px-2 py-2 mx-[20%] my-0 text-left text-[#696969] text-base" for="username">Nazwa użytkownika:</label>
            <input class="block w-1/2 px-2 py-2 mx-[20%] my-0 border-2 border-silver outline-8 outline-[#ebebeb] focus:outline-8 focus:outline-[#e5f2f8] text-lg "
              type="text"
              placeholder="Podaj nazwę użytkownika"
              id="username"
              required
              bind:value={login}
            />
            <label class="block w-1/2 px-2 py-2 mx-[20%] my-0 text-left text-[#696969] text-base" for="password">Hasło:</label>
            <input class="block w-1/2 px-2 py-2 mx-[20%] my-0 border-2 border-silver outline-8 outline-[#ebebeb] focus:outline-8 focus:outline-[#e5f2f8] text-lg"
              type="password"
              placeholder="Podaj hasło"
              id="password"
              required
			  pattern=".&#123;8,}"
  			  title="Musi zawierać co najmniej osiem znaków"
              bind:value={pwd}
            />
            <div class="bg-[#ecf2f5] w-[100%] py-[1%] px-[2%] mt-4">
              <input class="w-1/5 px-3 py-4 border-2 border-solid border-[#005f85] text-white bg-[#007acc] relative left-[35%] cursor-pointer" type="submit" value="Loguj!" />
            </div>
          </form>
        </div>
    </section>
  </slot>
</main>
