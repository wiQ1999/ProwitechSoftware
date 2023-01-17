using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.Enums.InspectionProtocolAnswers
{
    //public enum E_M_Przewody_przebieg
    //{
    //    KLATKA_SCHODOWA = 0,
    //    KORYTARZ = 1,
    //    INNE = 2
    //}
    public static class E_M_Przewody_przebieg
    {
        static private readonly string KLATKA_SCHODOWA = "KLATKA SCHODOWA";
        static private readonly string KORYTARZ = "KORYTARZ";
        static private readonly string INNE = "INNE";

        static public readonly string QUESTION = "Przebieg przewodów";
        static public readonly string[] ANSWERS = { KLATKA_SCHODOWA, KORYTARZ, INNE };
    }
}
