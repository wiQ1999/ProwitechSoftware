using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Authorize]
public class ApiControllerBase : ControllerBase
{
    private IMediator _mediator = null!;

    protected IMediator Mediator => _mediator ??= 
        HttpContext.RequestServices.GetRequiredService<IMediator>();
}
