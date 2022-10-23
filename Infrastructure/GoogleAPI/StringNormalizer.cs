using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.GoogleAPI
{
    public static class StringNormalizer
    {
        
        public static string ReturnStringWithoutDiacritics(string stringToNormalize)
        {
            if (stringToNormalize == null || stringToNormalize=="")
            {
                return stringToNormalize;
            }
            char[] charArray = stringToNormalize.ToCharArray();
            char[] normalizedArray = new char[charArray.Length];
            for (int i = 0; i < normalizedArray.Length; i++)
            {
                normalizedArray[i] = NormalizeChar(charArray[i]);
            }
            return new string(normalizedArray);
        }
        
        private static char NormalizeChar(char c)
        {
            switch (c)
            {
                case 'ą':
                    return 'a';
                case 'ć':
                    return 'c';
                case 'ę':
                    return 'e';
                case 'ł':
                    return 'l';
                case 'ń':
                    return 'n';
                case 'ó':
                    return 'o';
                case 'ś':
                    return 's';
                case 'ż':
                case 'ź':
                    return 'z';
            }
            return c;
        }

        
    }
}
