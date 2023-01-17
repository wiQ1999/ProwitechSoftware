﻿using System;
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
       
        public Guid ResidentId { get; set; }
        public Resident Resident { get; set; }
        
        
        [MaxLength(50)]
        public string A01_Gazomierz_umiejscowienie { get; set; }


        public bool A02_B_Gazomierz_szafka_wentylowana{ get; set; }
        public bool A03_B_Gazomierz_szczelnosc{ get; set; }


        [MaxLength(50)]
        public string A04_Gazomierz_usytuowanie_w_stosunku_do_1_go_odbiornika { get; set; }
        [MaxLength(50)]
        public string A05_Gazomierz_usytuowanie_w_stosunku_do_licznika_energii_elektr { get; set; }
        [MaxLength(50)]
        public string A06_Gazomierz_kurek_przed_gazomierzem { get; set; }
        
        [MaxLength(50)]
        public string A07_M_Przewody_rodzaj { get; set; }
        [MaxLength(50)]
        public string A08_M_Przewody_przebieg { get; set; }
        [MaxLength(50)]
        public string A09_M_Przewody_sposob_prowadzenia { get; set; }
        [MaxLength(50)]
        public string A10_Przewody_przebieg_inst_gaz_przez_pokoje { get; set; }
        [MaxLength(50)]
        public string A11_Przewody_pion_inst_gaz_w_mieszkaniu { get; set; }

        [MaxLength(50)]
        public string A12_Prawidlowosc_kuchenka_gazowa_typ { get; set; }
        [MaxLength(50)]
        public string A13_Prawidlowosc_kuchenka_gazowa_stan { get; set; }
        [MaxLength(50)]
        public string A14_Prawidlowosc_kuchenka_gazowa_podlaczenie_rodzaj { get; set; }
        [MaxLength(50)]
        public string A15_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan { get; set; }
        [MaxLength(50)]
        public string A16_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy { get; set; }
        [MaxLength(50)]
        public string A17_Prawidlowosc_kuchenka_gazowa_odleglosc_od_okna { get; set; }
        [MaxLength(50)]
        public string A18_Prawidlowosc_gazowy_podgrzewacz_cwu_stan { get; set; }
        [MaxLength(50)]
        public string A19_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy { get; set; }
        [MaxLength(50)]
        public string A20_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa { get; set; }
        [MaxLength(50)]
        public string A21_Prawidlowosc_terma_gazowa_stan { get; set; }
        [MaxLength(50)]
        public string A22_Prawidlowosc_terma_gazowa_kurek_odcinajacy { get; set; }
        [MaxLength(50)]
        public string A23_Prawidlowosc_terma_gazowa_rura_spalinowa { get; set; }
        [MaxLength(50)]
        public string A24_Prawidlowosc_kociol_co_z_kurkiem_i_rura { get; set; }
        [MaxLength(50)]
        public string A25_Kubatura_warunku_techniczne { get; set; }

        public bool A26_Wentylacja_kuchnia { get; set; }
        public bool A27_Wentylacja_lazienka { get; set; }
        public bool A28_Wentylacja_inne_pomieszczenia { get; set; }
        public bool A29_Wentylacja_nawiew_kuchnia { get; set; }
        public bool A30_Wentylacja_nawiew_lazienka { get; set; }
        public bool A31_Wentylacja_nawiew_Zet_w_pomieszczeniu_z_kotlem { get; set; }

        [MaxLength(50)]
        public string A32_Wyniki_stan_szczelnosci { get; set; }
        
        
        public bool A33_Wyniki_instalacja_wymaga_usuniecia_nieszczelnosci { get; set; }
        public bool A34_Propan_butan { get; set; }
        
        
        [MaxLength(600)]
        public string A35_Inne_uwagi { get; set; }



    }
}
