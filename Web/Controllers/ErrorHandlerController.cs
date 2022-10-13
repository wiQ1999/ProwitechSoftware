using Infrastructure.Models.ExceptionResponses;
using Infrastructure.Models.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[AllowAnonymous]
[ApiExplorerSettings(IgnoreApi = true)]
public class ErrorHandlerController : ApiControllerBase
{
    [Route("ErrorDev")]
    public DetailExceptionResponse ReturnDevelopmentError() =>
        new(HandleExcpoetion());

    private Exception HandleExcpoetion()
    {
        Exception? exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;
        if (exception == null)
            return null!;

        if (exception is NotFoundInDbExcption)
            HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
        // ...
        else HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;

        return exception;
    }

    [Route("ErrorProd")]
    public BaseExceptionResponse ReturnProductionError() =>
        new(HandleExcpoetion());
}
