using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.InspectionProtocolAnswers
{
    public class E23_Prawidlowosc_terma_gazowa_rura_spalinowa : IBaseAnswer
    {
        static private readonly string JEST = "JEST";
        static private readonly string DO_WYMIANY = "DO WYMIANY";
        static private readonly string BRAK = "BRAK";

        static public readonly string QUESTION = "Terma gazowa: [rura spalinowa]";
        static public readonly string[] ANSWERS = { JEST, BRAK, DO_WYMIANY };
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
