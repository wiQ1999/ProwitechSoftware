using Infrastructure.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Web.Authorization;

namespace Web.AuthorizeAttributes;

public class SourcePermissionsAttribute : TypeFilterAttribute
{
    public SourcePermissionsAttribute(
        AppSource source, PermissionProperty permissionProeprty) 
        : base(typeof(SourcePermissionsFilter))
    {
        Arguments = new object[]
        {
            CreateClaim(source, permissionProeprty)
        };
    }

    public SourcePermissionsAttribute(
        AppSource source, params PermissionProperty[] permissionProeprties)
        : base(typeof(SourcePermissionsFilter))
    {
        var claims = permissionProeprties.Select(pp => CreateClaim(source, pp));
        Arguments = claims.ToArray<object>();
    }

    private Claim CreateClaim(
        AppSource source, PermissionProperty permissionProeprty)
        => new("Permissions", $"{source}_{permissionProeprty}");
}
