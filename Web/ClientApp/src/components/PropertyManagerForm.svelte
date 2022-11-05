<script>
  export let onSubmit = () => {};
  export let addBuildingAddressDTO = {
    cityName: "",
    streetName: "",
    buildingNumber: "",
  };
  export let CreatePropertyManagerCommand = {
    name: "",
    phoneNumber: "",
    fullAddressDTO: {
      buildingAddressId: "",
      localNumber: "",
      staircaseNumber: "",
    },
  };

  let cities = [
    { id: "Bydgoszcz", name: "Bydgoszcz" },
    { id: "Poznań", name: "Poznań" },
    { id: "Wrocław", name: "Wrocław" },
  ];
</script>

<form on:submit|preventDefault={onSubmit}>
  <div>
    <label for="building-address-city-name">Miejscowość</label>
    <select bind:value={addBuildingAddressDTO.cityName}>
      {#each cities as city}
        <option value={city.id}>{city.name}</option>
      {/each}
    </select>
  </div>
  <div>
    <label for="property-manager-name">Nazwa Zarządcy Nieruchomości</label>
    <input type="text" bind:value={CreatePropertyManagerCommand.name} />
    <label for="property-manager-phone-number">Numer telefonu</label>
    <input type="text" bind:value={CreatePropertyManagerCommand.phoneNumber} />
    <label for="property-manager-name">Nazwa ulicy</label>
    <input type="text" bind:value={addBuildingAddressDTO.streetName} />
    <label for="building-address-building-number">Numer budynku</label>
    <input type="text" bind:value={addBuildingAddressDTO.buildingNumber} />
    <label for="property-manager-local-number">Numer lokalu (opcjonalnie)</label
    >
    <input type="text" bind:value={CreatePropertyManagerCommand.localNumber} />
    <label for="property-manager-staircase-number"
      >Numer klatki schodowej (opcjonalnie)</label
    >
    <input
      type="text"
      bind:value={CreatePropertyManagerCommand.staircaseNumber}
    />
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
