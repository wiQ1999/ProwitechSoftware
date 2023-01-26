<script>
  import { goto } from "$app/navigation";
  export let PropertyManagerDTO;
  export let message;
  function redirect() {
    goto("/propertyManagers/getAll");
  }
  export let buttonVisibility = false;
</script>

<div
  class="w-[50%] h-[50%] text-center relative my-[10%] mx-auto bg-white rounded-2xl pt-10 px-2"
>
  {#if PropertyManagerDTO == null}
    Nie udało się odczytać danych Zarządcy Nieruchomości.
  {:else}
    <p>{message}</p>
    <p>
      Nazwa: <span class="font-semibold">{PropertyManagerDTO.name}</span>
    </p>
    Adres:
    <span class="font-semibold">
      {#if PropertyManagerDTO.fullAddress.buildingAddress.postalCode != null}
        {PropertyManagerDTO.fullAddress.buildingAddress.postalCode}
      {/if}
      {PropertyManagerDTO.fullAddress.buildingAddress.cityName},
      {PropertyManagerDTO.fullAddress.buildingAddress.streetName}
      {PropertyManagerDTO.fullAddress.buildingAddress.buildingNumber}
      {#if PropertyManagerDTO.fullAddress.propertyAddress}
        {#if PropertyManagerDTO.fullAddress.propertyAddress.venueNumber != ""}
          m. {PropertyManagerDTO.fullAddress.propertyAddress.venueNumber}
        {/if}
        {#if PropertyManagerDTO.fullAddress.propertyAddress.staircaseNumber != ""}
          klatka {PropertyManagerDTO.fullAddress.propertyAddress
            .staircaseNumber}
        {/if}
      {/if}
    </span>
    <br />
    <p>
      Nr telefonu:
      <span class="font-semibold">{PropertyManagerDTO.phoneNumber}</span>
    </p>
    <br />
    {#if buttonVisibility}
      <button
        on:click|preventDefault={() => redirect()}
        class="bg-green-400 uppercase decoration-none text-black text-base py-[1%] my-[5%] mx-auto w-[100%] rounded-md border-0 flex justify-center cursor-pointer"
        >OK</button
      >
    {/if}
  {/if}
</div>
