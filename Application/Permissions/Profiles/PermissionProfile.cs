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
        CreateMap<Permission, PermissionDto>()
            .ForMember(p => p.Create, mo => mo.MapFrom(p => p.Create ?? false))
            .ForMember(p => p.Read, mo => mo.MapFrom(p => p.Read ?? false))
            .ForMember(p => p.Update, mo => mo.MapFrom(p => p.Update ?? false))
            .ForMember(p => p.Delete, mo => mo.MapFrom(p => p.Delete ?? false))
            .ReverseMap();

        CreateMap<User, UserDto>().ReverseMap();
        CreateMap<Role, RoleDto>().ReverseMap();
    }
}
