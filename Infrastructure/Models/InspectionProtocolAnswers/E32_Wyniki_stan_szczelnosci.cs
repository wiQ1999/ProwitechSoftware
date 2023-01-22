using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.InspectionProtocolAnswers
{
    public class E32_Wyniki_stan_szczelnosci : IBaseAnswer
    {
        static private readonly string DOBRY = "DOBRY";
        static private readonly string ZLY = "ZŁY";

        static public readonly string QUESTION = "Wyniki okresowej kontroli: [Stan szczelności instalacji gazowej]";
        static public readonly string[] ANSWERS = { DOBRY, ZLY};
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
