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
  //struktura BuildingDTO (GET/{id}):
  //   {
  //   "id": "472e6029-2cfb-483e-f2ff-08daca1119fe",
  //   "buildingAddress": {
  //     "id": "d24bd875-c5f8-4a7c-a1c3-ff33f67b6c67",
  //     "cityName": "Poznań",
  //     "streetName": "Heweliusza",
  //     "buildingNumber": "3",
  //     "longitude": 16.8725373,
  //     "latitude": 52.394716,
  //     "coordinateType": "ROOFTOP",
  //     "postalCode": "61-001"
  //   },
  //   "type": "wielolokalowy",
  //   "locals": [],
  //   "propertyManager": {
  //     "id": "a9cc9b5b-9f73-4bc6-0f76-08dac7a32061",
  //     "name": "Fruwające krowy",
  //     "phoneNumber": "+48 956 232 125",
  //     "fullAddress": {
  //       "id": "69220a87-62c1-4953-4cde-08dac7a32055",
  //       "buildingAddressId": "c16ec69d-0583-4df6-b00f-6ea20754b392",
  //       "buildingAddress": null,
  //       "localNumber": "15",
  //       "staircaseNumber": "C"
  //     }
  //   }

    import Page from "../../routes/PropertyManager/getAll/+page.svelte";

  // }
  export let BuildingDTO;
  export let message1;
  export let message2;
</script>

<div class="w-[50%] h-[50%] relative my-[10%] mx-auto bg-white rounded-lg pt-10 p-1">
  {#if BuildingDTO == null}
    Nie udało się odczytać danych budynku.
  {:else}
    <p>{message1}</p>
    <br />

    Ulica: <span class="font-semibold">{BuildingDTO.buildingAddress.streetName}
    {BuildingDTO.buildingAddress.buildingNumber} </span>
    <br />
    Miasto: <span class="font-semibold">{BuildingDTO.buildingAddress.cityName} </span>
    <br />
    {#if BuildingDTO.buildingAddress.postalCode != null}
      Kod pocztowy: <span class="font-semibold">{BuildingDTO.buildingAddress.postalCode} </span>
    {/if}
    <br />
    Rodzaj: <span class="font-semibold">{BuildingDTO.type} </span>
    {#if BuildingDTO.propertyManager}
      <p>{message2}
        <span class="font-semibold">{BuildingDTO.propertyManager.name} </span> </p>
    {/if}
    <br />
  {/if}
</div>
