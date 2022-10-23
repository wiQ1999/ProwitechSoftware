using Application.BuildingAddresses.DTOs;
using Application.Buildings.DTOs;
using Application.PropertyManagers.DTOs;
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
            CreateMap<PropertyManager, PropertyManagerDTO>().ReverseMap();
        }
    }
    
}
