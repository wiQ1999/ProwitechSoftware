using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.InspectionProtocolAnswers
{
    public class E15_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan : IBaseAnswer
    {
        static private readonly string SZTYWNE = "SZTYWNE";
        static private readonly string WAZ_ATESTOWANY_DO_WYMIANY = "WĄŻ (ATESTOWANY) DO WYMIANY";

        static public readonly string QUESTION = "Podłączenie kuchenki gazowej";
        static public readonly string[] ANSWERS = { SZTYWNE, WAZ_ATESTOWANY_DO_WYMIANY };
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
