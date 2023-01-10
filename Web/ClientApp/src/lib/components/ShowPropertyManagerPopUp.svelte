<script>
  // struktura propertyManageraDTO (GET)
  // {
  //   "id": "c9ddf3b2-517d-4ca8-1d90-08daf254a448",
  //   "name": "Admico",
  //   "phoneNumber": "555555555",
  //   "fullAddress": {
  //     "id": "46c83a7e-0842-4ead-b2a3-08daf254a437",
  //     "buildingAddressId": "9bf0c610-95d4-4c51-abb7-f6c7cb031de2",
  //     "buildingAddress": {
  //       "id": "9bf0c610-95d4-4c51-abb7-f6c7cb031de2",
  //       "cityName": "Bydgoszcz",
  //       "streetName": "Sienkiewicza",
  //       "buildingNumber": "22",
  //       "longitude": 18.0014692,
  //       "latitude": 53.130996,
  //       "coordinateType": "ROOFTOP",
  //       "postalCode": "85-000"
  //     },
  //     "propertyAddressId": "a6daebf1-c1a0-4a89-525b-08daf254a42b",
  //     "propertyAddress": {
  //       "id": "a6daebf1-c1a0-4a89-525b-08daf254a42b",
  //       "venueNumber": "33",
  //       "staircaseNumber": "12"
  //     }
  //   }
  // }
  export let PropertyManagerDTO;
  export let message;
  console.log(PropertyManagerDTO);
</script>

<div
  class="w-[50%] h-[50%] text-center relative my-[10%] mx-auto bg-white rounded-2xl pt-10 px-2"
>
  {#if PropertyManagerDTO == null}
    Nie udało się odczytać danych Zarządcy Nieruchomości.
  {:else}
    <p>{message}</p>
    <p>
      Imię i nazwisko: <span class="font-semibold"
        >{PropertyManagerDTO.name}</span
      >
    </p>
    Adres:
    <span class="font-semibold">
      {#if PropertyManagerDTO.fullAddress.buildingAddress.postalCode != null}
        {PropertyManagerDTO.fullAddress.buildingAddress.postalCode}
      {/if}
      {PropertyManagerDTO.fullAddress.buildingAddress.cityName},
      {PropertyManagerDTO.fullAddress.buildingAddress.streetName}
      {PropertyManagerDTO.fullAddress.buildingAddress.buildingNumber}
      {#if PropertyManagerDTO.fullAddress.propertyAddress}
        {#if PropertyManagerDTO.fullAddress.propertyAddress.venueNumber != ""}
          m. {PropertyManagerDTO.fullAddress.propertyAddress.venueNumber}
        {/if}
        {#if PropertyManagerDTO.fullAddress.propertyAddress.staircaseNumber != ""}
          klatka {PropertyManagerDTO.fullAddress.propertyAddress
            .staircaseNumber}
        {/if}
      {/if}
    </span>
    <br />
    <p>
      Nr telefonu:
      <span class="font-semibold">{PropertyManagerDTO.phoneNumber}</span>
    </p>
    <br />
  {/if}
</div>
