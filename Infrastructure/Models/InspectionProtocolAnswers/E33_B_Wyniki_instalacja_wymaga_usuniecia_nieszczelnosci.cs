using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.InspectionProtocolAnswers
{
    public class E33_B_Wyniki_instalacja_wymaga_usuniecia_nieszczelnosci : IBaseAnswer
    {
        static public readonly string QUESTION = "Wyniki okresowej kontroli: [Instalacja wymaga usunięcia nieszczelności i usterek/wymiany]";
        static public readonly bool[] ANSWERS = { true, false };
        public string GetQuestion()
        {
            return QUESTION;
        }

        public string[] GetAnswers()
        {
            string[] answers = new string[]
            {
                ANSWERS[0].ToString(),
                ANSWERS[1].ToString()
            };
            return answers;

        }
    }
}
