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

<div class ="outside">
  <div class="inside">
  {#if PropertyManagerDTO == null}
    Nie udało się odczytać danych Zarządcy Nieruchomości.
  {:else}
  <h2> Sukces! </h2>
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
  .outside {
    width: 100%;
    height: 100%;
    margin: 0;
    padding: 0;
    position: fixed;
    top:0;
    left:0;
    background-color: rgba(0,0,0,0.7)
  }
  .inside {
    width: 50%;
    height: 50%;
    position: relative;
    margin: 10% auto;
    background-color: white;
    border-radius: 20px;
    padding: 2%;
  }

  .button {
    text-decoration:none;
    color: black;
    padding: 1%;
    margin-top: 5%;
    background-color: pink;
    border-radius: 7px;
  }
</style>
