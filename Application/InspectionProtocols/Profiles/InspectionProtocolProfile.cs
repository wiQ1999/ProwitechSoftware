using Application.Buildings.DTOs;
using Application.InspectionProtocols.DTOs;
using Application.InspectionTasks.DTOs;
using Application.PropertyManagers.DTOs;
using Application.RealProperties.DTOs;
using Application.Residents.DTOs;
using Application.Users.DTOs;
using AutoMapper;
using Infrastructure.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionProtocols.Profiles
{
    public class InspectionProtocolProfile : Profile
    {
        public InspectionProtocolProfile()
        {
            CreateMap<CreateOrUpdateInspectionProtocolDTO, InspectionProtocol>().ReverseMap();
            CreateMap<InspectionTask, InspectionTaskByIdDTO>().ReverseMap();
            CreateMap<Building, AllBuildingsDTO>().ReverseMap();
            CreateMap<PropertyManager, PropertyManagerDTO>().ReverseMap();
            CreateMap<InspectionProtocol, AllInspectionProtocolsDTO>().ReverseMap();
            CreateMap<InspectionProtocol, InspectionProtocolByIdDTO>().ReverseMap();
            CreateMap<RealProperty, AllRealPropertiesDTO>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Resident, ResidentDTO>().ReverseMap();
        }
    }
}
