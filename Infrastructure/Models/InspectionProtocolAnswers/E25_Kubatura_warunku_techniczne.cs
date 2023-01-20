using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.InspectionProtocolAnswers
{
    public class E25_Kubatura_warunku_techniczne : IBaseAnswer
    {
        static private readonly string SPELNIA = "SPEŁNIA";
        static private readonly string NIE_SPELNIA = "NIE SPEŁNIA";

        static public readonly string QUESTION = "Kubatura pomieszczeń, w których eksploatowane są odbiorniki gazu: [warunki techniczne]";
        static public readonly string[] ANSWERS = { SPELNIA, NIE_SPELNIA };
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
