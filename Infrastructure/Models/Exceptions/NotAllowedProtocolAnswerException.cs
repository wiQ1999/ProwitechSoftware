using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.Exceptions
{
    public class NotAllowedProtocolAnswerException : Exception
    {
        public NotAllowedProtocolAnswerException(string givenAnswer, string question)
            : base($"Odpowiedź: {givenAnswer} nie znajduje się na liście dozwolonych odpowiedzi na pytanie: {question}")
        {

        }
    }
}
