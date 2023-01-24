<script>
  import { onMount } from "svelte";
  import Map from "$lib/components/Map.svelte";
  import { getAllUsers } from "$lib/stores/Users";
  import { getAllBuildings, getBuildingById } from "$lib/stores/Building";
  import { prepareDateTime, formatDate } from "$lib/js-lib/helpers";
  import { getProtocolBiggestNumberForToday } from "$lib/stores/InspectionProtocol";

  export let onSubmit = async () => {};
  export let CreateInspectionProtocolCommand = {
    residentDTO: {
      firstName: "",
      lastName: "",
      phoneNumber: "",
    },
    number: "",
    inspectionProtocolDTO: {
      inspectionTaskId: null,
      inspectionDateTime: "2023-01-22T16:27:32.460Z",
      inspectedPropertyId: null,
      inspectionPerformerId: "3fa85f64-5717-4562-b3fc-2c963f66afa6",
      a_01_Gazomierz_umiejscowienie: "",
      b_A_02_Gazomierz_szafka_wentylowana: true,
      b_A_03_Gazomierz_szczelnosc: true,
      a_04_Gazomierz_usytuowanie_w_stosunku_do_1_go_odbiornika: "",
      a_05_Gazomierz_usytuowanie_w_stosunku_do_licznika_energii_elektr: "",
      a_06_Gazomierz_kurek_przed_gazomierzem: "",
      m_A_07_Przewody_rodzaj: "",
      m_A_08_Przewody_przebieg: "",
      m_A_09_Przewody_sposob_prowadzenia: "",
      a_10_Przewody_przebieg_inst_gaz_przez_pokoje: "",
      a_11_Przewody_pion_inst_gaz_w_mieszkaniu: "",
      a_12_Prawidlowosc_kuchenka_gazowa_typ: "",
      a_13_Prawidlowosc_kuchenka_gazowa_stan: "",
      a_14_Prawidlowosc_kuchenka_gazowa_podlaczenie_rodzaj: "",
      a_15_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan: "",
      a_16_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy: "",
      a_17_Prawidlowosc_kuchenka_gazowa_odleglosc_od_okna: "",
      a_18_Prawidlowosc_gazowy_podgrzewacz_cwu_stan: "",
      a_19_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy: "",
      a_20_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa: "",
      a_21_Prawidlowosc_terma_gazowa_stan: "",
      a_22_Prawidlowosc_terma_gazowa_kurek_odcinajacy: "",
      a_23_Prawidlowosc_terma_gazowa_rura_spalinowa: "",
      a_24_Prawidlowosc_kociol_co_z_kurkiem_i_rura: "",
      a_25_Kubatura_warunku_techniczne: "",
      b_A_26_Wentylacja_kuchnia: true,
      b_A_27_Wentylacja_lazienka: true,
      b_A_28_Wentylacja_inne_pomieszczenia: true,
      b_A_29_Wentylacja_nawiew_kuchnia: true,
      b_A_30_Wentylacja_nawiew_lazienka: true,
      b_A_31_Wentylacja_nawiew_Zet_w_pomieszczeniu_z_kotlem: true,
      a_32_Wyniki_stan_szczelnosci: "",
      b_A_33_Wyniki_instalacja_wymaga_usuniecia_nieszczelnosci: true,
      b_A_34_Propan_butan: true,
      inne_uwagi: "",
    },
  };
  export let editMode = false;
  // export let taskId = null;
  // export let propertyId = null;
  export let creationThroughTask = false;
  let formVisibility;
  let upper_message = "Dodaj Protokół";
  let button_turn_on_edition_message = "Włącz edycję";
  let readMode = false;
  let submitButtonMessage = "DODAJ";

  let users = [];
  let buildings = [];
  let realProperties = [];
  let chosenBuilding;
  let chosenBuildingType = "";
  let today = prepareDateTime(new Date());
  let numberDate = formatDate(new Date(), false, true);

  let m_A_07_Przewody_rodzaj_array = [];
  let m_A_08_Przewody_przebieg_array = [];
  let m_A_09_Przewody_sposob_prowadzenia_array = [];

  let showRequiredForMultiple_07 = false;
  let showRequiredForMultiple_08 = false;
  let showRequiredForMultiple_09 = false;

  let multipleRequiredMessage = "Zaznacz wymagane pole";

  onMount(async () => {
    if (!editMode) CreateInspectionProtocolCommand.inspectionDateTime = today;

    readMode = editMode;

    if (editMode) {
      submitButtonMessage = "ZATWIERDŹ";
      upper_message = "Szczegóły Protokołu";
    }
    await prepareForm();
    formVisibility = true;
  });
  async function prepareForm() {
    let downloadBuildingsSuccess = true;
    if (!creationThroughTask) {
      await downloadUsers();
      downloadBuildingsSuccess = await downloadBuildingsAndRealProperties();
    }
    if (downloadBuildingsSuccess) formVisibility = true;
  }
  async function downloadUsers() {
    let usersResponse = await getAllUsers();
    for (let element of usersResponse) {
      users.push({
        id: element.id,
        firstName: element.firstName,
        lastName: element.lastName,
        login: element.login,
      });
    }
  }
  async function downloadBuildingsAndRealProperties() {
    let buildingsResponse = await getAllBuildings();
    if (buildingsResponse instanceof Error) return false;

    buildingsResponse = await buildingsResponse.json();

    for (let element of buildingsResponse) {
      buildings.push({
        id: element.id,
        streetName: element.buildingAddress.streetName,
        number: element.buildingAddress.buildingNumber,
        cityName: element.buildingAddress.cityName,
        type: element.type,
      });
    }

    let buildingGotById;

    let buildingResponse = await getBuildingById(buildings[0].id);
    if (buildingResponse instanceof Error) return false;
    buildingGotById = await buildingResponse.json();
    if (buildings[0].type == "JEDNOLOKALOWY") {
      CreateInspectionProtocolCommand.inspectionProtocolDTO.inspectedPropertyId =
        buildingGotById.properties[0].id;
    } else {
      realProperties = buildingGotById.properties;
    }
    return true;
  }
  async function getRealPropertiesOfChosenBuilding(buildingObj) {
    console.log("hello");
    chosenBuildingType = buildingObj.type;
    let buildingGotById;

    let buildingResponse = await getBuildingById(buildingObj.id);
    if (buildingResponse instanceof Error) return;
    buildingGotById = await buildingResponse.json();
    if (buildingObj.type == "JEDNOLOKALOWY") {
      CreateInspectionProtocolCommand.inspectionProtocolDTO.inspectedPropertyId =
        buildingGotById.properties[0].id;
    } else {
      realProperties = buildingGotById.properties;
    }
    console.log(realProperties);
  }

  function changeEditingStatus() {
    readMode = !readMode;
    if (button_turn_on_edition_message == "Włącz edycję") {
      button_turn_on_edition_message = "Zakończ edycję";
    } else {
      button_turn_on_edition_message = "Włącz edycję";
    }
    if (readMode) upper_message = "Szczegóły Zadania";
    else upper_message = "Edycja Zadania";
  }
  async function onBeforeSubmit() {
    showRequiredForMultiple_07 = !showRequiredForMultiple_07;
    showRequiredForMultiple_08 = !showRequiredForMultiple_08;
    showRequiredForMultiple_09 = !showRequiredForMultiple_09;
    if (m_A_07_Przewody_rodzaj_array.length == 0) {
      showRequiredForMultiple_07 = true;
    } else {
      showRequiredForMultiple_07 = false;
    }
    if (m_A_08_Przewody_przebieg_array.length == 0) {
      showRequiredForMultiple_08 = true;
    } else {
      showRequiredForMultiple_08 = false;
    }
    if (m_A_09_Przewody_sposob_prowadzenia_array.length == 0) {
      showRequiredForMultiple_09 = true;
    } else {
      showRequiredForMultiple_09 = false;
    }

    let multiple_07 = "";
    let multiple_08 = "";
    let multiple_09 = "";

    console.log(m_A_07_Przewody_rodzaj_array);
    for (var i = 0; i < m_A_07_Przewody_rodzaj_array.length; i++) {
      multiple_07 += m_A_07_Przewody_rodzaj_array[i] + ",";
    }
    for (let elem of m_A_08_Przewody_przebieg_array) {
      multiple_08 += elem;
      multiple_08 += ",";
    }
    for (let elem of m_A_09_Przewody_sposob_prowadzenia_array) {
      multiple_09 += elem;
      multiple_09 += ",";
    }
    // console.log(
    //   CreateInspectionProtocolCommand.inspectionProtocolDTO.inspectedPropertyId
    // );
    console.log(
      CreateInspectionProtocolCommand.inspectionProtocolDTO
        .inspectionPerformerId
    );
    //TODO IF CREATION THROUGH TASK
    // CreateInspectionProtocolCommand.inspectionProtocolDTO.inspectionPerformerId =
    // "030B7529-173C-41A8-953D-75BA46B7FC21";

    CreateInspectionProtocolCommand.inspectionProtocolDTO.m_A_07_Przewody_rodzaj =
      multiple_07;

    CreateInspectionProtocolCommand.inspectionProtocolDTO.m_A_08_Przewody_przebieg =
      multiple_08;
    CreateInspectionProtocolCommand.inspectionProtocolDTO.m_A_09_Przewody_sposob_prowadzenia =
      multiple_09;

    let number = await getProtocolBiggestNumberForToday(numberDate);
    if (number instanceof Response) {
      let json = await number.json();
      CreateInspectionProtocolCommand.number = json.number;
    }

    // await onSubmit();
  }
</script>

{#if formVisibility}
  <form
    on:submit|preventDefault={async () => await onBeforeSubmit()}
    class="w-[50%] my-3 mx-auto py-3 px-5 bg-[#f4f7f8] rounded-lg text-center"
  >
    <legend class="font-bold text-lg py-5"> {upper_message} </legend>
    {#if editMode}
      <button
        on:click|preventDefault={() => changeEditingStatus()}
        class="flex font-semibold bg-blue-400 mb-4 p-4 mx-auto rounded-md text-white"
        >{button_turn_on_edition_message}</button
      >
    {/if}
    {#if !creationThroughTask}
      <label for="inspection-protocol-building" class="block">Budynek</label>
      <select
        disabled={readMode}
        bind:value={chosenBuilding}
        required
        on:change={async () =>
          getRealPropertiesOfChosenBuilding(chosenBuilding)}
        class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]"
      >
        {#each buildings as b}
          <option value={b}>{b.streetName} {b.number} | {b.cityName}</option>
        {/each}
      </select>
      {#if chosenBuildingType == "WIELOLOKALOWY"}
        <label for="inspection-protocol-real-property">Nieruchomość:</label>
        <select
          bind:value={CreateInspectionProtocolCommand.inspectionProtocolDTO
            .inspectedPropertyId}
          class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]"
        >
          {#each realProperties as realProperty}
            <option value={realProperty.id}
              >{realProperty.propertyAddress.venueNumber}
              {realProperty.propertyAddress.staircaseNumber}
            </option>
          {/each}
        </select>
      {/if}

      <label for="inspection-task-performer" class="block"
        >Wykonujący Inspekcję</label
      >
      <select
        bind:value={CreateInspectionProtocolCommand.inspectionProtocolDTO
          .inspectionPerformerId}
        disabled={readMode}
        required
        class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]"
      >
        {#each users as user}
          <option value={user.id}
            >{user.firstName} {user.lastName} {user.login}
          </option>
        {/each}
      </select>
    {/if}
    <label for="resident-first-name">Imię mieszkańca</label>
    <input
      type="text"
      name="resident-first-name"
      maxlength="600"
      required
      bind:value={CreateInspectionProtocolCommand.residentDTO.firstName}
      class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]"
    />
    <label for="resident-last-name">Nazwisko mieszkańca</label>
    <input
      type="text"
      name="resident-first-last"
      maxlength="600"
      required
      bind:value={CreateInspectionProtocolCommand.residentDTO.lastName}
      class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]"
    />
    <label for="resident-phone-number">Telefon</label>
    <input
      type="text"
      name="resident-phone-number"
      maxlength="9"
      required
      bind:value={CreateInspectionProtocolCommand.residentDTO.phoneNumber}
      class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]"
    />

    <!--  ------------------------------------------- ||||| CZĘŚĆ I - GAZOMIERZ ||||| ------------------------------------------- -->
    <div class="part-1-gazomierz">
      Część I - GAZOMIERZ
      <!--  ------------------------------------------- PYTANIE  a_01_Gazomierz_umiejscowienie ------------------------------------------- -->
      <div
        class="question-a_01_Gazomierz_umiejscowienie min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
      >
        <label for="a_01_Gazomierz_umiejscowienie"
          >[1] Umiejscowienie gazomierza</label
        >
        <label>
          <input
            type="radio"
            name="a_01_Gazomierz_umiejscowienie"
            required
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_01_Gazomierz_umiejscowienie}
            value={"klatka schodowa"}
          />
          klatka schodowa
        </label>
        <label>
          <input
            type="radio"
            name="a_01_Gazomierz_umiejscowienie"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_01_Gazomierz_umiejscowienie}
            value={"korytarz"}
          />
          korytarz
        </label>
        <label>
          <input
            type="radio"
            name="a_01_Gazomierz_umiejscowienie"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_01_Gazomierz_umiejscowienie}
            value={"kuchnia/łazienka"}
          />
          kuchnia/łazienka
        </label>
        <label>
          <input
            type="radio"
            name="a_01_Gazomierz_umiejscowienie"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_01_Gazomierz_umiejscowienie}
            value={"inne"}
          />
          inne
        </label>
      </div>
      <!--  ------------------------------------------- PYTANIE  b_A_02_Gazomierz_szafka_wentylowana ------------------------------------------- -->
      <div
        class="question-b_A_02_Gazomierz_szafka_wentylowana min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
      >
        <label for="b_A_02_Gazomierz_szafka_wentylowana"
          >[2] Szafka wentylowana</label
        >
        <label>
          <input
            type="radio"
            name="b_A_02_Gazomierz_szafka_wentylowana"
            required
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .b_A_02_Gazomierz_szafka_wentylowana}
            value={true}
          />
          jest
        </label>
        <label>
          <input
            type="radio"
            name="b_A_02_Gazomierz_szafka_wentylowana"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .b_A_02_Gazomierz_szafka_wentylowana}
            value={false}
          />
          brak
        </label>
      </div>

      <!--  ------------------------------------------- PYTANIE  b_A_03_Gazomierz_szczelnosc ------------------------------------------- -->
      <div
        class="question-b_A_03_Gazomierz_szczelnosc min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
      >
        <label for="b_A_03_Gazomierz_szczelnosc"
          >[3] Gazomierz - szczelność</label
        >
        <label>
          <input
            type="radio"
            name="b_A_03_Gazomierz_szczelnosc"
            required
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .b_A_03_Gazomierz_szczelnosc}
            value={true}
          />
          szczelny
        </label>
        <label>
          <input
            type="radio"
            name="b_A_03_Gazomierz_szczelnosc"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .b_A_03_Gazomierz_szczelnosc}
            value={false}
          />
          nieszczelny
        </label>
      </div>
      <!--  --------------------------- PYTANIE a_04_Gazomierz_usytuowanie_w_stosunku_do_1_go_odbiornika------------------------------- -->
      <div
        class="question-a_04_Gazomierz_usytuowanie_w_stosunku_do_1_go_odbiornika min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
      >
        <label for="a_04_Gazomierz_usytuowanie_w_stosunku_do_1_go_odbiornika"
          >[4] Usytuowanie gazomierza w stosunku do pierwszego odbiornika</label
        >
        <label>
          <input
            type="radio"
            name="a_04_Gazomierz_usytuowanie_w_stosunku_do_1_go_odbiornika"
            required
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_04_Gazomierz_usytuowanie_w_stosunku_do_1_go_odbiornika}
            value={"prawidłowe"}
          />
          prawidłowe
        </label>
        <label>
          <input
            type="radio"
            name="a_04_Gazomierz_usytuowanie_w_stosunku_do_1_go_odbiornika"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_04_Gazomierz_usytuowanie_w_stosunku_do_1_go_odbiornika}
            value={"nieprawidłowe"}
          />
          nieprawidłowe
        </label>
      </div>
      <!--  --------------------------- PYTANIE a_05_Gazomierz_usytuowanie_w_stosunku_do_licznika_energii_elektr--------------------------- -->
      <div
        class="question-a_05_Gazomierz_usytuowanie_w_stosunku_do_licznika_energii_elektr min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
      >
        <label
          for="a_05_Gazomierz_usytuowanie_w_stosunku_do_licznika_energii_elektr"
          >[5] Usytuowanie gazomierza w stosunku do licznika energii
          elektrycznej</label
        >
        <label>
          <input
            type="radio"
            name="a_05_Gazomierz_usytuowanie_w_stosunku_do_licznika_energii_elektr"
            required
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_05_Gazomierz_usytuowanie_w_stosunku_do_licznika_energii_elektr}
            value={"prawidłowe"}
          />
          prawidłowe
        </label>
        <label>
          <input
            type="radio"
            name="a_05_Gazomierz_usytuowanie_w_stosunku_do_licznika_energii_elektr"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_05_Gazomierz_usytuowanie_w_stosunku_do_licznika_energii_elektr}
            value={"nieprawidłowe"}
          />
          nieprawidłowe
        </label>
      </div>
      <!--  --------------------------- PYTANIE a_06_Gazomierz_kurek_przed_gazomierzem--------------------------- -->
      <div
        class="question-a_06_Gazomierz_kurek_przed_gazomierzem min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
      >
        <label for="a_06_Gazomierz_kurek_przed_gazomierzem"
          >[6] Kurek przed gazomierzem</label
        >
        <label>
          <input
            type="radio"
            name="a_06_Gazomierz_kurek_przed_gazomierzem"
            required
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_06_Gazomierz_kurek_przed_gazomierzem}
            value={"kulowy"}
          />
          kulowy
        </label>
        <label>
          <input
            type="radio"
            name="a_06_Gazomierz_kurek_przed_gazomierzem"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_06_Gazomierz_kurek_przed_gazomierzem}
            value={"stożkowy"}
          />
          stożkowy
        </label>
      </div>
    </div>
    <!--  ------------------------------------------------------------------------------------------------------------------------ -->

    <!--  ------------------------------------------- ||||| CZĘŚĆ II - PRZEWODY ||||| ------------------------------------------- -->
    <div class="part-2-przewody">
      Część II - PRZEWODY
      <!--  ------------------------------------------- PYTANIE  m_A_07_Przewody_rodzaj ------------------------------------------- -->
      <div
        class="question-m_A_07_Przewody_rodzaj min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
      >
        <label for="m_A_07_Przewody_rodzaj">[7] Rodzaj przewodów</label>
        <label>
          <input
            type="checkbox"
            name="m_A_07_Przewody_rodzaj"
            bind:group={m_A_07_Przewody_rodzaj_array}
            value={"spawane"}
          />
          spawane
        </label>
        <label>
          <input
            type="checkbox"
            name="m_A_07_Przewody_rodzaj"
            bind:group={m_A_07_Przewody_rodzaj_array}
            value={"skręcane"}
          />
          skręcane
        </label>
        <label>
          <input
            type="checkbox"
            name="m_A_07_Przewody_rodzaj"
            bind:group={m_A_07_Przewody_rodzaj_array}
            value={"zaciskowe"}
          />
          zaciskowe
        </label>
        {#if showRequiredForMultiple_07}
          <div class="checkbox-required-message">
            {multipleRequiredMessage}
          </div>
        {/if}
      </div>
      <!--  ------------------------------------------- PYTANIE  m_A_08_Przewody_przebieg ------------------------------------------- -->
      <div
        class="question-m_A_08_Przewody_przebieg min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
      >
        <label for="m_A_08_Przewody_przebieg">[8] Przewody - przebieg</label>
        <label>
          <input
            type="checkbox"
            name="m_A_08_Przewody_przebieg"
            bind:group={m_A_08_Przewody_przebieg_array}
            value={"klatka schodowa"}
          />
          klatka schodowa
        </label>
        <label>
          <input
            type="checkbox"
            name="m_A_08_Przewody_przebieg"
            bind:group={m_A_08_Przewody_przebieg_array}
            value={"korytarz"}
          />
          korytarz
        </label>
        <label>
          <input
            type="checkbox"
            name="m_A_08_Przewody_przebieg"
            bind:group={m_A_08_Przewody_przebieg_array}
            value={"inne"}
          />
          inne
        </label>
        {#if showRequiredForMultiple_07}
          <div class="checkbox-required-message">
            {multipleRequiredMessage}
          </div>
        {/if}
      </div>
      <!--  ------------------------------------------- PYTANIE  m_A_09_Przewody_sposob_prowadzenia----------------------------------------- -->
      <div
        class="question-m_A_09_Przewody_sposob_prowadzenia min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
      >
        <label for="m_A_09_Przewody_sposob_prowadzenia"
          >[9] Przewody - sposób prowadzenia</label
        >
        <label>
          <input
            type="checkbox"
            name="m_A_09_Przewody_sposob_prowadzenia"
            bind:group={m_A_09_Przewody_sposob_prowadzenia_array}
            value={"natynkowy"}
          />
          natynkowy
        </label>
        <label>
          <input
            type="checkbox"
            name="m_A_09_Przewody_sposob_prowadzenia"
            bind:group={m_A_09_Przewody_sposob_prowadzenia_array}
            value={"podtynkowy"}
          />
          podtynkowy
        </label>
        <label>
          <input
            type="checkbox"
            name="m_A_09_Przewody_sposob_prowadzenia"
            bind:group={m_A_09_Przewody_sposob_prowadzenia_array}
            value={"zabudowane"}
          />
          zabudowane
        </label>
        <label>
          <input
            type="checkbox"
            name="m_A_09_Przewody_sposob_prowadzenia"
            bind:group={m_A_09_Przewody_sposob_prowadzenia_array}
            value={"brak dostępu"}
          />
          brak dostępu
        </label>
        {#if showRequiredForMultiple_07}
          <div class="checkbox-required-message">
            {multipleRequiredMessage}
          </div>
        {/if}
      </div>
      <!--  ------------------------------------------- PYTANIE  a_10_Przewody_przebieg_inst_gaz_przez_pokoje-------------------------------- -->
      <div
        class="question-a_10_Przewody_przebieg_inst_gaz_przez_pokoje min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
      >
        <label for="a_10_Przewody_przebieg_inst_gaz_przez_pokoje"
          >[10] Przebieg instalacji gazowej przez pokoje</label
        >
        <label>
          <input
            type="radio"
            name="a_10_Przewody_przebieg_inst_gaz_przez_pokoje"
            required
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_10_Przewody_przebieg_inst_gaz_przez_pokoje}
            value={"nie przebiega"}
          />
          nie przebiega
        </label>
        <label>
          <input
            type="radio"
            name="a_10_Przewody_przebieg_inst_gaz_przez_pokoje"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_10_Przewody_przebieg_inst_gaz_przez_pokoje}
            value={"skręcona"}
          />
          skręcona
        </label>
        <label>
          <input
            type="radio"
            name="a_10_Przewody_przebieg_inst_gaz_przez_pokoje"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_10_Przewody_przebieg_inst_gaz_przez_pokoje}
            value={"spawana"}
          />
          spawana
        </label>
      </div>
      <!--  ------------------------------------------- PYTANIE  a_11_Przewody_pion_inst_gaz_w_mieszkaniu-------------------------------- -->
      <div
        class="question-a_11_Przewody_pion_inst_gaz_w_mieszkaniu min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
      >
        <label for="a_11_Przewody_pion_inst_gaz_w_mieszkaniu"
          >[11] Pion instalacji gazowej w mieszkaniu</label
        >
        <label>
          <input
            type="radio"
            name="a_11_Przewody_pion_inst_gaz_w_mieszkaniu"
            required
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_11_Przewody_pion_inst_gaz_w_mieszkaniu}
            value={"stalowy spawany"}
          />
          stalowy spawany
        </label>
        <label>
          <input
            type="radio"
            name="a_11_Przewody_pion_inst_gaz_w_mieszkaniu"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_11_Przewody_pion_inst_gaz_w_mieszkaniu}
            value={"stalowy skręcany"}
          />
          stalowy skręcany
        </label>
        <label>
          <input
            type="radio"
            name="a_11_Przewody_pion_inst_gaz_w_mieszkaniu"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_11_Przewody_pion_inst_gaz_w_mieszkaniu}
            value={"inny"}
          />
          inny
        </label>
      </div>
      <!--  ------------------------------------------------------------------------------------------------------------------------ -->

      <!--  ----------------------- ||||| CZĘŚĆ III - PRAWIDŁOWOŚĆ DZIAŁANIA ODBIORNIKÓW GAZU ||||| ------------------------------------------- -->
      <div class="part-3-prawidlowosc-dzialania-odbiornikow-gazu">
        Część III - PRAWIDŁOWOŚĆ DZIAŁANIA ODBIORNIKÓW GAZU
        <!--  ------------------------------------------- PYTANIE  a_12_Prawidlowosc_kuchenka_gazowa_typ-------------------------------- -->
        <div
          class="question-a_12_Prawidlowosc_kuchenka_gazowa_typ min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
        >
          <label for="a_12_Prawidlowosc_kuchenka_gazowa_typ"
            >[12] Kuchenka gazowa - typ</label
          >
          <label>
            <input
              type="radio"
              name="a_12_Prawidlowosc_kuchenka_gazowa_typ"
              required
              bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
                .a_12_Prawidlowosc_kuchenka_gazowa_typ}
              value={"4-palnikowa"}
            />
            4-palnikowa
          </label>
          <label>
            <input
              type="radio"
              name="a_12_Prawidlowosc_kuchenka_gazowa_typ"
              bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
                .a_12_Prawidlowosc_kuchenka_gazowa_typ}
              value={"2/3-palnikowa"}
            />
            2/3-palnikowa
          </label>
        </div>

        <!--  ------------------------------------------- PYTANIE  a_13_Prawidlowosc_kuchenka_gazowa_stan-------------------------------- -->
        <div
          class="question-a_13_Prawidlowosc_kuchenka_gazowa_stan min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
        >
          <label for="a_13_Prawidlowosc_kuchenka_gazowa_stan"
            >[13] Kuchenka gazowa - stan</label
          >
          <label>
            <input
              type="radio"
              name="a_13_Prawidlowosc_kuchenka_gazowa_stan"
              required
              bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
                .a_13_Prawidlowosc_kuchenka_gazowa_stan}
              value={"dobra"}
            />
            dobra
          </label>
          <label>
            <input
              type="radio"
              name="a_13_Prawidlowosc_kuchenka_gazowa_stan"
              bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
                .a_13_Prawidlowosc_kuchenka_gazowa_stan}
              value={"do wymiany"}
            />
            do wymiany
          </label>
        </div>
      </div>
      <!--  ------------------------------------ PYTANIE  a_14_Prawidlowosc_kuchenka_gazowa_podlaczenie_rodzaj-------------------------------- -->
      <div
        class="question-a_14_Prawidlowosc_kuchenka_gazowa_podlaczenie_rodzaj min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
      >
        <label for="a_14_Prawidlowosc_kuchenka_gazowa_podlaczenie_rodzaj"
          >[14] Kuchenka gazowa - rodzaj podłączenia</label
        >
        <label>
          <input
            type="radio"
            name="a_14_Prawidlowosc_kuchenka_gazowa_podlaczenie_rodzaj"
            required
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_14_Prawidlowosc_kuchenka_gazowa_podlaczenie_rodzaj}
            value={"sztywne"}
          />
          sztywne
        </label>
        <label>
          <input
            type="radio"
            name="a_14_Prawidlowosc_kuchenka_gazowa_podlaczenie_rodzaj"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_14_Prawidlowosc_kuchenka_gazowa_podlaczenie_rodzaj}
            value={"wąż (atestowany) do wymiany"}
          />
          wąż (atestowany) do wymiany
        </label>
      </div>
      <!--  ------------------------------------ PYTANIE  a_15_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan-------------------------------- -->
      <div
        class="question-a_15_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
      >
        <label for="a_15_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan"
          >[15] Kuchenka gazowa - stan podłączenia</label
        >
        <label>
          <input
            type="radio"
            name="a_15_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan"
            required
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_15_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan}
            value={"szczelne"}
          />
          szczelne
        </label>
        <label>
          <input
            type="radio"
            name="a_15_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_15_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan}
            value={"nieszczelne"}
          />
          nieszczelne
        </label>
      </div>
      <!--  ------------------------------------ PYTANIE  a_16_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy-------------------------------- -->
      <div
        class="question-a_16_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
      >
        <label for="a_16_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy"
          >[16] Kuchenka gazowa - kurek odcinający</label
        >
        <label>
          <input
            type="radio"
            name="a_16_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy"
            required
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_16_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy}
            value={"dobry"}
          />
          dobry
        </label>
        <label>
          <input
            type="radio"
            name="a_16_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_16_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy}
            value={"brak"}
          />
          brak
        </label>
        <label>
          <input
            type="radio"
            name="a_16_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_16_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy}
            value={"do wymiany"}
          />
          do wymiany
        </label>
      </div>
      <!--  ------------------------------------ PYTANIE  a_17_Prawidlowosc_kuchenka_gazowa_odleglosc_od_okna-------------------------------- -->
      <div
        class="question-a_17_Prawidlowosc_kuchenka_gazowa_odleglosc_od_okna min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
      >
        <label for="a_17_Prawidlowosc_kuchenka_gazowa_odleglosc_od_okna"
          >[17] Kuchenka gazowa - odległość od okna</label
        >
        <label>
          <input
            type="radio"
            name="a_17_Prawidlowosc_kuchenka_gazowa_odleglosc_od_okna"
            required
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_17_Prawidlowosc_kuchenka_gazowa_odleglosc_od_okna}
            value={"normatywna"}
          />
          normatywna
        </label>
        <label>
          <input
            type="radio"
            name="a_17_Prawidlowosc_kuchenka_gazowa_odleglosc_od_okna"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_17_Prawidlowosc_kuchenka_gazowa_odleglosc_od_okna}
            value={"nieprawidłowa"}
          />
          nieprawidłowa
        </label>
      </div>
      <!--  ------------------------------------ PYTANIE  a_18_Prawidlowosc_gazowy_podgrzewacz_cwu_stan-------------------------------- -->
      <div
        class="question-a_18_Prawidlowosc_gazowy_podgrzewacz_cwu_stan min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
      >
        <label for="a_18_Prawidlowosc_gazowy_podgrzewacz_cwu_stan"
          >[18] Gazowy podgrzewacz ciepłej wody użytkowej - stan</label
        >
        <label>
          <input
            type="radio"
            name="a_18_Prawidlowosc_gazowy_podgrzewacz_cwu_stan"
            required
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_18_Prawidlowosc_gazowy_podgrzewacz_cwu_stan}
            value={"sprawny"}
          />
          sprawny
        </label>
        <label>
          <input
            type="radio"
            name="a_18_Prawidlowosc_gazowy_podgrzewacz_cwu_stan"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_18_Prawidlowosc_gazowy_podgrzewacz_cwu_stan}
            value={"do regulacji"}
          />
          do regulacji
        </label>
        <label>
          <input
            type="radio"
            name="a_18_Prawidlowosc_gazowy_podgrzewacz_cwu_stan"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_18_Prawidlowosc_gazowy_podgrzewacz_cwu_stan}
            value={"do wymiany"}
          />
          do wymiany
        </label>
      </div>
      <!--  --------------------------------- PYTANIE  a_19_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy---------------------------- -->
      <div
        class="question-a_19_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
      >
        <label for="a_19_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy"
          >[19] Gazowy podgrzewacz c. w. u. - [kurek odcinający] - stan</label
        >
        <label>
          <input
            type="radio"
            name="a_19_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy"
            required
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_19_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy}
            value={"sprawny"}
          />
          sprawny
        </label>
        <label>
          <input
            type="radio"
            name="a_19_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_19_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy}
            value={"do wymiany"}
          />
          do wymiany
        </label>
        <label>
          <input
            type="radio"
            name="a_19_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_19_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy}
            value={"brak"}
          />
          brak
        </label>
      </div>
      <!--  --------------------------------- PYTANIE  a_20_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa---------------------------- -->
      <div
        class="question-a_20_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
      >
        <label for="a_20_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa"
          >[20] Gazowy podgrzewacz c. w. u. - [rura spalinowa] - stan</label
        >
        <label>
          <input
            type="radio"
            name="a_20_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa"
            required
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_20_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa}
            value={"jest"}
          />
          jest
        </label>
        <label>
          <input
            type="radio"
            name="a_20_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_20_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa}
            value={"brak"}
          />
          brak
        </label>
        <label>
          <input
            type="radio"
            name="a_20_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_20_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa}
            value={"do wymiany"}
          />
          do wymiany
        </label>
      </div>
      <!--  --------------------------------- PYTANIE  a_21_Prawidlowosc_terma_gazowa_stan---------------------------- -->
      <div
        class="question-a_21_Prawidlowosc_terma_gazowa_stan min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
      >
        <label for="a_21_Prawidlowosc_terma_gazowa_stan"
          >[21] Terma gazowa - stan</label
        >
        <label>
          <input
            type="radio"
            name="a_21_Prawidlowosc_terma_gazowa_stan"
            required
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_21_Prawidlowosc_terma_gazowa_stan}
            value={"sprawna"}
          />
          sprawna
        </label>
        <label>
          <input
            type="radio"
            name="a_21_Prawidlowosc_terma_gazowa_stan"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_21_Prawidlowosc_terma_gazowa_stan}
            value={"do regulacji"}
          />
          do regulacji
        </label>
        <label>
          <input
            type="radio"
            name="a_21_Prawidlowosc_terma_gazowa_stan"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_21_Prawidlowosc_terma_gazowa_stan}
            value={"do wymiany"}
          />
          do wymiany
        </label>
      </div>
      <!--  --------------------------------- PYTANIE  a_22_Prawidlowosc_terma_gazowa_kurek_odcinajacy---------------------------- -->
      <div
        class="question-a_22_Prawidlowosc_terma_gazowa_kurek_odcinajacy min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
      >
        <label for="a_22_Prawidlowosc_terma_gazowa_kurek_odcinajacy"
          >[22] Terma gazowa - [kurek odcinający] - stan</label
        >
        <label>
          <input
            type="radio"
            name="a_22_Prawidlowosc_terma_gazowa_kurek_odcinajacy"
            required
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_22_Prawidlowosc_terma_gazowa_kurek_odcinajacy}
            value={"sprawny"}
          />
          sprawny
        </label>
        <label>
          <input
            type="radio"
            name="a_22_Prawidlowosc_terma_gazowa_kurek_odcinajacy"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_22_Prawidlowosc_terma_gazowa_kurek_odcinajacy}
            value={"do wymiany"}
          />
          do wymiany
        </label>
        <label>
          <input
            type="radio"
            name="a_22_Prawidlowosc_terma_gazowa_kurek_odcinajacy"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_22_Prawidlowosc_terma_gazowa_kurek_odcinajacy}
            value={"brak"}
          />
          brak
        </label>
      </div>
      <!--  --------------------------------- PYTANIE  a_23_Prawidlowosc_terma_gazowa_rura_spalinowa---------------------------- -->
      <div
        class="question-a_23_Prawidlowosc_terma_gazowa_rura_spalinowa min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
      >
        <label for="a_23_Prawidlowosc_terma_gazowa_rura_spalinowa"
          >[23] Terma gazowa - [rura spalinowa] - stan</label
        >
        <label>
          <input
            type="radio"
            name="a_23_Prawidlowosc_terma_gazowa_rura_spalinowa"
            required
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_23_Prawidlowosc_terma_gazowa_rura_spalinowa}
            value={"jest"}
          />
          jest
        </label>
        <label>
          <input
            type="radio"
            name="a_23_Prawidlowosc_terma_gazowa_rura_spalinowa"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_23_Prawidlowosc_terma_gazowa_rura_spalinowa}
            value={"brak"}
          />
          brak
        </label>
        <label>
          <input
            type="radio"
            name="a_23_Prawidlowosc_terma_gazowa_rura_spalinowa"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_23_Prawidlowosc_terma_gazowa_rura_spalinowa}
            value={"do wymiany"}
          />
          do wymiany
        </label>
      </div>

      <!--  --------------------------------- PYTANIE  a_24_Prawidlowosc_kociol_co_z_kurkiem_i_rura---------------------------- -->
      <div
        class="question-a_24_Prawidlowosc_kociol_co_z_kurkiem_i_rura min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
      >
        <label for="a_24_Prawidlowosc_kociol_co_z_kurkiem_i_rura"
          >[24] Kocioł centralnego ogrzewania wraz z kurkiem odcinającym i rurą
          spalinową</label
        >
        <label>
          <input
            type="radio"
            name="a_24_Prawidlowosc_kociol_co_z_kurkiem_i_rura"
            required
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_24_Prawidlowosc_kociol_co_z_kurkiem_i_rura}
            value={"sprawny"}
          />
          sprawny
        </label>
        <label>
          <input
            type="radio"
            name="a_24_Prawidlowosc_kociol_co_z_kurkiem_i_rura"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_24_Prawidlowosc_kociol_co_z_kurkiem_i_rura}
            value={"niesprawny"}
          />
          niesprawny
        </label>
      </div>
    </div>
    <!--  ------------------------------------------------------------------------------------------------------------------------ -->

    <!--  ----- ||||| CZĘŚĆ IV - KUBATURA POMIESZCZEŃ, W KTÓRYCH EKSPLOATOWANE SĄ ODBIORNIKI GAZU ||||| ------------------------ -->
    <div class="part-4-kubatura-pomieszczen">
      Część IV
      <!--  --------------------------------- PYTANIE  a_25_Kubatura_warunku_techniczne---------------------------- -->
      <div
        class="question-a_25_Kubatura_warunku_techniczne min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
      >
        <label for="a_25_Kubatura_warunku_techniczne"
          >[25] Kubatura pomieszczeń, w których eksploatowane są odbiorniki
          gazu: [warunki techniczne]</label
        >
        <label>
          <input
            type="radio"
            name="a_25_Kubatura_warunku_techniczne"
            required
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_25_Kubatura_warunku_techniczne}
            value={"spełnia"}
          />
          spełnia
        </label>
        <label>
          <input
            type="radio"
            name="a_25_Kubatura_warunku_techniczne"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_25_Kubatura_warunku_techniczne}
            value={"nie spełnia"}
          />
          nie spełnia
        </label>
      </div>
    </div>
    <!--  --------------------------------- ||||| CZĘŚĆ V - WENTYLACJA GRAWITACYJNA ||||| --------------------------------- -->
    <div class="part-5-kubatura-pomieszczen">
      Część VI - WENTYLACJA GRAWITACYJNA
      <!--  --------------------------------- PYTANIE  b_A_26_Wentylacja_kuchnia---------------------------- -->
      <div
        class="question-b_A_26_Wentylacja_kuchnia min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
      >
        <label for="b_A_26_Wentylacja_kuchnia">[26] kuchnia</label>
        <label>
          <input
            type="radio"
            name="b_A_26_Wentylacja_kuchnia"
            required
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .b_A_26_Wentylacja_kuchnia}
            value={true}
          />
          jest
        </label>
        <label>
          <input
            type="radio"
            name="b_A_26_Wentylacja_kuchnia"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .b_A_26_Wentylacja_kuchnia}
            value={false}
          />
          brak
        </label>
      </div>
      <!--  --------------------------------- PYTANIE  b_A_27_Wentylacja_lazienka---------------------------- -->
      <div
        class="question-b_A_27_Wentylacja_lazienka min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
      >
        <label for="b_A_27_Wentylacja_lazienka">[27] łazienka</label>
        <label>
          <input
            type="radio"
            name="b_A_27_Wentylacja_lazienka"
            required
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .b_A_27_Wentylacja_lazienka}
            value={true}
          />
          jest
        </label>
        <label>
          <input
            type="radio"
            name="b_A_27_Wentylacja_lazienka"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .b_A_27_Wentylacja_lazienka}
            value={false}
          />
          brak
        </label>
      </div>
      <!--  --------------------------------- PYTANIE  b_A_28_Wentylacja_inne_pomieszczenia---------------------------- -->
      <div
        class="question-b_A_28_Wentylacja_inne_pomieszczenia min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
      >
        <label for="b_A_28_Wentylacja_inne_pomieszczenia"
          >[28] inne pomieszczenia, w których znajdują się odbiorniki gazu</label
        >
        <label>
          <input
            type="radio"
            name="b_A_28_Wentylacja_inne_pomieszczenia"
            required
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .b_A_28_Wentylacja_inne_pomieszczenia}
            value={true}
          />
          jest
        </label>
        <label>
          <input
            type="radio"
            name="b_A_28_Wentylacja_inne_pomieszczenia"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .b_A_28_Wentylacja_inne_pomieszczenia}
            value={false}
          />
          brak
        </label>
      </div>
      <!--  --------------------------------- PYTANIE  b_A_29_Wentylacja_nawiew_kuchnia---------------------------- -->
      <div
        class="question-b_A_29_Wentylacja_nawiew_kuchnia min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
      >
        <label for="b_A_29_Wentylacja_nawiew_kuchnia"
          >[29] Nawiew w drzwiach 200cm2 - [kuchnia]</label
        >
        <label>
          <input
            type="radio"
            name="b_A_29_Wentylacja_nawiew_kuchnia"
            required
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .b_A_29_Wentylacja_nawiew_kuchnia}
            value={true}
          />
          jest
        </label>
        <label>
          <input
            type="radio"
            name="b_A_29_Wentylacja_nawiew_kuchnia"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .b_A_29_Wentylacja_nawiew_kuchnia}
            value={false}
          />
          brak
        </label>
      </div>
      <!--  --------------------------------- PYTANIE  b_A_30_Wentylacja_nawiew_lazienka---------------------------- -->
      <div
        class="question-b_A_30_Wentylacja_nawiew_lazienka min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
      >
        <label for="b_A_30_Wentylacja_nawiew_lazienka"
          >[30] Nawiew w drzwiach 200cm2 - [łazienka]</label
        >
        <label>
          <input
            type="radio"
            name="b_A_30_Wentylacja_nawiew_lazienka"
            required
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .b_A_30_Wentylacja_nawiew_lazienka}
            value={true}
          />
          jest
        </label>
        <label>
          <input
            type="radio"
            name="b_A_30_Wentylacja_nawiew_lazienka"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .b_A_30_Wentylacja_nawiew_lazienka}
            value={false}
          />
          brak
        </label>
      </div>
      <!--  --------------------------------- PYTANIE  b_A_31_Wentylacja_nawiew_Zet_w_pomieszczeniu_z_kotlem---------------------------- -->
      <div
        class="question-b_A_31_Wentylacja_nawiew_Zet_w_pomieszczeniu_z_kotlem min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
      >
        <label for="b_A_31_Wentylacja_nawiew_Zet_w_pomieszczeniu_z_kotlem"
          >[31] Nawiew typu "Z-et" w pomieszczeniu z kotłem</label
        >
        <label>
          <input
            type="radio"
            name="b_A_31_Wentylacja_nawiew_Zet_w_pomieszczeniu_z_kotlem"
            required
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .b_A_31_Wentylacja_nawiew_Zet_w_pomieszczeniu_z_kotlem}
            value={true}
          />
          jest
        </label>
        <label>
          <input
            type="radio"
            name="b_A_31_Wentylacja_nawiew_Zet_w_pomieszczeniu_z_kotlem"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .b_A_31_Wentylacja_nawiew_Zet_w_pomieszczeniu_z_kotlem}
            value={false}
          />
          brak
        </label>
      </div>
    </div>
    <!--  --------------------------------- ||||| CZĘŚĆ VI - WYNIKI OKRESOWEJ KONTROLI ||||| --------------------------------- -->
    <div class="part-6-wyniki-okresowej-kontroli">
      WYNIKI OKRESOWEJ KONTROLI
      <!--  --------------------------------- PYTANIE  a_32_Wyniki_stan_szczelnosci---------------------------- -->
      <div
        class="question-a_32_Wyniki_stan_szczelnosci min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
      >
        <label for="a_32_Wyniki_stan_szczelnosci"
          >[32] Stan szczelności instalacji gazowej</label
        >
        <label>
          <input
            type="radio"
            name="a_32_Wyniki_stan_szczelnosci"
            required
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_32_Wyniki_stan_szczelnosci}
            value={"dobry"}
          />
          dobry
        </label>
        <label>
          <input
            type="radio"
            name="a_32_Wyniki_stan_szczelnosci"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .a_32_Wyniki_stan_szczelnosci}
            value={"zły"}
          />
          zły
        </label>
      </div>
      <!--  --------------------------------- PYTANIE  b_A_33_Wyniki_instalacja_wymaga_usuniecia_nieszczelnosci---------------------------- -->
      <div
        class="question-b_A_33_Wyniki_instalacja_wymaga_usuniecia_nieszczelnosci min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
      >
        <label for="b_A_33_Wyniki_instalacja_wymaga_usuniecia_nieszczelnosci"
          >[33] Instalacja wymaga usunięcia nieszczelności i usterek / wymiany</label
        >
        <label>
          <input
            type="radio"
            name="b_A_33_Wyniki_instalacja_wymaga_usuniecia_nieszczelnosci"
            required
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .b_A_33_Wyniki_instalacja_wymaga_usuniecia_nieszczelnosci}
            value={true}
          />
          tak
        </label>
        <label>
          <input
            type="radio"
            name="b_A_33_Wyniki_instalacja_wymaga_usuniecia_nieszczelnosci"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .b_A_33_Wyniki_instalacja_wymaga_usuniecia_nieszczelnosci}
            value={false}
          />
          nie
        </label>
      </div>
      <!--  --------------------------------- PYTANIE  b_A_34_Propan_butan---------------------------- -->
      <div
        class="question-b_A_34_Propan_butan min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
      >
        <label for="b_A_34_Propan_butan"
          >[34] W lokalu użytkowym jest gaz propan-butan</label
        >
        <label>
          <input
            type="radio"
            name="b_A_34_Propan_butan"
            required
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .b_A_34_Propan_butan}
            value={true}
          />
          tak
        </label>
        <label>
          <input
            type="radio"
            name="b_A_34_Propan_butan"
            bind:group={CreateInspectionProtocolCommand.inspectionProtocolDTO
              .b_A_34_Propan_butan}
            value={false}
          />
          nie
        </label>
      </div>
    </div>
    <!--  --------------------------------- ||||| CZĘŚĆ VII - INNE UWAGI ||||| --------------------------------- -->
    <div class="part-7-inne-uwagi">
      <div
        class="question-inne_uwagi min-w-[240px] rounded-md p-4 bg-white flex flex-col justify-between"
      >
        <label for="inne_uwagi">[35] Inne uwagi</label>
        <!-- <textarea maxlength="600" /> -->
        <input
          type="text"
          name="inne_uwagi"
          maxlength="600"
          bind:value={CreateInspectionProtocolCommand.inspectionProtocolDTO
            .inne_uwagi}
        />
      </div>
    </div>

    {#if !readMode}
      <button
        type="submit"
        class="py-5 px-10 border-2 border-[#0078c8] font-semibold text-lg rounded-md w-[90%] mb-3 justify-center cursor-pointer hover:bg-blue-400"
        >{submitButtonMessage}</button
      >
    {/if}
  </form>
{/if}
