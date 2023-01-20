using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.InspectionProtocolAnswers
{
    public class E19_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy : IBaseAnswer
    {
        static private readonly string SPRAWNY = "SPRAWNY";
        static private readonly string DO_WYMIANY = "DO WYMIANY";
        static private readonly string BRAK = "BRAK";

        static public readonly string QUESTION = "Gazowy podgrzewacz ciepłej wody użytkowej: [kurek odcinający]";
        static public readonly string[] ANSWERS = { SPRAWNY, BRAK, DO_WYMIANY };
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
