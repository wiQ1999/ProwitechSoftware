using Application.Permissions.DTOs;
using Application.Roles.DTOs;
using Application.Users.DTOs;
using AutoMapper;
using Infrastructure.Common.Helpers;
using Infrastructure.Models.Domain;
using Infrastructure.Models.Enums;

namespace Application.Permissions.Profiles;
public class NullablePermissionProfile : Profile
{
	public NullablePermissionProfile()
	{
        CreateMap<Permission, NullablePermissionDto>()
            .ForMember(p => p.Source, mo => mo.MapFrom(p => p.Source.GetDescription()));

        CreateMap<NullablePermissionDto, Permission>()
            .ForMember(p => p.Source, mo => mo.MapFrom(p => p.Source.GetEnumFromDescription<AppSource>()));

        CreateMap<User, UserDto>().ReverseMap();
        CreateMap<Role, RoleDto>().ReverseMap();
    }
}
