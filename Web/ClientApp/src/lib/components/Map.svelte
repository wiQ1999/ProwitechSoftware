<script>
  import { Loader } from "@googlemaps/js-api-loader";
  import { onMount } from "svelte";
  import { env } from "$env/dynamic/public";
  // import {getBui}
  // import mapStyles from "./map-styles"; // optional

  const POZNAN_LATITUDE = 52.409538;
  const POZNAN_LONGITUDE = 16.931992;
  export let buildingsArray;

  let loadError;
  let container;
  let map;
  let errorMessage = "Nie udało się pobrać mapy";
  let api_key = env.PUBLIC_GOOGLE_DISPLAY_MAP_API_KEY;

  const loader = new Loader({
    apiKey: api_key,
    version: "weekly",
    libraries: ["marker"],
  });
  // let zoom = 8;
  // let center = { lat: -34.397, lng: 150.644 };

  function addMarker(location, address) {
    const contentString = `<h4>${address.streetName} ${address.buildingNumber} ${address.cityName}</h4>`;
    const pinViewScaled = new google.maps.marker.PinView({
      scale: 1.5,
    });
    // const marker = new google.maps.AdvancedMarkerView({
    //   position: location,
    //   map,
    //   // title: `${address.streetName} ${address.buildingNumber}`,
    //   content: pinViewScaled.element,
    // });
    const markerViewScaled = new google.maps.marker.AdvancedMarkerView({
      map,
      position: { lat: 37.419, lng: -122.02 },
      content: pinViewScaled.element,
    });
    // const infoWindow = new google.maps.InfoWindow({
    //   content: contentString,
    //   ariaLabel: "Uluru",
    // });
    // marker.addListener("mouseover", () => {
    //   infoWindow.open({
    //     anchor: marker,
    //     map,
    //   });
    // });
  }
  function setMap() {
    map = new google.maps.Map(container, {
      center: { lat: 37.419, lng: -122.02 },
      zoom: 12,
    });
    if (buildingsArray.length >= 0) {
      for (let building of buildingsArray) {
        addMarker(
          {
            lat: building.buildingAddress.latitude,
            lng: building.buildingAddress.longitude,
          },
          building.buildingAddress
        );
      }
    }
  }

  onMount(async () => {
    console.log(buildingsArray);
    loader
      .load()
      .then(() => {
        setMap();
      })
      .catch((err) => {
        errorMessage = err;
        loadError = true;
      });

    // markerView.addListener("click", ({ domEvent, latLng }) => {
    //   const { target } = domEvent;
    //   // Handle the click event.
    //   // ...
    // });
  });
</script>

<div>
  <div class="full-screen" bind:this={container} />
  {#if loadError == true}
    <div>
      {errorMessage}
    </div>
  {/if}
  <h1>{import.meta.env.VITE_TEST_VAR}</h1>
</div>

<style>
  .full-screen {
    width: 100vw;
    height: 100vh;
  }
</style>
