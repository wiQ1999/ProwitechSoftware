using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;
public class ApiControllerBase : ControllerBase
{
    private IMediator _mediator = null!;

    protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<IMediator>();
}
