using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Buildings.Commands.Requests
{
    public record CreateBuildingCommand:IRequest<Guid>
    {
        [Required]
        Guid BuildingAddressId { get; set; }
        [Required]
        string Type { get; set; }
        [Required]
        Guid PropertyManagerId { get; set; }
    }
}
