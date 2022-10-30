using Application.Interfaces.Services;
using Infrastructure.Models.Enums;
using System.Security.Claims;

namespace Application.Authentication.Services;

public class ClaimProvider : IClaimProvider
{
    public const string CLAIM_TYPE = "Permissions";

    public Claim CreateClaim(
        AppSource source, PermissionProperty permissionProperty)
    {
        var value = $"{source}_{permissionProperty}";
        var claim = new Claim(CLAIM_TYPE, value);
        return claim;
    }
}
