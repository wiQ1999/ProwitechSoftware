<script>
  //struktura propertyManagerDTO
  // let PropertyManagerDTO = {
  //   id: "",
  //   name: "",
  //   phoneNumber: "",
  //   fullAddress: {
  //     buildingAddress: {
  //       cityName: "",
  //       streetName: "",
  //       buildingNumber: "",
  //       postalCode: "",
  //     },
  //     localNumber: "",
  //     staircaseNumber: "",
  //   },
  // };
  export let PropertyManagerDTO;
  export let message;
  console.log(PropertyManagerDTO);
</script>
<div class="w-[50%] h-[50%] text-center relative my-[10%] mx-auto bg-white rounded-2xl pt-10 px-2">
  {#if PropertyManagerDTO == null}
    Nie udało się odczytać danych Zarządcy Nieruchomości.
  {:else}
    <p>{message} </p>
    <p>Imię i nazwisko: <span class="font-semibold">{PropertyManagerDTO.name}</span></p>
    Adres: 
    <span class="font-semibold">
    {#if PropertyManagerDTO.fullAddress.buildingAddress.postalCode != null}
      {PropertyManagerDTO.fullAddress.buildingAddress.postalCode}
    {/if}
    {PropertyManagerDTO.fullAddress.buildingAddress.cityName}, 
    {PropertyManagerDTO.fullAddress.buildingAddress.streetName}
    {PropertyManagerDTO.fullAddress.buildingAddress.buildingNumber}{#if PropertyManagerDTO.fullAddress.localNumber != ""}
    /{PropertyManagerDTO.fullAddress.localNumber} 
    {/if}
    {#if PropertyManagerDTO.fullAddress.staircaseNumber != ""}
      klatka {PropertyManagerDTO.fullAddress.staircaseNumber}
    {/if} </span>
    <br />
     <p>Nr telefonu:
      <span class="font-semibold">{PropertyManagerDTO.phoneNumber}</span>
  </p>
    <br>
  {/if}
  </div>
