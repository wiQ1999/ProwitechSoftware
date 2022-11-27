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
<div class="outside">
<div class="add-property-manager-popUp">
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
    <a href="/" class="button">Powrót do strony głównej</a>
  {/if}
  </div>
</div>

<style>
  .button {
    text-decoration:none;
    color: black;
    padding: 1%;
    margin-top: 5%;
    background-color: pink;
    border-radius: 7px;
    justify-content: center;
    cursor: pointer;
  }

  .add-property-manager-popUp{
    width: 50%;
    height: 50%;
    position: relative;
    margin: 10% auto;
    background-color: white;
    border-radius: 20px;
    padding: 2%;
  }
</style>
