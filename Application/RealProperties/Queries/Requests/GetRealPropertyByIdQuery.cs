using Application.RealProperties.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.RealProperties.Queries.Requests
{
    public record GetRealPropertyByIdQuery : IRequest<AllRealPropertiesDTO>
    {
        [Required]
        public Guid Id { get; set; }
    }
}
