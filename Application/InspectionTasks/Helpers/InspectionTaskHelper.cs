using Infrastructure.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionTasks.Helpers
{
    public static class InspectionTaskHelper
    {
        public static bool isStatusAllowed(string status)
        {
            if (status.ToUpper() == InspectionTaskStatus.NEW.ToString()
                || status.ToUpper() == InspectionTaskStatus.IN_PROGRESS.ToString()
                || status.ToUpper() == InspectionTaskStatus.FINISHED.ToString())
                return true;
            return false;
        }
    }
}
