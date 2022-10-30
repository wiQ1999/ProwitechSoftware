using Application.Authentication.Services;
using Application.Interfaces.Services;
using Infrastructure.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using Web.Authorization;

namespace Web.AuthorizeAttributes;

public class SourcePermissionsAttribute : TypeFilterAttribute
{
    private readonly IClaimProvider _claimProvider = new ClaimProvider();

    public SourcePermissionsAttribute(
        AppSource source, PermissionProperty permissionProeprty) 
        : base(typeof(SourcePermissionsFilter))
    {
        Arguments = new object[]
        {
            _claimProvider.CreateClaim(source, permissionProeprty)
        };
    }

    public SourcePermissionsAttribute(
        AppSource source, params PermissionProperty[] permissionProeprties)
        : base(typeof(SourcePermissionsFilter))
    {
        var claims = permissionProeprties.Select(pp 
            => _claimProvider.CreateClaim(source, pp));

        Arguments = claims.ToArray<object>();
    }
}
