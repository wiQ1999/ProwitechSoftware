using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.Enums
{
    public static class InspectionTaskStatus
    {
        static public readonly string NEW = "nowe";
        static public readonly string IN_PROGRESS = "w toku";
        static public readonly string FINISHED = "zakończone";
    }
}
