using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.InspectionProtocolAnswers
{
    public class E13_Prawidlowosc_kuchenka_gazowa_stan : IBaseAnswer
    {
        static private readonly string DOBRA = "DOBRA";
        static private readonly string DO_WYMIANY = "DO WYMIANY";

        static public readonly string QUESTION = "Stan kuchenki gazowej";
        static public readonly string[] ANSWERS = { DOBRA, DO_WYMIANY };
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
