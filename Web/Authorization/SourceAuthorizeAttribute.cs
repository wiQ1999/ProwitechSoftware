using Application.Authentication.Services;
using Application.Interfaces.Services;
using Infrastructure.Models.Enums;
using Microsoft.AspNetCore.Mvc;

namespace Web.Authorization;

public class SourcePermissionsAttribute : TypeFilterAttribute
{
    private readonly IClaimProvider _claimProvider = new ClaimProvider();

    public SourcePermissionsAttribute(
        AppSource source, PermissionProperty permissionProperty)
        : base(typeof(SourcePermissionsFilter))
    {
        Arguments = new object[]
        {
            _claimProvider.CreatePermissionClaim(source, permissionProperty)
        };
    }

    public SourcePermissionsAttribute(
        AppSource source, params PermissionProperty[] permissionProperties)
        : base(typeof(SourcePermissionsFilter))
    {
        var claims = permissionProperties.Select(pp
            => _claimProvider.CreatePermissionClaim(source, pp));

        Arguments = claims.ToArray<object>();
    }
}
