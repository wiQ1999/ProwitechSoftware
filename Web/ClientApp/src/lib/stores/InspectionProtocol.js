import {
  genericDelete,
  genericGetAll,
  genericGetById,
  genericPost,
  genericPut,
  genericCustomGet,
} from "$lib/js-lib/httpMethods";
import { handleError } from "$lib/js-lib/errors";

const path = "/InspectionProtocol";

export async function postInspectionProtocol(CreateInspectionProtocolCommand) {
  let response;
  try {
    response = await genericPost(path, CreateInspectionProtocolCommand);
    return response;
  } catch (err) {
    handleError(err, "dodawanie Protokołu");
    return err;
  }
}
export async function putInspectionProtocol(
  id,
  UpdateInspectionProtocolCommand
) {
  let response;
  try {
    response = await genericPut(path, id, UpdateInspectionProtocolCommand);
    return response;
  } catch (err) {
    handleError(err, "Aktualizacja Protokołu");
    return err;
  }
}
export async function getInspectionProtocolById(id) {
  let response;
  try {
    response = await genericGetById(path, id);
    return response;
  } catch (err) {
    handleError(err, "pobieranie Protokołu na podstawie ID");
    return err;
  }
}
export async function getAllInspectionProtocols() {
  let response;
  try {
    response = await genericGetAll(path);
    return response;
  } catch (err) {
    handleError(err, "pobieranie wszystkich Protokołów");
    return err;
  }
}
export async function deleteInspectionProtocol(id) {
  let response;
  try {
    response = await genericDelete(path, id);
    return response;
  } catch (err) {
    let reloadRequired = true;
    handleError(err, "usuwanie Protokołu na podstawie ID", reloadRequired);
    return err;
  }
}
export async function getInspectionProtocolsOfParticularTask(taskId) {
  console.log(taskId);
  let route = "/InspectionProtocol/taskProtocols";
  let response;
  try {
    response = await genericGetById(route, taskId);
    return response;
  } catch (err) {
    handleError(
      err,
      "pobieranie wszystkich Protokołów przypisanych do wybranego Zadania"
    );
    return err;
  }
}
export function compareProtocolsByVenueNumber(a, b) {
  let aVenueNumber = a.inspectedProperty.propertyAddress.venueNumber;
  let bVenueNumber = b.inspectedProperty.propertyAddress.venueNumber;

  let aInt = parseInt(aVenueNumber);
  let bInt = parseInt(bVenueNumber);
  if (aInt < bInt) {
    return -1;
  }
  if (aInt > bInt) {
    return 1;
  }
  return 0;
}
export async function getProtocolBiggestNumberForToday(dateFormatted) {
  let route = `/InspectionProtocol/biggestProtocolNumber/${dateFormatted}`;
  let response;
  try {
    response = await genericCustomGet(route);
    return response;
  } catch (err) {
    handleError(err, "pobieranie Numeru Protokołu");
    return err;
  }
}
export function protocolsDiffer(oldProtocol, newProtocol) {
  if (
    oldProtocol.residentDTO.firstName.toUpperCase() !=
    newProtocol.residentDTO.firstName.toUpperCase()
  )
    return true;
  if (
    oldProtocol.residentDTO.lastName.toUpperCase() !=
    newProtocol.residentDTO.lastName.toUpperCase()
  )
    return true;
  if (
    oldProtocol.residentDTO.phoneNumber != newProtocol.residentDTO.phoneNumber
  )
    return true;
  if (
    oldProtocol.residentDTO.phoneNumber != newProtocol.residentDTO.phoneNumber
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO.inspectionTaskId !=
    newProtocol.inspectionProtocolDTO.inspectionTaskId
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO.inspectionDateTime !=
    newProtocol.inspectionProtocolDTO.inspectionDateTime
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO.inspectedPropertyId !=
    newProtocol.inspectionProtocolDTO.inspectedPropertyId
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO.inspectionPerformerId !=
    newProtocol.inspectionProtocolDTO.inspectionPerformerId
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO.a_01_Gazomierz_umiejscowienie !=
    newProtocol.inspectionProtocolDTO.a_01_Gazomierz_umiejscowienie
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO.b_A_02_Gazomierz_szafka_wentylowana !=
    newProtocol.inspectionProtocolDTO.b_A_02_Gazomierz_szafka_wentylowana
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO.b_A_03_Gazomierz_szczelnosc !=
    newProtocol.inspectionProtocolDTO.b_A_03_Gazomierz_szczelnosc
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO
      .a_04_Gazomierz_usytuowanie_w_stosunku_do_1_go_odbiornika !=
    newProtocol.inspectionProtocolDTO
      .a_04_Gazomierz_usytuowanie_w_stosunku_do_1_go_odbiornika
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO
      .a_05_Gazomierz_usytuowanie_w_stosunku_do_licznika_energii_elektr !=
    newProtocol.inspectionProtocolDTO
      .a_05_Gazomierz_usytuowanie_w_stosunku_do_licznika_energii_elektr
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO.a_06_Gazomierz_kurek_przed_gazomierzem !=
    newProtocol.inspectionProtocolDTO.a_06_Gazomierz_kurek_przed_gazomierzem
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO.m_A_07_Przewody_rodzaj !=
    newProtocol.inspectionProtocolDTO.m_A_07_Przewody_rodzaj
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO.m_A_08_Przewody_przebieg !=
    newProtocol.inspectionProtocolDTO.m_A_08_Przewody_przebieg
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO.m_A_09_Przewody_sposob_prowadzenia !=
    newProtocol.inspectionProtocolDTO.m_A_09_Przewody_sposob_prowadzenia
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO
      .a_10_Przewody_przebieg_inst_gaz_przez_pokoje !=
    newProtocol.inspectionProtocolDTO
      .a_10_Przewody_przebieg_inst_gaz_przez_pokoje
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO
      .a_11_Przewody_pion_inst_gaz_w_mieszkaniu !=
    newProtocol.inspectionProtocolDTO.a_11_Przewody_pion_inst_gaz_w_mieszkaniu
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO.a_12_Prawidlowosc_kuchenka_gazowa_typ !=
    newProtocol.inspectionProtocolDTO.a_12_Prawidlowosc_kuchenka_gazowa_typ
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO.a_13_Prawidlowosc_kuchenka_gazowa_stan !=
    newProtocol.inspectionProtocolDTO.a_13_Prawidlowosc_kuchenka_gazowa_stan
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO
      .a_14_Prawidlowosc_kuchenka_gazowa_podlaczenie_rodzaj !=
    newProtocol.inspectionProtocolDTO
      .a_14_Prawidlowosc_kuchenka_gazowa_podlaczenie_rodzaj
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO
      .a_15_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan !=
    newProtocol.inspectionProtocolDTO
      .a_15_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO
      .a_16_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy !=
    newProtocol.inspectionProtocolDTO
      .a_16_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO
      .a_17_Prawidlowosc_kuchenka_gazowa_odleglosc_od_okna !=
    newProtocol.inspectionProtocolDTO
      .a_17_Prawidlowosc_kuchenka_gazowa_odleglosc_od_okna
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO
      .a_18_Prawidlowosc_gazowy_podgrzewacz_cwu_stan !=
    newProtocol.inspectionProtocolDTO
      .a_18_Prawidlowosc_gazowy_podgrzewacz_cwu_stan
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO
      .a_19_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy !=
    newProtocol.inspectionProtocolDTO
      .a_19_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO
      .a_20_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa !=
    newProtocol.inspectionProtocolDTO
      .a_20_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO.a_21_Prawidlowosc_terma_gazowa_stan !=
    newProtocol.inspectionProtocolDTO.a_21_Prawidlowosc_terma_gazowa_stan
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO
      .a_22_Prawidlowosc_terma_gazowa_kurek_odcinajacy !=
    newProtocol.inspectionProtocolDTO
      .a_22_Prawidlowosc_terma_gazowa_kurek_odcinajacy
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO
      .a_23_Prawidlowosc_terma_gazowa_rura_spalinowa !=
    newProtocol.inspectionProtocolDTO
      .a_23_Prawidlowosc_terma_gazowa_rura_spalinowa
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO
      .a_24_Prawidlowosc_kociol_co_z_kurkiem_i_rura !=
    newProtocol.inspectionProtocolDTO
      .a_24_Prawidlowosc_kociol_co_z_kurkiem_i_rura
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO.a_25_Kubatura_warunku_techniczne !=
    newProtocol.inspectionProtocolDTO.a_25_Kubatura_warunku_techniczne
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO.b_A_26_Wentylacja_kuchnia !=
    newProtocol.inspectionProtocolDTO.b_A_26_Wentylacja_kuchnia
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO.b_A_27_Wentylacja_lazienka !=
    newProtocol.inspectionProtocolDTO.b_A_27_Wentylacja_lazienka
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO.b_A_28_Wentylacja_inne_pomieszczenia !=
    newProtocol.inspectionProtocolDTO.b_A_28_Wentylacja_inne_pomieszczenia
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO.b_A_29_Wentylacja_nawiew_kuchnia !=
    newProtocol.inspectionProtocolDTO.b_A_29_Wentylacja_nawiew_kuchnia
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO.b_A_30_Wentylacja_nawiew_lazienka !=
    newProtocol.inspectionProtocolDTO.b_A_30_Wentylacja_nawiew_lazienka
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO
      .b_A_31_Wentylacja_nawiew_Zet_w_pomieszczeniu_z_kotlem !=
    newProtocol.inspectionProtocolDTO
      .b_A_31_Wentylacja_nawiew_Zet_w_pomieszczeniu_z_kotlem
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO.a_32_Wyniki_stan_szczelnosci !=
    newProtocol.inspectionProtocolDTO.a_32_Wyniki_stan_szczelnosci
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO
      .b_A_33_Wyniki_instalacja_wymaga_usuniecia_nieszczelnosci !=
    newProtocol.inspectionProtocolDTO
      .b_A_33_Wyniki_instalacja_wymaga_usuniecia_nieszczelnosci
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO.b_A_34_Propan_butan !=
    newProtocol.inspectionProtocolDTO.b_A_34_Propan_butan
  )
    return true;
  if (
    oldProtocol.inspectionProtocolDTO.inne_uwagi !=
    newProtocol.inspectionProtocolDTO.inne_uwagi
  )
    return true;
  return false;
}
