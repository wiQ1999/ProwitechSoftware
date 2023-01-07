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

<form on:submit|preventDefault={onSubmit}
  class="w-1/2 my-[10px] mx-auto py-3 px-5 bg-[#f4f7f8] rounded-lg text-center">

  <fieldset class="border-none">
    <legend class="font-bold text-lg py-5">Dodaj Zarządce budynku</legend>
    <label for="building-address-city-name" class="block">Miejscowość</label>
    <select bind:value={buildingAddressDTO.cityName} class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] text-[#8a97a9] border-2 focus:border-[#0078c8]">
      {#each cities as city}
      {#if city.id == "Poznań"}
        <option value={city.id}>{city.name} xd</option>
      {:else}
        <option value={city.id}>{city.name}</option>
      {/if}
      {/each}
    </select>
    
    <label for="property-manager-name" class="block">Nazwa Zarządcy Nieruchomości</label>
    <input type="text" bind:value={propertyManagerDTO.name} required class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] text-[#8a97a9] border-2 focus:border-[#0078c8]"/> <br>
    
    <label for="property-manager-phone-number" class="block">Numer telefonu (opcjonalne - 9 znaków)</label>
    <input type="text" minlength="9" maxlength="9" bind:value={propertyManagerDTO.phoneNumber} required class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] text-[#8a97a9] border-2 focus:border-[#0078c8]" /> <br>
    
    <label for="property-manager-name" class="block">Nazwa ulicy</label>
    <input type="text" bind:value={buildingAddressDTO.streetName} required class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] text-[#8a97a9] border-2 focus:border-[#0078c8]"/> <br>
    
    <label for="building-address-building-number" class="block">Numer budynku</label>
    <input type="text" bind:value={buildingAddressDTO.buildingNumber} required class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] text-[#8a97a9] border-2 focus:border-[#0078c8]"/> <br>
    
    <label for="property-manager-local-number" class="block">Numer lokalu (opcjonalne)</label>
    <input type="text" bind:value={propertyManagerDTO.fullAddress.localNumber} class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] text-[#8a97a9] border-2 focus:border-[#0078c8]"/><br>

    <label for="property-manager-staircase-number" class="block">Numer klatki schodowej (opcjonalne)</label>
    <input type="text" bind:value={propertyManagerDTO.fullAddress.staircaseNumber} class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] text-[#8a97a9] border-2 focus:border-[#0078c8]"/>
  </fieldset>
    <button type="submit" class="py-5 px-10 bg-[#0078c8] text-lg font-normal rounded-md w-[90%] mb-3 justify-center cursor-pointer">DODAJ!</button>
  
</form>