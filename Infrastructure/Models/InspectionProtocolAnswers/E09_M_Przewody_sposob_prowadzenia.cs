using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.InspectionProtocolAnswers
{
    public class E09_M_Przewody_sposob_prowadzenia:IBaseAnswer
    {
        static private readonly string NATYNKOWY = "NATYNKOWY";
        static private readonly string PODTYNKOWY = "PODTYNKOWY";
        static private readonly string ZABUDOWANE = "ZABUDOWANE";
        static private readonly string BRAK_DOSTEPU = "BRAK DOSTĘPU";

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
