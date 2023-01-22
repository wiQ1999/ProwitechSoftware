using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.InspectionProtocolAnswers
{
    public class E31_B_Wentylacja_nawiew_Zet_w_pomieszczeniu_z_kotlem : IBaseAnswer
    {
        static public readonly string QUESTION = "Wentylacja grawitacyjna: [Nawiew typu \"Z-et\" w pomieszczeniu z kotłem]";
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
