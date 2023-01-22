using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.InspectionProtocolAnswers
{
    public class E34_B_Propan_butan : IBaseAnswer
    {
        static public readonly string QUESTION = "W lokalu użytkowym jest gaz propan-butan";
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
