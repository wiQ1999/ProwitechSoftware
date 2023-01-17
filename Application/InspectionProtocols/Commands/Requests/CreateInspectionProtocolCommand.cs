﻿using Application.InspectionProtocols.DTOs;
using Infrastructure.Models.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionProtocols.Commands.Requests
{
    public record CreateInspectionProtocolCommand : IRequest<Guid>
    {
        [Required]
       public CreateOrUpdateInspectionProtocolDTO InspectionProtocolDTO { get; set; }
    }
}
