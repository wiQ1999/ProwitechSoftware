using Application.Interfaces.Services;
using Infrastructure.Helpers;
using Infrastructure.Models.Enums;
using System.Security.Claims;

namespace Application.Authentication.Services;

public class ClaimProvider : IClaimProvider
{
    const string CLAIM_TYPE = "permissions";

    public Claim CreateClaim(string type, string value)
        => new (type, value);

    public Claim CreatePermissionClaim(AppSource source, PermissionProperty permissionProperty)
    {
        string sourceValue = source.SwapToJsonProperty();
        string propertyValue = permissionProperty.SwapToJsonProperty();
        string permission = $"{sourceValue}_{propertyValue}";

        var claim = new Claim(CLAIM_TYPE, permission);

        return claim;
    }
}
