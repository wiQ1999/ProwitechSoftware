using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.InspectionProtocolAnswers
{
    public class E21_Prawidlowosc_terma_gazowa_stan : IBaseAnswer
    {
        static private readonly string SPRAWNA = "SPRAWNA";
        static private readonly string DO_WYMIANY = "DO WYMIANY";
        static private readonly string DO_REGULACJI = "DO REGULACJI";

        static public readonly string QUESTION = "Terma gazowa: [stan]";
        static public readonly string[] ANSWERS = { SPRAWNA, DO_REGULACJI, DO_WYMIANY };
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
