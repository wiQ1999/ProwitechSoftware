﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Buildings.Commands.Requests
{
    public record DeleteBuildingCommand:IRequest
    {
        public Guid Id { get; set; }
    }
}
