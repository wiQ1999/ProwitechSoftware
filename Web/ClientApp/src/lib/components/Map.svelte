<script>
  import { Loader } from "@googlemaps/js-api-loader";
  import { onMount } from "svelte";
  import { env } from "$env/dynamic/public";

  export let building;
  export let displayLink = false;
  export let displayBuildingInfo = false;
  export let mapForTask = false;

  let loadError;
  let container;
  let map;
  let mapVisibility;
  let errorMessage = "Nie udało się pobrać mapy";
  let api_key = env.PUBLIC_GOOGLE_DISPLAY_MAP_API_KEY;
  let inaccurateCoordinates = false;
  let lackOfCoordinates = false;

  const loader = new Loader({
    apiKey: api_key,
    version: "weekly",
    libraries: ["marker"],
  });

  onMount(async () => {
    if (
      building.buildingAddress.longitude == null ||
      building.buildingAddress.latitude == null
    ) {
      lackOfCoordinates = true;
      container = "BRAK WSPÓŁRZĘDNYCH, NIE MOGĘ WYŚWIETLIĆ MAPY";
      return;
    }
    if (building.buildingAddress.coordinateType != "ROOFTOP") {
      inaccurateCoordinates = true;
    }
    loader
      .load()
      .then(() => {
        setMap();
      })
      .catch((err) => {
        errorMessage = err;
        loadError = true;
      });
    mapVisibility = true;
  });

  function setMap() {
    map = new google.maps.Map(container, {
      center: {
        lat: building.buildingAddress.latitude,
        lng: building.buildingAddress.longitude,
      },
      zoom: 14,
      zoomControl: true,
      mapTypeControl: true,
      scaleControl: true,
      streetViewControl: true,
      rotateControl: true,
      fullscreenControl: true,
    });

    addMarker(
      map,
      {
        lat: building.buildingAddress.latitude,
        lng: building.buildingAddress.longitude,
      },
      building.buildingAddress
    );
  }
  function addMarker(map, location, address) {
    let contentString = `<h4>${address.streetName} ${address.buildingNumber} ${address.cityName}</h4>`;
    if (displayLink) {
      contentString =
        contentString +
        `<a href="https://maps.google.com?q=${location.lat},${location.lng}" target="_blank">Wyznacz trasę</a>`;
    }
    const marker = new google.maps.Marker({
      position: location,
      map,
    });

    const infoWindow = new google.maps.InfoWindow({
      content: contentString,
      ariaLabel: "Uluru",
    });
    infoWindow.open({
      anchor: marker,
      map,
    });
    // marker.addListener("mouseover", () => {
    //   infoWindow.open({
    //     anchor: marker,
    //     map,
    //   });
    // });
    // marker.addListener("mouseout", () => {
    //   infoWindow.close();
    // });
  }
</script>

<div class="text-center justify-center mb-8">
  {#if displayBuildingInfo}
    <div class="building-info border-2 border-black">
      <table>
        <tr>
          <td>Ulica</td>
          <td>{building.buildingAddress.streetName}</td>
        </tr>
        <tr>
          <td>Numer budynku</td>
          <td>{building.buildingAddress.buildingNumber}</td>
        </tr>
      </table>
    </div>
  {/if}
  {#if lackOfCoordinates}
    <div
      class="font-semibold mx-auto border-2 w-[50%] border-slate-600 text-center py-6"
    >
      <img
        src="../../src/lib/images/exclamation-mark.png"
        alt="wykrzyknik"
        class="w-10 mx-auto py-1"
      />
      BRAK WSPÓŁRZĘDNYCH, NIE MOGĘ WYŚWIETLIĆ MAPY
    </div>
  {/if}
  {#if inaccurateCoordinates && mapForTask}
    <div class="underline font-semibold mb-2">
      UWAGA! <br />
      WSPÓŁRZĘDNE POBRANE Z BAZY DANYCH NIE SĄ PRECYZYJNE. <br />
      SPRAWDŹ DOKŁADNIE, DOKĄD JEDZIESZ.
    </div>
  {/if}
  {#if mapVisibility}
    <div
      class="justify-center mx-auto full-screen border-2 border-black"
      bind:this={container}
    />
  {/if}
  {#if loadError == true}
    <div>
      {errorMessage}
    </div>
  {/if}
</div>

<style>
  .full-screen {
    width: 50vw;
    height: 50vh;
  }
</style>
