using Application.Errors.Queries.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[AllowAnonymous]
[ApiExplorerSettings(IgnoreApi = true)]
public class ErrorHandlerController : ApiControllerBase
{
    [Route("Error")]
    public async Task<IActionResult> ReturnDevelopmentError()
    {
        Exception? exception = 
            HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;
        if (exception == null)
            return Problem();

        var response = await Mediator.Send(
            new GetHandledExceptionResponseQuerie(exception));
        return Problem(
            title: response.Title, 
            statusCode: (int)response.StatusCode, 
            detail: response.Detail);
    }
}
