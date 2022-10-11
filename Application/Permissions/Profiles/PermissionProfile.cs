using Application.Permissions.DTOs;
using Application.Roles.DTOs;
using Application.Users.DTOs;
using AutoMapper;
using Infrastructure.Models.Domain;

namespace Application.Permissions.Profiles;
public class PermissionProfile : Profile
{
    public PermissionProfile()
    {
        CreateMap<Permission, PermissionDto>().ReverseMap();
        CreateMap<User, UserDto>().ReverseMap();
        CreateMap<Role, RoleDto>().ReverseMap();
    }
}
