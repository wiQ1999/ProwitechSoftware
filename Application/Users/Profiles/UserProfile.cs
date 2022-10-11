using Application.Roles.DTOs;
using Application.Users.DTOs;
using AutoMapper;
using Infrastructure.Models.Domain;

namespace Application.Users.Profiles;
public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<User, UserDto>().ReverseMap();
        CreateMap<Role, RoleDto>().ReverseMap();
    }
}
