using Infrastructure.Models.Enums;
using System.Security.Claims;

namespace Application.Interfaces.Services;

public interface IClaimProvider
{
    Claim CreateClaim(string type, string value);

    Claim CreatePermissionClaim(AppSource source, PermissionProperty permissionProperty);
}
