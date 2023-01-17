using Application.InspectionProtocols.Commands.Requests;
using Infrastructure.Models.Enums.InspectionProtocolAnswers;
using Infrastructure.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionProtocols.Helpers
{
    public class InspectionProtocolCRUDHelper
    {
        public static bool CheckIfAllAnswersAreCorrect(CreateInspectionProtocolCommand request)
        {
            if (!E_M_Przewody_przebieg.ANSWERS.Contains(request.A_M_Przewody_przebieg.ToUpper()))
                throw new NotAllowedProtocolAnswerException(request.A_M_Przewody_przebieg,
                    E_M_Przewody_przebieg.QUESTION);
            return true;
        }
    }
}
