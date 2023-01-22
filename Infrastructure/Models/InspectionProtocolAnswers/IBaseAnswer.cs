using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.InspectionProtocolAnswers
{
    public interface IBaseAnswer
    {
        public string GetQuestion();
        public string[] GetAnswers();
    }
}
