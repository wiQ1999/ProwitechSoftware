<script>
  import { goto } from "$app/navigation";
  export let BuildingDTO;
  export let message1;
  export let message2;
  export let buttonVisibility = false;
  const redirect = () => {
    goto("/buildings/getAll");
  };
</script>

<div
  class="w-[50%] h-[50%] relative my-[10%] mx-auto bg-white rounded-lg pt-10 p-1"
>
  {#if BuildingDTO == null}
    Nie udało się odczytać danych budynku.
  {:else}
    <p>{message1}</p>
    <br />

    Ulica:
    <span class="font-semibold"
      >{BuildingDTO.buildingAddress.streetName}
      {BuildingDTO.buildingAddress.buildingNumber}
    </span>
    <br />
    Miasto:
    <span class="font-semibold">{BuildingDTO.buildingAddress.cityName} </span>
    <br />
    {#if BuildingDTO.buildingAddress.postalCode != null}
      Kod pocztowy: <span class="font-semibold"
        >{BuildingDTO.buildingAddress.postalCode}
      </span>
    {/if}
    <br />
    Rodzaj: <span class="font-semibold">{BuildingDTO.type} </span>
    {#if BuildingDTO.propertyManager}
      <p>
        {message2}
        <span class="font-semibold">{BuildingDTO.propertyManager.name} </span>
      </p>
    {/if}
    <br />
    {#if buttonVisibility}
      <button
        on:click|preventDefault={() => redirect()}
        class="bg-green-400 uppercase decoration-none text-black text-base py-[1%] my-[5%] mx-auto w-[100%] rounded-md border-0 flex justify-center cursor-pointer"
        >Kontynuuj</button
      >
    {/if}
  {/if}
</div>
