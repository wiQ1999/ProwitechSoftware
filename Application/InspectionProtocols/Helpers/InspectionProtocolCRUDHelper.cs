using Application.InspectionProtocols.Commands.Requests;
using Application.InspectionProtocols.DTOs;
using Infrastructure.Models.InspectionProtocolAnswers;
using Infrastructure.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Application.InspectionProtocols.Helpers
{
    public class InspectionProtocolCRUDHelper
    {
        public static void CheckIfAllAnswersAreCorrect(CreateOrUpdateInspectionProtocolDTO protocolDTO)
        {

            PropertyInfo[] propertyInfos;
            propertyInfos = protocolDTO.GetType().GetProperties();

            foreach(PropertyInfo p in propertyInfos)
            {
                if (!p.Name.StartsWith("M_") && !p.Name.StartsWith("A_") && !p.Name.StartsWith("B_"))
                    continue;
                var classToInitialize = dict[p.Name];
                
                if (p.Name.StartsWith("M_"))
                {
                    string givenAnswer = (string)p.GetValue(protocolDTO, null)!;
                    AnswerChecker.MultipleAnswersContain
                        (
                        (IBaseAnswer)Activator.CreateInstance(classToInitialize)!, givenAnswer!
                        );
                }
                else if (p.Name.ToString()!.StartsWith("B_"))
                {
                    string givenAnswer = p.GetValue(protocolDTO, null)!.ToString()!;
                    AnswerChecker.AnswersContain
                        (
                        (IBaseAnswer)Activator.CreateInstance(classToInitialize)!, givenAnswer!
                        );
                }
                else if (p.Name.ToString()!.StartsWith("A_"))
                {
                    string givenAnswer = (string)p.GetValue(protocolDTO, null)!;
                    AnswerChecker.AnswersContain
                        (
                        (IBaseAnswer)Activator.CreateInstance(classToInitialize)!, givenAnswer!
                        );
                }
            }

        }
        public static Dictionary<string, Type> dict = new Dictionary<string, Type>()
        {
         {"A_01_Gazomierz_umiejscowienie", typeof(E01_Gazomierz_umiejscowienie) },
            {"B_A_02_Gazomierz_szafka_wentylowana", typeof(E02_B_Gazomierz_szafka_wentylowana) },
            {"B_A_03_Gazomierz_szczelnosc", typeof(E03_B_Gazomierz_szczelnosc) },
            {"A_04_Gazomierz_usytuowanie_w_stosunku_do_1_go_odbiornika", typeof(E04_Gazomierz_usytuowanie_w_stosunku_do_1_go_odbiornika) },
            {"A_05_Gazomierz_usytuowanie_w_stosunku_do_licznika_energii_elektr", typeof(E05_Gazomierz_usytuowanie_w_stosunku_do_licznika_energii_elektr) },
            {"A_06_Gazomierz_kurek_przed_gazomierzem", typeof(E06_Gazomierz_kurek_przed_gazomierzem) },
            {"M_A_07_Przewody_rodzaj", typeof(E07_M_Przewody_rodzaj) },
            {"M_A_08_Przewody_przebieg", typeof(E08_M_Przewody_przebieg) },
            {"M_A_09_Przewody_sposob_prowadzenia", typeof(E09_M_Przewody_sposob_prowadzenia) },
            {"A_10_Przewody_przebieg_inst_gaz_przez_pokoje", typeof(E10_Przewody_przebieg_inst_gaz_przez_pokoje) },
            {"A_11_Przewody_pion_inst_gaz_w_mieszkaniu", typeof(E11_Przewody_pion_inst_gaz_w_mieszkaniu) },
            {"A_12_Prawidlowosc_kuchenka_gazowa_typ", typeof(E12_Prawidlowosc_kuchenka_gazowa_typ) },
            {"A_13_Prawidlowosc_kuchenka_gazowa_stan", typeof(E13_Prawidlowosc_kuchenka_gazowa_stan) },
            {"A_14_Prawidlowosc_kuchenka_gazowa_podlaczenie_rodzaj", typeof(E14_Prawidlowosc_kuchenka_gazowa_podlaczenie_rodzaj) },
            {"A_15_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan", typeof(E15_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan) },
            {"A_16_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy", typeof(E16_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy) },
            {"A_17_Prawidlowosc_kuchenka_gazowa_odleglosc_od_okna", typeof(E17_Prawidlowosc_kuchenka_gazowa_odleglosc_od_okna) },
            {"A_18_Prawidlowosc_gazowy_podgrzewacz_cwu_stan", typeof(E18_Prawidlowosc_gazowy_podgrzewacz_cwu_stan) },
            {"A_19_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy", typeof(E19_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy) },
            {"A_20_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa", typeof(E20_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa) },
            {"A_21_Prawidlowosc_terma_gazowa_stan", typeof(E21_Prawidlowosc_terma_gazowa_stan) },
            {"A_22_Prawidlowosc_terma_gazowa_kurek_odcinajacy", typeof(E22_Prawidlowosc_terma_gazowa_kurek_odcinajacy) },
            {"A_23_Prawidlowosc_terma_gazowa_rura_spalinowa", typeof(E23_Prawidlowosc_terma_gazowa_rura_spalinowa) },
            {"A_24_Prawidlowosc_kociol_co_z_kurkiem_i_rura", typeof(E24_Prawidlowosc_kociol_co_z_kurkiem_i_rura) },
            {"A_25_Kubatura_warunku_techniczne", typeof(E25_Kubatura_warunku_techniczne) },
            {"B_A_26_Wentylacja_kuchnia", typeof(E26_B_Wentylacja_kuchnia) },
            {"B_A_27_Wentylacja_lazienka", typeof(E27_B_Wentylacja_lazienka) },
            {"B_A_28_Wentylacja_inne_pomieszczenia", typeof(E28_B_Wentylacja_inne_pomieszczenia) },
            {"B_A_29_Wentylacja_nawiew_kuchnia", typeof(E29_B_Wentylacja_nawiew_kuchnia) },
            {"B_A_30_Wentylacja_nawiew_lazienka", typeof(E30_B_Wentylacja_nawiew_lazienka) },
            {"B_A_31_Wentylacja_nawiew_Zet_w_pomieszczeniu_z_kotlem", typeof(E31_B_Wentylacja_nawiew_Zet_w_pomieszczeniu_z_kotlem) },
            {"A_32_Wyniki_stan_szczelnosci", typeof(E32_Wyniki_stan_szczelnosci) },
            {"B_A_33_Wyniki_instalacja_wymaga_usuniecia_nieszczelnosci", typeof(E33_B_Wyniki_instalacja_wymaga_usuniecia_nieszczelnosci) },
            {"B_A_34_Propan_butan", typeof(E34_B_Propan_butan) },
        };
    }
}
