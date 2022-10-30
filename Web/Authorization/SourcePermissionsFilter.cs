using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Claims;

namespace Web.Authorization;

public class SourcePermissionsFilter : IAuthorizationFilter
{
    private readonly Claim _claim;

	public SourcePermissionsFilter(Claim claim)
	{
		_claim = claim;
	}

	public void OnAuthorization(AuthorizationFilterContext context)
	{
        var hasClaim = context.HttpContext.User.Claims.Any(c
            => c.Type == _claim.Type && c.Value == _claim.Value);

        if (!hasClaim)
            context.Result = new ForbidResult();
    }
}
