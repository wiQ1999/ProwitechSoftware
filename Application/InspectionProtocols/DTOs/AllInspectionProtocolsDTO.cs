using Application.InspectionTasks.DTOs;
using Application.RealProperties.DTOs;
using Application.Users.DTOs;
using Infrastructure.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionProtocols.DTOs
{
    public class AllInspectionProtocolsDTO
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public UserDto InspectionPerformer { get; set; }
        //public AllInspectionTasksDTO? InspectionTaskDTO { get; set; }
        public DateTime InspectionDateTime { get; set; }
        public AllRealPropertiesDTO InspectedProperty { get; set; }
        public Resident? Resident { get; set; }
    }
}
