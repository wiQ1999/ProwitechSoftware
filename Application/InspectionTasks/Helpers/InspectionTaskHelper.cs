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
            if (status == InspectionTaskStatus.NEW.ToString()
                || status == InspectionTaskStatus.IN_PROGRESS.ToString()
                || status == InspectionTaskStatus.FINISHED.ToString())
                return true;
            return false;
        }
    }
}
