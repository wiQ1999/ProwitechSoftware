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
<div class="w-[100%] h-[100%] fixed m-0 p-0 top-0 left-0 bg-black/70">
<div class="w-[50%] h-[50%] text-center relative my-5 mx-auto bg-white rounded-2xl pt-10 px-2">
  {#if PropertyManagerDTO == null}
    Nie udało się odczytać danych Zarządcy Nieruchomości.
  {:else}
    <p>{message} </p>
    <p>Imię i nazwisko: <b>{PropertyManagerDTO.name}</b></p>
    Adres: 
    <b>
    {#if PropertyManagerDTO.fullAddress.buildingAddress.postalCode != null}
      {PropertyManagerDTO.fullAddress.buildingAddress.postalCode}
    {/if}
    {PropertyManagerDTO.fullAddress.buildingAddress.cityName}, 
    {PropertyManagerDTO.fullAddress.buildingAddress.streetName}
    {PropertyManagerDTO.fullAddress.buildingAddress.buildingNumber}
      </b>
    {#if PropertyManagerDTO.fullAddress.localNumber != ""}
      /{PropertyManagerDTO.fullAddress.localNumber} 
    {/if}
    {#if PropertyManagerDTO.fullAddress.staircaseNumber != ""}
      klatka {PropertyManagerDTO.fullAddress.staircaseNumber}
    {/if}
    <br />
     <p>Nr telefonu:
    <b>{PropertyManagerDTO.phoneNumber} </b>
  </p>
    <br>
  {/if}
  </div>
</div>
