using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.InspectionProtocolAnswers
{
    public class E29_B_Wentylacja_nawiew_kuchnia : IBaseAnswer
    {
        static public readonly string QUESTION = "Wentylacja grawitacyjna: [Nawiew w drzwiach 200 cm2 w kuchni]";
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
