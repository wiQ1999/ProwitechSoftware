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

<div>
  {#if PropertyManagerDTO == null}
    Nie udało się odczytać danych Zarządcy Nieruchomości.
  {:else}
    {message}
    {PropertyManagerDTO.name}
    <br />
    {PropertyManagerDTO.fullAddress.buildingAddress.cityName}
    <br />
    {PropertyManagerDTO.fullAddress.buildingAddress.streetName}
    <br />
    {PropertyManagerDTO.fullAddress.buildingAddress.buildingNumber}
    <br />
    {#if PropertyManagerDTO.fullAddress.localNumber != null}
      {PropertyManagerDTO.fullAddress.localNumber}
      <br />
    {/if}
    {#if PropertyManagerDTO.fullAddress.staircaseNumber != null}
      {PropertyManagerDTO.fullAddress.staircaseNumber}
      <br />
    {/if}
    {#if PropertyManagerDTO.fullAddress.buildingAddress.postalCode != null}
      {PropertyManagerDTO.fullAddress.buildingAddress.postalCode}
    {/if}
    <br />
    {PropertyManagerDTO.phoneNumber}
    <a href="/index" class="button">Powrót do strony głównej</a>
  {/if}
</div>
