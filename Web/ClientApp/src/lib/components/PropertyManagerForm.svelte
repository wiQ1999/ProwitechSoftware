<script>
  import { onMount } from "svelte";

  // struktura propertyManageraDTO (GET)
  // {
  //   "id": "4b8855bc-1057-41dd-0a56-08dabf373e96",
  //   "name": "AZS",
  //   "phoneNumber": "+48 563 212 321",
  //   "fullAddress": {
  //     "id": "d3bc1437-a363-4d7c-5487-08dabf373e80",
  //     "buildingAddressId": "47054ff8-e3c3-4034-8629-bdc4da733944",
  //     "buildingAddress": {
  //       "id": "47054ff8-e3c3-4034-8629-bdc4da733944",
  //       "cityName": "Bydgoszcz",
  //       "streetName": "Nowodworska",
  //       "buildingNumber": "23",
  //       "longitude": 17.9975397,
  //       "latitude": 53.1179582,
  //       "coordinateType": "ROOFTOP",
  //       "postalCode": "85-124"
  //     },
  //     "localNumber": "1",
  //     "staircaseNumber": "25"
  //   }
  // }

  export let onSubmit = () => {};
  export let buildingAddressDTO = {
    cityName: "",
    streetName: "",
    buildingNumber: "",
  };
  export let propertyManagerDTO = {
    name: "",
    phoneNumber: "",
    fullAddress: {
      buildingAddressId: "",
      localNumber: "",
      staircaseNumber: "",
    },
  };
  // onMount({});

  let cities = [
    { id: "Bydgoszcz", name: "Bydgoszcz" },
    { id: "Poznań", name: "Poznań" },
    { id: "Wrocław", name: "Wrocław" },
  ];
</script>

<form on:submit|preventDefault={onSubmit}>

  <fieldset>
    <legend> <h1> Dodaj Zarządce budynku </h1> </legend>
    <label for="building-address-city-name">Miejscowość</label>
    <select bind:value={buildingAddressDTO.cityName}>
      {#each cities as city}
        <option value={city.id}>{city.name}</option>
      {/each}
    </select>
    
    <label for="property-manager-name">Nazwa Zarządcy Nieruchomości</label>
    <input type="text" bind:value={propertyManagerDTO.name} required /> <br>
    
    <label for="property-manager-phone-number">Numer telefonu *</label>
    <input type="text" bind:value={propertyManagerDTO.phoneNumber} required/> <br>
    
    <label for="property-manager-name">Nazwa ulicy</label>
    <input type="text" bind:value={buildingAddressDTO.streetName} required /> <br>
    
    <label for="building-address-building-number">Numer budynku</label>
    <input type="text" bind:value={buildingAddressDTO.buildingNumber} required /> <br>
    
    <label for="property-manager-local-number">Numer lokalu *</label>
    <input type="text" bind:value={propertyManagerDTO.fullAddress.localNumber} /><br>
    <label for="property-manager-staircase-number">Numer klatki schodowej *</label>
    <input type="text" bind:value={propertyManagerDTO.fullAddress.staircaseNumber}/>
  </fieldset>
    <button type="submit">Submit</button>
  
</form>

<style>
  * {
    box-sizing: border-box;
  }

  form {
  max-width: 50%;
  margin: 10px auto;
  padding: 10px 20px;
  background: #f4f7f8;
  border-radius: 8px;
  text-align: center;
  }

  input,select {
  background: rgba(255,255,255,0.1);
  border: none;
  font-size: 16px;
  height: auto;
  margin: 0;
  outline: 0;
  padding: 15px;
  width: 100%;
  background-color: #e8eeef;
  color: #8a97a9;
  box-shadow: 0 1px 0 rgba(0,0,0,0.03) inset;
  margin-bottom: 30px;
  }

  label {
    display: block;
  }

  fieldset {
    border: none;
    text-align: center;
  }

  button {
    padding: 19px 39px 18px 39px;

  background-color: #b4e8a5;
  font-size: 18px;
  text-align: center;
  font-style: normal;
  border-radius: 5px;
  width: 100%;
  box-shadow: 0 -1px 0 rgba(255,255,255,0.1) inset;
  margin-bottom: 10px;
  }


</style>
