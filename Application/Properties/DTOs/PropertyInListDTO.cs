using Infrastructure.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Properties.DTOs
{
    public class PropertyInListDTO
    {
        public Guid Id { get; set; }
        public PropertyAddress? PropertyAddress { get; set; }
    }
}
