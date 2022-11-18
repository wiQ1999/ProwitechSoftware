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
  export let BuildingDTO;
  export let message1;
  export let message2;
</script>

<div>
  {#if BuildingDTO == null}
    Nie udało się odczytać danych budynku.
  {:else}
    {message1}
    <br />

    {BuildingDTO.buildingAddress.streetName}
    <br />
    {BuildingDTO.buildingAddress.buildingNumber}
    <br />
    {BuildingDTO.buildingAddress.cityName}
    <br />
    {#if BuildingDTO.buildingAddress.postalCode != null}
      {BuildingDTO.buildingAddress.postalCode}
    {/if}
    <br />
    {message2}
    {BuildingDTO.propertyManager.name}
    <br />

    <a href="/index" class="button">Powrót do strony głównej</a>
  {/if}
</div>
