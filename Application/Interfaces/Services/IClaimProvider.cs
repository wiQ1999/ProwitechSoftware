using Infrastructure.Models.Enums;
using System.Security.Claims;

namespace Application.Interfaces.Services;

public interface IClaimProvider
{
    Claim CreateClaim(
        AppSource source, 
        PermissionProperty permissionProperty);
}
