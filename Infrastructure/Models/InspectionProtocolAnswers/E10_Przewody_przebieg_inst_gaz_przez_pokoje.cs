using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.InspectionProtocolAnswers
{
    public class E10_Przewody_przebieg_inst_gaz_przez_pokoje : IBaseAnswer
    {
        static private readonly string NIE_PRZEBIEGA = "NIE PRZEBIEGA";
        static private readonly string SKRECONA = "SKRĘCONA";
        static private readonly string SPAWANA = "SPAWANA";

        static public readonly string QUESTION = "Przebieg instalacji gazowej przez pokoje";
        static public readonly string[] ANSWERS = { NIE_PRZEBIEGA, SKRECONA, SPAWANA };
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
