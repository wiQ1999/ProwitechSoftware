using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.InspectionProtocolAnswers
{
    public class E11_Przewody_pion_inst_gaz_w_mieszkaniu : IBaseAnswer
    {
        static private readonly string STALOWY_SPAWANY = "STALOWY SPAWANY";
        static private readonly string STALOWY_SKRECANY = "STALOWY SKRĘCANY";
        static private readonly string INNY = "INNY";

        static public readonly string QUESTION = "Rodzaj pionu instalacji gazowej w mieszkaniu";
        static public readonly string[] ANSWERS = { STALOWY_SPAWANY, STALOWY_SKRECANY, INNY };
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
