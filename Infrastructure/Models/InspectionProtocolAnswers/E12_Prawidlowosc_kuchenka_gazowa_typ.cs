using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.InspectionProtocolAnswers
{
    public class E12_Prawidlowosc_kuchenka_gazowa_typ : IBaseAnswer
    {
        static private readonly string _4_PALNIKOWA = "4-PALNIKOWA";
        static private readonly string _2_3_PALNIKOWA = "2/3-PALNIKOWA";
        
        static public readonly string QUESTION = "Typ kuchenki gazowej";
        static public readonly string[] ANSWERS = { _4_PALNIKOWA, _2_3_PALNIKOWA };
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
