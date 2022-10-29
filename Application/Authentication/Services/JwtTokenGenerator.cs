using Application.Interfaces.Services;
using Application.Permissions.DTOs;
using Application.Users.DTOs;
using Infrastructure.Models.Enums;
using Infrastructure.Models.Settings;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Infrastructure.Authentication;

public class JwtTokenGenerator : IJwtTokenGenerator
{
    private readonly JwtSettings _jwtSettings;
    private SigningCredentials _signingCredentials = null!;
    private List<Claim> _claims = new();

    public JwtTokenGenerator(IOptions<JwtSettings> jwtSettings)
    {
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

        AddClaim(user.Id.ToString());
        AddClaimIfNotNullOrEmpty(user.Login);
        AddClaimIfNotNullOrEmpty(user.FirstName);
        AddClaimIfNotNullOrEmpty(user.LastName);
        AddClaimIfNotNullOrEmpty(user.Email);

        if (user.Role != null)
        {
            AddClaim(user.Role.Id.ToString(), "RoleId");
            AddClaimIfNotNullOrEmpty(user.Role.Name, "RoleName");
        }

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

    private void AddClaim(string value, string? type = null)
    {
        string claimType = type ?? nameof(value);
        var claim = new Claim(claimType, value);
        _claims.Add(claim);
    }

    private void AddClaimIfNotNullOrEmpty(string value, string? type = null)
    {
        if (!string.IsNullOrEmpty(value))
            AddClaim(value, type);
    }

    private void AddClaimForPermission(
        PermissionDto permission, PermissionProperty permissionProperty)
    {
        var claim = new Claim(
            "Permissions", $"{permission.Source.ToString()}_{permissionProperty.ToString()}");
        _claims.Add(claim);
    }
}
