using System.Net;

namespace Infrastructure.Models.ExceptionResponses;
public class ExceptionResponse
{
    public string? Title { get; set; }
    public string? Detail { get; set; }
    public HttpStatusCode StatusCode { get; set; }
}
