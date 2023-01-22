using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.InspectionProtocolAnswers
{
    public class E04_Gazomierz_usytuowanie_w_stosunku_do_1_go_odbiornika : IBaseAnswer
    {
        static private readonly string NIEPRAWIDLOWE = "NIEPRAWIDŁOWE";
        static private readonly string PRAWIDLOWE = "PRAWIDŁOWE";

        static public readonly string QUESTION = "Usytuowanie gazomierza w stosunku do pierwszego odbiornika";
        static public readonly string[] ANSWERS = { PRAWIDLOWE,NIEPRAWIDLOWE };
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
