using Infrastructure.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces.Repositories
{
    public interface IInspectionProtocolsRepository
    {
        Task<IEnumerable<InspectionProtocol>> GetAllAsync(CancellationToken cancellationToken);
        Task<InspectionProtocol> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<Guid> AddAsync(InspectionProtocol inspectionProtocol, CancellationToken cancellationToken);
        Task UpdateAsync(InspectionProtocol inspectionProtocol, Guid oldResidentId, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
        Task<IEnumerable<InspectionProtocol>> GetInspectionProtocolsOfParticularPerformer(Guid userId, CancellationToken cancellationToken);
        Task<IEnumerable<InspectionProtocol>> GetInspectionProtocolsOfParticularTask(Guid inspectionTaskId, CancellationToken cancellationToken);
        Task<IEnumerable<InspectionProtocol>> GetProtocolsOfParticularBuilding(Guid buildingId, CancellationToken cancellationToken);
        Task CheckIfInspectionProtocolWithThisNumberExists(Guid oldProtocolId, string newNumber, CancellationToken cancellation);
        Task<string> GetTheBiggestProtocolNumber(string today, CancellationToken cancellation);
    }
}
