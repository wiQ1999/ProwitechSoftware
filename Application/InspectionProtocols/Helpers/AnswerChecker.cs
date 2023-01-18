using Infrastructure.Models.Exceptions;
using Infrastructure.Models.InspectionProtocolAnswers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionProtocols.Helpers
{
    public static class AnswerChecker
    {
        public static void AnswersContain(IBaseAnswer ibaseAnswer, string givenAnswer)
        {
            var answers = ibaseAnswer.GetAnswers();
            if(!ibaseAnswer.GetAnswers().Contains(givenAnswer))
                throw new NotAllowedProtocolAnswerException(givenAnswer, ibaseAnswer.GetQuestion());
        }
        static public void MultipleAnswersContain(IBaseAnswer ibaseAnswer, string givenAnswer)
        {
            string[] answers = givenAnswer.Split(',');
            foreach (var a in answers)
            {
                if (!ibaseAnswer.GetAnswers().Contains(a))
                    throw new NotAllowedProtocolAnswerException(a, ibaseAnswer.GetQuestion());
            }
        }
    }
}
