<script>
  import InspectionProtocolForm from "$lib/components/InspectionProtocolForm.svelte";
  import { postInspectionProtocol } from "$lib/stores/InspectionProtocol";
  import { openModal } from "svelte-modals";
  import { page } from "$app/stores";
  import { onMount } from "svelte";
  import BasePopUp from "$lib/components/base/BasePopUp.svelte";
  import { getToken } from "$lib/js-lib/authManager";

  let CreateInspectionProtocolCommand = {
    residentDTO: {
      firstName: "",
      lastName: "",
      phoneNumber: "",
    },
    number: "",
    inspectionProtocolDTO: {
      inspectionTaskId: null,
      inspectionDateTime: null,
      inspectedPropertyId: null,
      inspectionPerformerId: null,
      a_01_Gazomierz_umiejscowienie: "",
      b_A_02_Gazomierz_szafka_wentylowana: null,
      b_A_03_Gazomierz_szczelnosc: null,
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
      b_A_26_Wentylacja_kuchnia: null,
      b_A_27_Wentylacja_lazienka: null,
      b_A_28_Wentylacja_inne_pomieszczenia: null,
      b_A_29_Wentylacja_nawiew_kuchnia: null,
      b_A_30_Wentylacja_nawiew_lazienka: null,
      b_A_31_Wentylacja_nawiew_Zet_w_pomieszczeniu_z_kotlem: null,
      a_32_Wyniki_stan_szczelnosci: "",
      b_A_33_Wyniki_instalacja_wymaga_usuniecia_nieszczelnosci: null,
      b_A_34_Propan_butan: null,
      inne_uwagi: "",
    },
  };
  let href = `/tasks/handle/${$page.params.task_id}/`;
  let formVisibility = false;
  onMount(async () => {
    let userData = getToken();
    formVisibility = false;
    CreateInspectionProtocolCommand.inspectionProtocolDTO.inspectionTaskId =
      $page.params.task_id;
    CreateInspectionProtocolCommand.inspectionProtocolDTO.inspectedPropertyId =
      $page.params.property_id;
    CreateInspectionProtocolCommand.inspectionProtocolDTO.inspectionPerformerId =
      userData.id;
    formVisibility = true;
  });
  const createProtocol = async () => {
    let result = await postInspectionProtocol(CreateInspectionProtocolCommand);
    if (result instanceof Response) {
      openModal(BasePopUp, {
        title: "Sukces",
        message: "Pomyślnie dodano Protokół",
        reloadRequired: false,
        redirectionRequired: true,
        redirectionHref: href,
      });
    }
  };
</script>

<a href="/tasks/handle/{$page.params.task_id}">
  <button
    class="bg-red-500 uppercase decoration-none text-black text-base font-semibold py-[1%] mx-auto rounded-md flex w-[60%] justify-center cursor-pointer"
    >Powrót</button
  >
</a>

{#if formVisibility}
  <InspectionProtocolForm
    creationThroughTask={true}
    propertyId={$page.params.property_id}
    onSubmit={createProtocol}
    bind:CreateInspectionProtocolCommand
  />
{/if}
