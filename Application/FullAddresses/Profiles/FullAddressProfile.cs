using Application.BuildingAddresses.DTOs;
using Application.FullAddresses.DTOs;
using Application.PropertyManagers.DTOs;
using AutoMapper;
using Infrastructure.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.FullAddresses.Profiles
{
    public class FullAddressProfile : Profile
    {
        public FullAddressProfile()
        {

            CreateMap<FullAddress, FullAddressDTO>().ReverseMap();
            CreateMap<BuildingAddress, BuildingAddressDTO>().ReverseMap();
        }

    }
}
