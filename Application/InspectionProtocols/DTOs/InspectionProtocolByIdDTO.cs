using Application.InspectionTasks.DTOs;
using Application.RealProperties.DTOs;
using Application.Users.DTOs;
using Infrastructure.Models.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionProtocols.DTOs
{
    public class InspectionProtocolByIdDTO
    {
        public Guid Id { get; set; }

        public string Number { get; set; }

        public Resident ResidentDTO { get; set; }
        public CreateOrUpdateInspectionProtocolDTO InspectionProtocolDTO { get; set; }
    }
}
