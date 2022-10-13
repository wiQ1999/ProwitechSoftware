using Infrastructure.Models.Domain;
using Infrastructure.Models.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class ExceptionTestController : ApiControllerBase
{
    [HttpGet("StandardException")]
    public Task<IActionResult> ThrowStandardException() =>
        throw new Exception("Opis jakiegoś tam błędu", CreateBaseInnerException());

    private Exception CreateBaseInnerException() =>
        new("Inner exception desciption.");

    [HttpGet("NotFoundInDbExcption")]
    public Task<IActionResult> ThrowNotFoundInDbExcption() =>
        throw new NotFoundInDbExcption(nameof(Role), Guid.NewGuid().ToString());

    [HttpGet("HttpResponseException")]
    public Task<IActionResult> ThrowHttpResponseException()
    {
        var message = new HttpResponseMessage(HttpStatusCode.NotFound)
        {
            Content = new StringContent("Response message context test"),
            ReasonPhrase = "Reson phrase text"
        };
        throw new System.Web.Http.HttpResponseException(message);
    }

    [HttpGet("HttpResponseMessage")]
    public HttpResponseMessage ReturnHttpResponseMessage()
    {
        var message = new HttpResponseMessage(HttpStatusCode.NotFound)
        {
            Content = new StringContent("Response message context test"),
            ReasonPhrase = "Reson phrase text"
        };
        return message;
    }
}
