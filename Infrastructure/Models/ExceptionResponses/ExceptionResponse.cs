using System.Net;

namespace Infrastructure.Models.ExceptionResponses;

public class ExceptionResponse
{
    public string Title { get; set; } = default!;
    public string Detail { get; set; } = default!;
    public HttpStatusCode StatusCode { get; set; }
}
