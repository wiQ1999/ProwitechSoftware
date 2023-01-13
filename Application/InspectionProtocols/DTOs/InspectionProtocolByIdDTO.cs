using Application.InspectionTasks.DTOs;
using Application.Properties.DTOs;
using Infrastructure.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionProtocols.DTOs
{
    public class InspectionProtocolByIdDTO
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public User InspectionPerformer { get; set; }
        public AllInspectionTasksDTO? InspectionTaskDTO { get; set; }
        public DateTime InspectionDateTime { get; set; }
        public AllPropertiesDTO InspectedProperty { get; set; }
        public Resident? Resident { get; set; }
        public string A_Gazomierz_umiejscowienie { get; set; }
        public string A_Gazomierz_szafka_wentylowana { get; set; }
        public string A_Gazomierz_szczelnosc { get; set; }
        public string A_Gazomierz_usytuowanie_w_stosunku_do_1_go_odbiornika { get; set; }
        public string A_Gazomierz_usytuowanie_w_stosunku_do_licznika_energii_elektr { get; set; }
        public string A_Gazomierz_kurek_przed_gazomierzem { get; set; }

        public string A_M_Przewody_rodzaj { get; set; }
        public string A_M_Przewody_przebieg { get; set; }
        public string A_M_Przewody_sposob_prowadzenia { get; set; }
        public string A_Przewody_przebieg_inst_gaz_przez_pokoje { get; set; }
        public string A_Przewody_pion_inst_gaz_w_mieszkaniu { get; set; }

        public string A_Prawidlowosc_kuchenka_gazowa_typ { get; set; }
        public string A_Prawidlowosc_kuchenka_gazowa_stan { get; set; }
        public string A_Prawidlowosc_kuchenka_gazowa_podlaczenie_rodzaj { get; set; }
        public string A_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan { get; set; }
        public string A_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy { get; set; }
        public string A_Prawidlowosc_kuchenka_gazowa_odleglosc_od_okna { get; set; }
        public string A_Prawidlowosc_gazowy_podgrzewacz_cwu_stan { get; set; }
        public string A_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy { get; set; }
        public string A_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa { get; set; }
        public string A_Prawidlowosc_terma_gazowa_stan { get; set; }
        public string A_Prawidlowosc_terma_gazowa_kurek_odcinajacy { get; set; }
        public string A_Prawidlowosc_terma_gazowa_rura_spalinowa { get; set; }
        public string A_Prawidlowosc_kociol_co_z_kurkiek_i_rura { get; set; }

        public string A_Kubatura_warunku_techniczne { get; set; }

        public bool A_Wentylacja_kuchnia { get; set; }
        public bool A_Wentylacja_lazienka { get; set; }
        public bool A_Wentylacja_inne_pomieszczenia { get; set; }
        public bool A_Wentylacja_nawiew_kuchnia { get; set; }
        public bool A_Wentylacja_nawiew_lazienka { get; set; }
        public bool A_Wentylacja_nawiew_Zet_w_pomieszczeniu_z_kotlem { get; set; }

        public string A_Wyniki_stan_szczelnosci { get; set; }
        public bool A_Wyniki_instalacja_wymaga_usuniecia_nieszczelnosci { get; set; }
        public bool A_Propan_butan { get; set; }
        public string A_Inne_uwagi { get; set; }
    }
}
