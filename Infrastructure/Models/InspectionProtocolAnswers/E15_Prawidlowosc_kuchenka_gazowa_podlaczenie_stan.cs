using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.InspectionProtocolAnswers
{
    public class E15_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan : IBaseAnswer
    {
        static private readonly string SZCZELNE = "SZCZELNE";
        static private readonly string NIESZCZELNE = "NIESZCZELNE";

        static public readonly string QUESTION = "Podłączenie kuchenki gazowej";
        static public readonly string[] ANSWERS = { SZCZELNE, NIESZCZELNE };
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
