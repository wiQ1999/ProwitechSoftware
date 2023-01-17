using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.InspectionProtocolAnswers
{
    public class E18_Prawidlowosc_gazowy_podgrzewacz_cwu_stan : IBaseAnswer
    {
        static private readonly string SPRAWNY = "SPRAWNY";
        static private readonly string DO_REGULACJI = "DO REGULACJI";
        static private readonly string DO_WYMIANY = "DO WYMIANY";

        static public readonly string QUESTION = "Gazowy podgrzewacz ciepłej wody użytkowej: [stan]";
        static public readonly string[] ANSWERS = { SPRAWNY, DO_REGULACJI, DO_WYMIANY };
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
