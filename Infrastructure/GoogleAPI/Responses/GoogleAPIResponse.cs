using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.GoogleAPI.Responses
{
    public class GoogleAPIResponse
    {
        public HttpStatusCode HttpStatusCode { get; set; }
        public string Content { get; set; }

    }
}
