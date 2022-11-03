<script>
  import { writable } from "svelte/store";

  export const addBuildingAddressDTO = writable({
    cityName: "",
    streetName: "",
    buildingNumber: "",
  });
  export const PropertyManagerDTO = writable({
    id: "",
    name: "",
    phoneNumber: "",
    fullAddress: {
      buildingAddress: {
        cityName: "",
        streetName: "",
        buildingNumber: "",
        postalCode: "",
      },
      localNumber: "",
      staircaseNumber: "",
    },
  });
</script>

<div>hello</div>
