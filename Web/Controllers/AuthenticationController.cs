using Application.Authentication.Queries.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[Route("[controller]")]
public class AuthenticationController : ApiControllerBase
{
    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> Login(string login, string password)
        => Ok(await Mediator.Send(new LoginQuery(login, password)));

    [HttpGet]
    public async Task<IActionResult> RefreshToken(Guid userId, string currentToken)
        => Ok(await Mediator.Send(new RefreshTokenQuery(userId, currentToken)));
}
