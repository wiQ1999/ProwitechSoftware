import { writable } from "svelte/store";

export const CreatePropertyManagerCommand = writable({
  name: "",
  phoneNumber: "",
  fullAddressDTO: {
    buildingAddressId: "",
    localNumber: "",
    staircaseNumber: "",
  },
});
