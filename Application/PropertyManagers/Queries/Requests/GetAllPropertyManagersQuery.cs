﻿using Application.PropertyManagers.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PropertyManagers.Queries.Requests
{
    public record GetAllPropertyManagersQuery:IRequest<IEnumerable<PropertyManagerDTO>>
    {
    }
}
