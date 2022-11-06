<script>
  // struktura propertyManagera przy GET:
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
  export let PropertyManagerCommand = {
    name: "",
    phoneNumber: "",
    fullAddressDTO: {
      buildingAddressId: "",
      localNumber: "",
      staircaseNumber: "",
    },
  };
  // export let fillBlanks;

  let cities = [
    { id: "Bydgoszcz", name: "Bydgoszcz" },
    { id: "Poznań", name: "Poznań" },
    { id: "Wrocław", name: "Wrocław" },
  ];
</script>

<form on:submit|preventDefault={onSubmit}>
  <div>
    <label for="building-address-city-name">Miejscowość</label>
    <select bind:value={buildingAddressDTO.cityName}>
      {#each cities as city}
        <option value={city.id}>{city.name}</option>
      {/each}
    </select>
  </div>
  <div>
    <label for="property-manager-name">Nazwa Zarządcy Nieruchomości</label>
    <input type="text" bind:value={PropertyManagerCommand.name} />
    <label for="property-manager-phone-number">Numer telefonu</label>
    <input type="text" bind:value={PropertyManagerCommand.phoneNumber} />
    <label for="property-manager-name">Nazwa ulicy</label>
    <input type="text" bind:value={buildingAddressDTO.streetName} />
    <label for="building-address-building-number">Numer budynku</label>
    <input type="text" bind:value={buildingAddressDTO.buildingNumber} />
    <label for="property-manager-local-number">Numer lokalu (opcjonalnie)</label
    >
    <input type="text" bind:value={PropertyManagerCommand.localNumber} />
    <label for="property-manager-staircase-number"
      >Numer klatki schodowej (opcjonalnie)</label
    >
    <input type="text" bind:value={PropertyManagerCommand.staircaseNumber} />
  </div>
  <button type="submit">Submit</button>
</form>

<style>
  * {
    box-sizing: border-box;
  }
  form {
    display: flex;
    width: 300px;
  }
</style>
