using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.InspectionProtocolAnswers
{
    public class E17_Prawidlowosc_kuchenka_gazowa_odleglosc_od_okna : IBaseAnswer
    {
        static private readonly string NORMATYWNA = "NORMATYWNA";
        static private readonly string NIEPRAWIDLOWA = "NIEPRAWIDŁOWA";

        static public readonly string QUESTION = "Odległość od okna";
        static public readonly string[] ANSWERS = { NORMATYWNA, NIEPRAWIDLOWA};
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
