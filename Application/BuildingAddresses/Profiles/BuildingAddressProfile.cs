using Application.BuildingAddresses.DTOs;
using AutoMapper;
using Infrastructure.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BuildingAddresses.Profiles
{
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
