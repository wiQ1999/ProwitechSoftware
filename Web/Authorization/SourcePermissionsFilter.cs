using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Claims;

namespace Web.Authorization;

public class SourcePermissionsFilter : IAuthorizationFilter
{
    private readonly Claim[] _claims;

	public SourcePermissionsFilter(Claim[] claims)
	{
		_claims = claims;
	}

	public void OnAuthorization(AuthorizationFilterContext context)
	{
		var claimsExist = _claims.All(c
			=> context.HttpContext.User.Claims.Any(uc
				=> uc.Type == c.Type && uc.Value == c.Value));

		if (!claimsExist)
			throw new Exception("Brak uprawnień");
    }
}
