using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.InspectionProtocolAnswers
{
    public class E16_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy : IBaseAnswer
    {
        static private readonly string DOBRY = "DOBRY";
        static private readonly string BRAK  = "BRAK";
        static private readonly string DO_WYMIANY  = "DO WYMIANY";

        static public readonly string QUESTION = "Kurek odcinający";
        static public readonly string[] ANSWERS = { DOBRY, BRAK, DO_WYMIANY };
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
