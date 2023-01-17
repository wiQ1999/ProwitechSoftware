using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.InspectionProtocolAnswers
{
    public static class Answer_AnswerClassDictionary
    {
        public static Dictionary<string, Type> dict = new Dictionary<string, Type>()
        {
         {"A01_Gazomierz_umiejscowienie", typeof(E01_Gazomierz_umiejscowienie) },
            {"A02_Gazomierz_szafka_wentylowana_B", typeof(E02_Gazomierz_szafka_wentylowana_B) },
            {"A07_Przewody_rodzaj_M", typeof(E07_M_Przewody_rodzaj) }
        };

    }




}
