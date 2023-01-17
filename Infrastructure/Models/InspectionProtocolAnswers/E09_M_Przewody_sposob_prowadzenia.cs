using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.InspectionProtocolAnswers
{
    public class E09_M_Przewody_sposob_prowadzenia:IBaseAnswer
    {
        static private readonly string NATYNKOWY = "KLATKA SCHODOWA";
        static private readonly string PODTYNKOWY = "KORYTARZ";
        static private readonly string ZABUDOWANE = "INNE";
        static private readonly string BRAK_DOSTEPU = "INNE";

        static public readonly string QUESTION = "Sposób prowadzenia przewodów";
        static public readonly string[] ANSWERS = { NATYNKOWY, PODTYNKOWY, ZABUDOWANE, BRAK_DOSTEPU };
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
