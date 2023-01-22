using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.InspectionProtocolAnswers
{
    public class E08_M_Przewody_przebieg:IBaseAnswer
    {
        static private readonly string KLATKA_SCHODOWA = "KLATKA SCHODOWA";
        static private readonly string KORYTARZ = "KORYTARZ";
        static private readonly string INNE = "INNE";

        static public readonly string QUESTION = "Przebieg przewodów";
        static public readonly string[] ANSWERS = { KLATKA_SCHODOWA, KORYTARZ, INNE };
        public string GetQuestion()
        {
            return QUESTION;
        }

        public string[] GetAnswers()
        {
            return ANSWERS;

        }
    }
}
