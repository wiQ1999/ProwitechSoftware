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
        public Guid BuildingAddressId { get; set; }
        [Required]
        public string Type { get; set; }
        //[Required]
        public Guid PropertyManagerId { get; set; }
    }
}
