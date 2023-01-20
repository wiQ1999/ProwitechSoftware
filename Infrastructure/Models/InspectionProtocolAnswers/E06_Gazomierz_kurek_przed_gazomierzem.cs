using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.InspectionProtocolAnswers
{
    public class E06_Gazomierz_kurek_przed_gazomierzem:IBaseAnswer
    {
        static private readonly string KULOWY = "KULOWY";
        static private readonly string STOZKOWY = "STOŻKOWY";

        static public readonly string QUESTION = "Rodzaj kurka przed gazomierzem";
        static public readonly string[] ANSWERS = { KULOWY, STOZKOWY };

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
