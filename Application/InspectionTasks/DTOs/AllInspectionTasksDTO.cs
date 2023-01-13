using Application.Buildings.DTOs;
using Application.Users.DTOs;
using Infrastructure.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionTasks.DTOs
{
    public record AllInspectionTasksDTO
    {
        public Guid Id { get; set; }
        public UserDto? TaskDelegator { get; set; }
        public UserDto? TaskPerformer { get; set; }
        public string Status { get; set; }
        public AllBuildingsDTO Building { get; set; }
        public DateTime DueStartDateTime { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
    }
}
