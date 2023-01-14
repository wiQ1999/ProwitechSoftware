using Infrastructure.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.RealProperties.DTOs
{
    public class RealPropertyInListDTO
    {
        public Guid Id { get; set; }
        public PropertyAddress? PropertyAddress { get; set; }
    }
}
