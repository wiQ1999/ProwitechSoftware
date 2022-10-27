using Application.Interfaces.Services;
using Application.Permissions.DTOs;
using Infrastructure.Models.Domain;
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

    public JwtTokenGenerator(IOptions<JwtSettings> jwtSettings)
    {
        _jwtSettings = jwtSettings.Value;
    }

    public string GenerateToken(
        User user, 
        IEnumerable<PermissionDto> permissions)
    {
        var signingCredentials = new SigningCredentials(
            new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_jwtSettings.Key)),
            SecurityAlgorithms.HmacSha256);

        var claims = new List<Claim>
        {
            new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
            new Claim(JwtRegisteredClaimNames.GivenName, user.FirstName),
            new Claim(JwtRegisteredClaimNames.FamilyName, user.LastName),
            new Claim(JwtRegisteredClaimNames.Email, user.Email),
        };

        foreach (var permission in permissions)
        {
            if (permission.Create)
                claims.Add(CreateClaimForPermission(permission, PermissionProperty.Create));
            if (permission.Read)
                claims.Add(CreateClaimForPermission(permission, PermissionProperty.Read));
            if (permission.Update)
                claims.Add(CreateClaimForPermission(permission, PermissionProperty.Update));
            if (permission.Delete)
                claims.Add(CreateClaimForPermission(permission, PermissionProperty.Delete));
        }

        var securityToken = new JwtSecurityToken(
            signingCredentials: signingCredentials,
            issuer: _jwtSettings.Issuer,
            audience: _jwtSettings.Audience,
            expires: DateTime.Now.AddHours(_jwtSettings.ExpiryHours),
            claims: claims);

        return new JwtSecurityTokenHandler().WriteToken(securityToken);
    }

    private Claim CreateClaimForPermission(
        PermissionDto permission, PermissionProperty permissionProperty)
        => new($"{permission.Source}_{permissionProperty}", "true");
}
