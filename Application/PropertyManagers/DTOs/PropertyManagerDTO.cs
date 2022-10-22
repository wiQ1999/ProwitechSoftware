using Infrastructure.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PropertyManagers.DTOs
{
    public class PropertyManagerDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? PhoneNumber { get; set; }
        public FullAddress? FullAddress { get; set; }
        //public ICollection<Building> Buildings { get; set; }
    }
}
