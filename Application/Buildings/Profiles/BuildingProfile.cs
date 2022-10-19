using Application.BuildingAddresses.DTOs;
using Application.Buildings.DTOs;
using AutoMapper;
using Infrastructure.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Buildings.Profiles
{
    public class BuildingProfile : Profile
    {
        public BuildingProfile()
        {
            CreateMap<Building, AllBuildingsDTO>().ReverseMap();
            CreateMap<Building, BuildingByIdDTO>().ReverseMap();
        }
    }
    public class BuildingAddressProfile : Profile
    {
        public BuildingAddressProfile()
        {
            //CreateMap<Building, BuildingDTO>()
            //    .ForMember(dest=>dest.Id, options=>options.MapFrom(src=>src.Id));
            CreateMap<BuildingAddress, BuildingAddressDTO>().ReverseMap();
            CreateMap<BuildingAddress, AddBuildingAddressDTO>().ReverseMap();
            CreateMap<BuildingAddress, UpdateBuildingAddressDTO>().ReverseMap();
        }
    }
}
