﻿using Infrastructure.Models.Enums;
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
            if (status == InspectionTaskStatus.NEW
                || status == InspectionTaskStatus.IN_PROGRESS
                || status == InspectionTaskStatus.FINISHED)
                return true;
            return false;
        }
    }
}
