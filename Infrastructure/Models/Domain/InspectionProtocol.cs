using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.Domain
{
    public class InspectionProtocol
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public Guid? InspectionTaskId { get; set; }
        public InspectionTask? InspectionTask { get; set; }
        public DateTime InspectionDateTime { get; set; }
        public Guid InspectedPropertyId { get; set; }
        public RealProperty InspectedProperty { get; set; }
        public Guid InspectionPerformerId { get; set; }
        public User InspectionPerformer { get; set; }
       
        public Guid? ResidentId { get; set; }
        public Resident? Resident { get; set; }
        
        
        [MaxLength(50)]
        public string A_01_Gazomierz_umiejscowienie { get; set; }

        //BOOLEAN

        public bool B_A_02_Gazomierz_szafka_wentylowana{ get; set; }
        public bool B_A_03_Gazomierz_szczelnosc{ get; set; }

        // ------------------------

        [MaxLength(50)]
        public string A_04_Gazomierz_usytuowanie_w_stosunku_do_1_go_odbiornika { get; set; }
        [MaxLength(50)]
        public string A_05_Gazomierz_usytuowanie_w_stosunku_do_licznika_energii_elektr { get; set; }
        [MaxLength(50)]
        public string A_06_Gazomierz_kurek_przed_gazomierzem { get; set; }
        
        //MULTIPLE CHOICE
        [MaxLength(50)]
        public string M_A_07_Przewody_rodzaj { get; set; }
        [MaxLength(50)]
        public string M_A_08_Przewody_przebieg { get; set; }
        [MaxLength(50)]
        public string M_A_09_Przewody_sposob_prowadzenia { get; set; }
        
        // ------------------------

        [MaxLength(50)]
        public string A_10_Przewody_przebieg_inst_gaz_przez_pokoje { get; set; }
        [MaxLength(50)]
        public string A_11_Przewody_pion_inst_gaz_w_mieszkaniu { get; set; }

        [MaxLength(50)]
        public string A_12_Prawidlowosc_kuchenka_gazowa_typ { get; set; }
        [MaxLength(50)]
        public string A_13_Prawidlowosc_kuchenka_gazowa_stan { get; set; }
        [MaxLength(50)]
        public string A_14_Prawidlowosc_kuchenka_gazowa_podlaczenie_rodzaj { get; set; }
        [MaxLength(50)]
        public string A_15_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan { get; set; }
        [MaxLength(50)]
        public string A_16_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy { get; set; }
        [MaxLength(50)]
        public string A_17_Prawidlowosc_kuchenka_gazowa_odleglosc_od_okna { get; set; }
        [MaxLength(50)]
        public string A_18_Prawidlowosc_gazowy_podgrzewacz_cwu_stan { get; set; }
        [MaxLength(50)]
        public string A_19_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy { get; set; }
        [MaxLength(50)]
        public string A_20_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa { get; set; }
        [MaxLength(50)]
        public string A_21_Prawidlowosc_terma_gazowa_stan { get; set; }
        [MaxLength(50)]
        public string A_22_Prawidlowosc_terma_gazowa_kurek_odcinajacy { get; set; }
        [MaxLength(50)]
        public string A_23_Prawidlowosc_terma_gazowa_rura_spalinowa { get; set; }
        [MaxLength(50)]
        public string A_24_Prawidlowosc_kociol_co_z_kurkiem_i_rura { get; set; }
        [MaxLength(50)]
        public string A_25_Kubatura_warunku_techniczne { get; set; }

        //BOOLEAN
        public bool B_A_26_Wentylacja_kuchnia { get; set; }
        public bool B_A_27_Wentylacja_lazienka { get; set; }
        public bool B_A_28_Wentylacja_inne_pomieszczenia { get; set; }
        public bool B_A_29_Wentylacja_nawiew_kuchnia { get; set; }
        public bool B_A_30_Wentylacja_nawiew_lazienka { get; set; }
        public bool B_A_31_Wentylacja_nawiew_Zet_w_pomieszczeniu_z_kotlem { get; set; }

        // ------------------------

        [MaxLength(50)]
        public string A_32_Wyniki_stan_szczelnosci { get; set; }

        //BOOLEAN
        public bool B_A_33_Wyniki_instalacja_wymaga_usuniecia_nieszczelnosci { get; set; }
        public bool B_A_34_Propan_butan { get; set; }
        // ------------------------

        [MaxLength(600)]
        public string? Inne_uwagi { get; set; }



    }
}
