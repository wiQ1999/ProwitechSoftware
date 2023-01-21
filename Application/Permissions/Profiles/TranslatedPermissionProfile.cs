using Application.Permissions.DTOs;
using Application.Roles.DTOs;
using Application.Users.DTOs;
using AutoMapper;
using Infrastructure.Helpers;
using Infrastructure.Models.Domain;
using Infrastructure.Models.Enums;

namespace Application.Permissions.Profiles;

public class TranslatedPermissionProfile : Profile
{
    public TranslatedPermissionProfile()
    {
        CreateMap<Permission, TranslatedPermissionDto>()
            .ForMember(p => p.Source, mo => mo.MapFrom(p => p.Source.GetDescription()))
            .ForMember(p => p.Create, mo => mo.MapFrom(p => p.Create ?? false))
            .ForMember(p => p.Read, mo => mo.MapFrom(p => p.Read ?? false))
            .ForMember(p => p.Update, mo => mo.MapFrom(p => p.Update ?? false))
            .ForMember(p => p.Delete, mo => mo.MapFrom(p => p.Delete ?? false));

        CreateMap<TranslatedPermissionDto, Permission>()
            .ForMember( p => p.Source, mo => mo.MapFrom(p => p.Source.GetEnumFromDescription<AppSource>()));

        CreateMap<User, UserDto>().ReverseMap();
        CreateMap<Role, RoleDto>().ReverseMap();
    }
}
