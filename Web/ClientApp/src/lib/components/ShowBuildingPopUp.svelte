<script>
  // struktura propertyManageraDTO (GET)
  //  {
  //     "id": "c9ddf3b2-517d-4ca8-1d90-08daf254a448",
  //     "name": "Admico",
  //     "phoneNumber": "555555555",
  //     "fullAddress": {
  //       "id": "46c83a7e-0842-4ead-b2a3-08daf254a437",
  //       "buildingAddressId": "9bf0c610-95d4-4c51-abb7-f6c7cb031de2",
  //       "buildingAddress": {
  //         "id": "9bf0c610-95d4-4c51-abb7-f6c7cb031de2",
  //         "cityName": "Bydgoszcz",
  //         "streetName": "Sienkiewicza",
  //         "buildingNumber": "22",
  //         "longitude": 18.0014692,
  //         "latitude": 53.130996,
  //         "coordinateType": "ROOFTOP",
  //         "postalCode": "85-000"
  //       },
  //       "propertyAddressId": "a6daebf1-c1a0-4a89-525b-08daf254a42b",
  //       "propertyAddress": {
  //         "id": "a6daebf1-c1a0-4a89-525b-08daf254a42b",
  //         "venueNumber": "33",
  //         "staircaseNumber": "12"
  //       }
  //     }
  //   }

  //TODO  struktura BuildingDTO (GET/{id}):
  export let BuildingDTO;
  export let message1;
  export let message2;
</script>

<div
  class="w-[50%] h-[50%] relative my-[10%] mx-auto bg-white rounded-lg pt-10 p-1"
>
  {#if BuildingDTO == null}
    Nie udało się odczytać danych budynku.
  {:else}
    <p>{message1}</p>
    <br />

    Ulica:
    <span class="font-semibold"
      >{BuildingDTO.buildingAddress.streetName}
      {BuildingDTO.buildingAddress.buildingNumber}
    </span>
    <br />
    Miasto:
    <span class="font-semibold">{BuildingDTO.buildingAddress.cityName} </span>
    <br />
    {#if BuildingDTO.buildingAddress.postalCode != null}
      Kod pocztowy: <span class="font-semibold"
        >{BuildingDTO.buildingAddress.postalCode}
      </span>
    {/if}
    <br />
    Rodzaj: <span class="font-semibold">{BuildingDTO.type} </span>
    {#if BuildingDTO.propertyManager}
      <p>
        {message2}
        <span class="font-semibold">{BuildingDTO.propertyManager.name} </span>
      </p>
    {/if}
    <br />
  {/if}
</div>
