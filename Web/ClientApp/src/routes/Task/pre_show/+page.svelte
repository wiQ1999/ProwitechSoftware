<script>
  import { onMount } from "svelte";
  import Map from "$lib/components/Map.svelte";
  import { getAllBuildings } from "$lib/stores/Building.js";

  let buildingsArray;
  let mapVisibility;
  onMount(async () => {
    let getAllBuildingsResult = await getAllBuildings();
    if (getAllBuildingsResult instanceof Response) {
      buildingsArray = await getAllBuildingsResult.json();
      // console.log(buildingsArray);
      mapVisibility = true;
    }
  });
</script>

<div>
  {#if mapVisibility}
    <Map {buildingsArray} />
  {/if}
</div>

<style>
  :global(body) {
    padding: 0;
  }
</style>
