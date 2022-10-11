using Application.Roles.DTOs;
using AutoMapper;
using Infrastructure.Models.Domain;

namespace Application.Roles.Profiles;
public class RoleProfile : Profile
{
	public RoleProfile()
	{
		CreateMap<Role, RoleDto>().ReverseMap();
	}
}
