using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.Domain
{
    public class InspectionTask
    {
        public Guid Id { get; set; }
        public Guid? TaskDelegatorId { get; set; }
        public User? TaskDelegator { get; set; }
        public Guid? TaskPerformerId { get; set; }
        public User? TaskPerformer { get; set; }
        public string Status { get; set; }
        public Guid BuildingId { get; set; }
        public Building Building { get; set; }
        public DateTime? DueStartDateTime { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public ICollection<InspectionProtocol>? InspectionProtocols {get;set;}

    }
}
