using Infrastructure.Models.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionProtocols.DTOs
{
    public class CreateOrUpdateInspectionProtocolDTO
    {
        [Required]
        public string Number { get; set; }
        public Guid? InspectionTaskId { get; set; }
        [Required]
        public DateTime InspectionDateTime { get; set; }
        [Required]
        public Guid InspectedPropertyId { get; set; }
        [Required]
        public Guid InspectionPerformerId { get; set; }

        [Required]
        public string A_01_Gazomierz_umiejscowienie { get; set; }

        //BOOLEAN
        [Required]
        public bool B_A_02_Gazomierz_szafka_wentylowana{ get; set; }
        [Required]
        public bool B_A_03_Gazomierz_szczelnosc{ get; set; }

        // ------------------------

        [Required]
        public string A_04_Gazomierz_usytuowanie_w_stosunku_do_1_go_odbiornika { get; set; }
        [Required]
        public string A_05_Gazomierz_usytuowanie_w_stosunku_do_licznika_energii_elektr { get; set; }
        [Required]
        public string A_06_Gazomierz_kurek_przed_gazomierzem { get; set; }

        //MULTIPLE CHOICE
        [Required]
        public string M_A_07_Przewody_rodzaj { get; set; }
        [Required]
        public string M_A_08_Przewody_przebieg { get; set; }
        [Required]
        public string M_A_09_Przewody_sposob_prowadzenia { get; set; }

        // ------------------------

        [Required]
        public string A_10_Przewody_przebieg_inst_gaz_przez_pokoje { get; set; }
        [Required]
        public string A_11_Przewody_pion_inst_gaz_w_mieszkaniu { get; set; }

        [Required]
        public string A_12_Prawidlowosc_kuchenka_gazowa_typ { get; set; }
        [Required]
        public string A_13_Prawidlowosc_kuchenka_gazowa_stan { get; set; }
        [Required]
        public string A_14_Prawidlowosc_kuchenka_gazowa_podlaczenie_rodzaj { get; set; }
        [Required]
        public string A_15_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan { get; set; }
        [Required]
        public string A_16_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy { get; set; }
        [Required]
        public string A_17_Prawidlowosc_kuchenka_gazowa_odleglosc_od_okna { get; set; }
        [Required]
        public string A_18_Prawidlowosc_gazowy_podgrzewacz_cwu_stan { get; set; }
        [Required]
        public string A_19_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy { get; set; }
        [Required]
        public string A_20_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa { get; set; }
        [Required]
        public string A_21_Prawidlowosc_terma_gazowa_stan { get; set; }
        [Required]
        public string A_22_Prawidlowosc_terma_gazowa_kurek_odcinajacy { get; set; }
        [Required]
        public string A_23_Prawidlowosc_terma_gazowa_rura_spalinowa { get; set; }
        [Required]
        public string A_24_Prawidlowosc_kociol_co_z_kurkiem_i_rura { get; set; }
        [Required]
        public string A_25_Kubatura_warunku_techniczne { get; set; }

        //BOOLEAN
        [Required]
        public bool B_A_26_Wentylacja_kuchnia { get; set; }
        [Required]
        public bool B_A_27_Wentylacja_lazienka { get; set; }
        [Required]
        public bool B_A_28_Wentylacja_inne_pomieszczenia { get; set; }
        [Required]
        public bool B_A_29_Wentylacja_nawiew_kuchnia { get; set; }
        [Required]
        public bool B_A_30_Wentylacja_nawiew_lazienka { get; set; }
        [Required]
        public bool B_A_31_Wentylacja_nawiew_Zet_w_pomieszczeniu_z_kotlem { get; set; }

        // ------------------------

        [Required]
        public string A_32_Wyniki_stan_szczelnosci { get; set; }

        //BOOLEAN
        [Required]
        public bool B_A_33_Wyniki_instalacja_wymaga_usuniecia_nieszczelnosci { get; set; }
        [Required]
        public bool B_A_34_Propan_butan { get; set; }
        // ------------------------

        [MaxLength(600)]
        public string Inne_uwagi { get; set; }
    }
}
