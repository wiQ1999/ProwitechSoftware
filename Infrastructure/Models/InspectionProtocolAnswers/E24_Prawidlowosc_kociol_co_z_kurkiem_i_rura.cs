using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.InspectionProtocolAnswers
{
    public class E24_Prawidlowosc_kociol_co_z_kurkiem_i_rura : IBaseAnswer
    {
        static private readonly string SPRAWNY = "SPRAWNY";
        static private readonly string NIESPRAWNY = "NIESPRAWNY";

        static public readonly string QUESTION = "Kocioł centralnego ogrzewania wraz z kurkiem odcinającym i rurą spalinową";
        static public readonly string[] ANSWERS = { SPRAWNY, NIESPRAWNY };
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
