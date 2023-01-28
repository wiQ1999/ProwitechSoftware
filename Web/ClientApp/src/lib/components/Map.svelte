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

<div class="flex justify-center mb-8">
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
    <div class="lack-of-coordinates">
      BRAK WSPÓŁRZĘDNYCH, NIE MOGĘ WYŚWIETLIĆ MAPY
    </div>
  {/if}
  {#if inaccurateCoordinates && mapForTask}
    <div>
      UWAGA: WSPÓŁRZĘDNE POBRANE Z BAZY DANYCH NIE SĄ DOKŁADNE. SPRAWDŹ
      DOKŁADNIE, DOKĄD JEDZIESZ.
    </div>
  {/if}
  {#if mapVisibility}
    <div class="full-screen border-2 border-black" bind:this={container} />
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
