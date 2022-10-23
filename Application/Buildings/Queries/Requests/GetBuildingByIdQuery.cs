using Application.Buildings.DTOs;
using Infrastructure.Models.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Buildings.Queries.Requests
{
    public record GetBuildingByIdQuery:IRequest<BuildingByIdDTO>
    {
        [Required]
        public Guid Id { get; set; }
    }
}
