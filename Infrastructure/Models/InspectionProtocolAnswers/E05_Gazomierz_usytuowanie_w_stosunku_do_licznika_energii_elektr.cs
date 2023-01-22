using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.InspectionProtocolAnswers
{
    public class E05_Gazomierz_usytuowanie_w_stosunku_do_licznika_energii_elektr : IBaseAnswer
    {
        static private readonly string NIEPRAWIDLOWE = "NIEPRAWIDŁOWE";
        static private readonly string PRAWIDLOWE = "PRAWIDŁOWE";

        static public readonly string QUESTION = "Usytuowanie gazomierza w stosunku do licznika energii elektrycznej";
        static public readonly string[] ANSWERS = { PRAWIDLOWE, NIEPRAWIDLOWE };

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
