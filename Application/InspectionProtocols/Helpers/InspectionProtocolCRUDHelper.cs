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
        //TODO
        //1. Dokończyć dictionary
        //2. Zmienić nazwy E0x tak, żeby kończyły się na B lub M
        //3. Powtórzyć pkt. 2 dla CreateOrUpdateInspectionProtocolDTO oraz InspectionProtocol
        public static Dictionary<string, Type> dict = new Dictionary<string, Type>()
        {
         {"A01_Gazomierz_umiejscowienie", typeof(E01_Gazomierz_umiejscowienie) },
            {"A02_Gazomierz_szafka_wentylowana_B", typeof(E02_Gazomierz_szafka_wentylowana_B) },
            {"A07_Przewody_rodzaj_M", typeof(E07_M_Przewody_rodzaj) }
        };

        public static void CheckIfAllAnswersAreCorrect(CreateOrUpdateInspectionProtocolDTO protocolDTO)
        {

            PropertyInfo[] propertyInfos;
            propertyInfos = protocolDTO.GetType().GetProperties();

            foreach(PropertyInfo p in propertyInfos)
            {
                var classToInitialize = dict[p.Name];
                
                if (p.Name.EndsWith("_M"))
                {
                    string givenAnswer = (string)p.GetValue(protocolDTO, null)!;
                    AnswerChecker.MultipleAnswersContain
                        (
                        (IBaseAnswer)Activator.CreateInstance(classToInitialize)!, givenAnswer!
                        );
                }
                else if (p.Name.ToString()!.EndsWith("_B"))
                {
                    string givenAnswer = p.GetValue(protocolDTO, null)!.ToString()!;
                    AnswerChecker.AnswersContain
                        (
                        (IBaseAnswer)Activator.CreateInstance(classToInitialize)!, givenAnswer!
                        );
                }
                else if (p.Name.ToString()!.StartsWith("A"))
                {
                    string givenAnswer = (string)p.GetValue(protocolDTO, null)!;
                    AnswerChecker.AnswersContain
                        (
                        (IBaseAnswer)Activator.CreateInstance(classToInitialize)!, givenAnswer!
                        );
                }
            }
            
            //// GAZOMIERZ

            //AnswerChecker.AnswersContain(new E01_Gazomierz_umiejscowienie(), protocolDTO.A01_Gazomierz_umiejscowienie);
            //AnswerChecker.AnswersContain(new E02_Gazomierz_szafka_wentylowana_B(), protocolDTO.A02_Gazomierz_szafka_wentylowana_B.ToString());
            //AnswerChecker.AnswersContain(new E03_B_Gazomierz_szczelnosc(), protocolDTO.A03_B_Gazomierz_szczelnosc.ToString());
            //AnswerChecker.AnswersContain(new E04_Gazomierz_usytuowanie_w_stosunku_do_1_go_odbiornika(), protocolDTO.A04_Gazomierz_usytuowanie_w_stosunku_do_1_go_odbiornika);
            //AnswerChecker.AnswersContain(new E05_Gazomierz_usytuowanie_w_stosunku_do_licznika_energii_elektr(), protocolDTO.A05_Gazomierz_usytuowanie_w_stosunku_do_licznika_energii_elektr);
            //AnswerChecker.AnswersContain(new E06_Gazomierz_kurek_przed_gazomierzem(), protocolDTO.A06_Gazomierz_kurek_przed_gazomierzem);
            
            ////PRZEWODY

            //AnswerChecker.MultipleAnswersContain(new E07_M_Przewody_rodzaj(), protocolDTO.A07_Przewody_rodzaj_M);
            //AnswerChecker.MultipleAnswersContain(new E08_M_Przewody_przebieg(), protocolDTO.A08_M_Przewody_przebieg);
            //AnswerChecker.MultipleAnswersContain(new E09_M_Przewody_sposob_prowadzenia(), protocolDTO.A09_M_Przewody_sposob_prowadzenia);
            //AnswerChecker.AnswersContain(new E10_Przewody_przebieg_inst_gaz_przez_pokoje(), protocolDTO.A10_Przewody_przebieg_inst_gaz_przez_pokoje);
            //AnswerChecker.AnswersContain(new E11_Przewody_pion_inst_gaz_w_mieszkaniu(), protocolDTO.A11_Przewody_pion_inst_gaz_w_mieszkaniu);
            
            ////PRAWIDŁOWOŚĆ DZIAŁANIA ODBIORNIKÓW GAZU

            //AnswerChecker.AnswersContain(new E12_Prawidlowosc_kuchenka_gazowa_typ(), protocolDTO.A12_Prawidlowosc_kuchenka_gazowa_typ);
            //AnswerChecker.AnswersContain(new E13_Prawidlowosc_kuchenka_gazowa_stan(), protocolDTO.A13_Prawidlowosc_kuchenka_gazowa_stan);
            //AnswerChecker.AnswersContain(new E14_Prawidlowosc_kuchenka_gazowa_podlaczenie_rodzaj(), protocolDTO.A14_Prawidlowosc_kuchenka_gazowa_podlaczenie_rodzaj);
            //AnswerChecker.AnswersContain(new E15_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan(), protocolDTO.A15_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan);
            //AnswerChecker.AnswersContain(new E16_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy(), protocolDTO.A16_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy);
            //AnswerChecker.AnswersContain(new E17_Prawidlowosc_kuchenka_gazowa_odleglosc_od_okna(), protocolDTO.A17_Prawidlowosc_kuchenka_gazowa_odleglosc_od_okna);
            //AnswerChecker.AnswersContain(new E18_Prawidlowosc_gazowy_podgrzewacz_cwu_stan(), protocolDTO.A18_Prawidlowosc_gazowy_podgrzewacz_cwu_stan);
            //AnswerChecker.AnswersContain(new E19_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy(), protocolDTO.A19_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy);
            //AnswerChecker.AnswersContain(new E20_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa(), protocolDTO.A20_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa);
            //AnswerChecker.AnswersContain(new E21_Prawidlowosc_terma_gazowa_stan(), protocolDTO.A21_Prawidlowosc_terma_gazowa_stan);
            //AnswerChecker.AnswersContain(new E22_Prawidlowosc_terma_gazowa_kurek_odcinajacy(), protocolDTO.A22_Prawidlowosc_terma_gazowa_kurek_odcinajacy);
            //AnswerChecker.AnswersContain(new E23_Prawidlowosc_terma_gazowa_rura_spalinowa(), protocolDTO.A23_Prawidlowosc_terma_gazowa_rura_spalinowa);
            //AnswerChecker.AnswersContain(new E24_Prawidlowosc_kociol_co_z_kurkiem_i_rura(), protocolDTO.A24_Prawidlowosc_kociol_co_z_kurkiem_i_rura);

            ////KUBATURA POMIESZCZEŃ, W KTÓRYCH ESKPLOATOWANE SĄ ODBIORNIKI GAZU

            //AnswerChecker.AnswersContain(new E25_Kubatura_warunku_techniczne(), protocolDTO.A25_Kubatura_warunku_techniczne);

            ////WENTYLACJA GRAWITACYJNA

            //AnswerChecker.AnswersContain(new E26_B_Wentylacja_kuchnia(), protocolDTO.A26_Wentylacja_kuchnia.ToString());
            //AnswerChecker.AnswersContain(new E27_B_Wentylacja_lazienka(), protocolDTO.A27_Wentylacja_lazienka.ToString());
            //AnswerChecker.AnswersContain(new E29_B_Wentylacja_nawiew_kuchnia(), protocolDTO.A29_Wentylacja_nawiew_kuchnia.ToString());
            //AnswerChecker.AnswersContain(new E30_B_Wentylacja_nawiew_lazienka(), protocolDTO.A30_Wentylacja_nawiew_lazienka.ToString());
            //AnswerChecker.AnswersContain(new E31_B_Wentylacja_nawiew_Zet_w_pomieszczeniu_z_kotlem(), protocolDTO.A31_Wentylacja_nawiew_Zet_w_pomieszczeniu_z_kotlem.ToString());

            ////WYNIKI OKRESOWEJ KONTROLI

            //AnswerChecker.AnswersContain(new E32_Wyniki_stan_szczelnosci(), protocolDTO.A32_Wyniki_stan_szczelnosci);
            //AnswerChecker.AnswersContain(new E33_B_Wyniki_instalacja_wymaga_usuniecia_nieszczelnosci(), protocolDTO.A33_Wyniki_instalacja_wymaga_usuniecia_nieszczelnosci.ToString());


            ////W LOKALU UŻYTKOWYM JEST GAZ PROPAN-BUTAN

            //AnswerChecker.AnswersContain(new E34_B_Propan_butan(), protocolDTO.A34_Propan_butan.ToString());

        }
    }
}
