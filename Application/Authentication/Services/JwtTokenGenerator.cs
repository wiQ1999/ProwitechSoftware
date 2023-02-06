using Application.Authentication.Models;
using Application.Interfaces.Services;
using Application.Permissions.DTOs;
using Application.Users.DTOs;
using Infrastructure.Models.Enums;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Application.Authentication.Services;

public class JwtTokenGenerator : IJwtTokenGenerator
{
    private readonly IClaimProvider _claimProvider;
    private readonly JwtSettings _jwtSettings;
    private SigningCredentials _signingCredentials = default!;
    private List<Claim> _claims = new();

    public JwtTokenGenerator(
        IClaimProvider claimProvider,
        IOptions<JwtSettings> jwtSettings)
    {
        _claimProvider = claimProvider;
        _jwtSettings = jwtSettings.Value;
    }

    public string GenerateToken(UserDto user, IEnumerable<PermissionDto> permissions)
    {
        CreateSigningCredentials();

        CreateClaims(user, permissions);

        var securityToken = new JwtSecurityToken(
            signingCredentials: _signingCredentials,
            claims: _claims,
            issuer: _jwtSettings.Issuer,
            audience: _jwtSettings.Audience,
            expires: DateTime.Now.AddHours(_jwtSettings.ExpiryHours));

        return new JwtSecurityTokenHandler().WriteToken(securityToken);
    }

    private void CreateSigningCredentials()
    {
        var key = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(_jwtSettings.Key));

        _signingCredentials = new SigningCredentials(
            key, SecurityAlgorithms.HmacSha256);
    }

    private void CreateClaims(UserDto user, IEnumerable<PermissionDto> permissions)
    {
        _claims = new();

        AddClaimIfNotNullOrEmpty("id", user.Id.ToString());
        AddClaimIfNotNullOrEmpty("login", user.Login);
        AddClaimIfNotNullOrEmpty("firstName", user.FirstName);
        AddClaimIfNotNullOrEmpty("lastName", user.LastName);
        AddClaimIfNotNullOrEmpty("roleId", user.Role?.Id.ToString());
        AddClaimIfNotNullOrEmpty("roleName", user.Role?.Name);

        foreach (var permission in permissions)
        {
            if (permission.Create)
                AddClaimForPermission(permission, PermissionProperty.Create);
            if (permission.Read)
                AddClaimForPermission(permission, PermissionProperty.Read);
            if (permission.Update)
                AddClaimForPermission(permission, PermissionProperty.Update);
            if (permission.Delete)
                AddClaimForPermission(permission, PermissionProperty.Delete);
        }
    }

    private void AddClaimIfNotNullOrEmpty(string type, string? value)
    {
        if (!string.IsNullOrEmpty(value))
        {
            var claim = _claimProvider.CreateClaim(type, value);
            _claims.Add(claim);
        }
    }

    private void AddClaimForPermission(PermissionDto permission, PermissionProperty permissionProperty)
    {
        var claim = _claimProvider.CreatePermissionClaim(permission.Source, permissionProperty);
        _claims.Add(claim);
    }
}
