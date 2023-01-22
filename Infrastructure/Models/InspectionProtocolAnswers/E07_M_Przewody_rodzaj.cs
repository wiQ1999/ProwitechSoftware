using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.InspectionProtocolAnswers
{
    public class E07_M_Przewody_rodzaj : IBaseAnswer
    {
        static private readonly string SPAWANE = "SPAWANE";
        static private readonly string SKRECANE = "SKRĘCANE";
        static private readonly string ZACISKOWE = "ZACISKOWE";

        static public readonly string QUESTION = "Rodzaj przewodów";
        static public readonly string[] ANSWERS = { SPAWANE, SKRECANE, ZACISKOWE};

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
