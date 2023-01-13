using Application.InspectionTasks.DTOs;
using Infrastructure.Models.Domain;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Buildings.DTOs;
using Application.PropertyManagers.DTOs;
using Application.InspectionProtocols.DTOs;
using Application.Properties.DTOs;
using Application.Users.DTOs;

namespace Application.InspectionTasks.Profiles
{
    public class InspectionTaskProfile : Profile
    {
        public InspectionTaskProfile()
        {
            CreateMap<InspectionTask, AllInspectionTasksDTO>().ReverseMap();
            CreateMap<InspectionTask, InspectionTaskByIdDTO>().ReverseMap();
            CreateMap<Building, AllBuildingsDTO>().ReverseMap();
            CreateMap<PropertyManager, PropertyManagerDTO>().ReverseMap();
            CreateMap<InspectionProtocol, AllInspectionProtocolsDTO>().ReverseMap();
            CreateMap<Property, AllPropertiesDTO>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
