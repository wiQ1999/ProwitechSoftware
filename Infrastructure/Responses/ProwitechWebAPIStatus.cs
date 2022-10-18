using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Responses
{
    public enum ProwitechWebAPIStatus
    {
        ERROR,
        ADDED_TO_DB,
        NOT_ADDED_COORDINATES_TYPE_ISSUE,
        NOT_ADDED_ERROR,
        UNKNOWN,
        ADDED_DESPITE_COORDINATE_ISSUE,
        ADDED_TO_DB_WITHOUT_COORDINATES
    };
}
