using Application.Authentication.Queries.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[AllowAnonymous]
[Route("[controller]")]
public class AuthenticationController : ApiControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Login([FromQuery]LoginQuery query)
        => Ok(await Mediator.Send(query));
}
