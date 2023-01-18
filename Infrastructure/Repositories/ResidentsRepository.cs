using Infrastructure.Database;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ResidentsRepository : IResidentsRepository
    {
        private readonly ProwitechDbContext _dbContext;

        public ResidentsRepository(ProwitechDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Resident>> GetAllAsync(CancellationToken cancellationToken) =>
            await _dbContext.Residents.ToArrayAsync(cancellationToken);

        public async Task<Resident?> GetAsync(Guid id, CancellationToken cancellationToken) =>
            await _dbContext.Residents.FirstOrDefaultAsync(b => b.Id == id, cancellationToken);

        public async Task<Guid> AddAsync(Resident resident, CancellationToken cancellationToken)
        {
            await _dbContext.Residents.AddAsync(resident, cancellationToken);
            return resident.Id;
        }
        public async Task UpdateAsync(Resident resident, CancellationToken cancellationToken)
        {
            _dbContext.Entry(resident).State = EntityState.Modified;
        }
        
        public async Task DeleteResidentIfNoProtocolsAreAssignedToThem(Resident resident, CancellationToken cancellationToken)
        {
            if (!await _dbContext.InspectionProtocols.AnyAsync(ip => ip.ResidentId == resident.Id))
            {
                await DeleteAsync(resident.Id, cancellationToken);
            }
        }
        
        public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            Resident? resident = await _dbContext.Residents.FirstOrDefaultAsync(ba => ba.Id == id, cancellationToken);
            if (resident == null)
                throw new Exception($"Nie można usunąć Mieszkańca Nieruchomości - brak Mieszkańca o identyfikatorze {id}.");
            _dbContext.Residents.Remove(resident);
        }
        public async Task<Guid> CreateOrGetResident(Resident resident, CancellationToken cancellationToken)
        {
            Resident? residentFromDB = await _dbContext.Residents.FirstOrDefaultAsync(
                r=>r.FirstName == resident.FirstName
                && r.LastName == resident.LastName
                && r.PhoneNumber == resident.PhoneNumber, cancellationToken);
            if(residentFromDB!=null) return residentFromDB.Id;
            return await AddAsync(resident, cancellationToken);
        }
        public async Task<Guid> UpdateOrGetOrCreateResident(Resident newResident, Resident oldResident, Guid inspectionProtocolId, CancellationToken cancellationToken)
        {
           Resident? residentWithTheSameDataFromDB = await _dbContext.Residents.FirstOrDefaultAsync(
                r =>
                r.Id!=newResident.Id
                && r.FirstName == newResident.FirstName
                && r.LastName == newResident.LastName
                && r.PhoneNumber == newResident.PhoneNumber, cancellationToken);
            //OPCJA 1:
            //W DB znajduje się już Resident o podanych danych
            if (residentWithTheSameDataFromDB != null)
            {
                //jeżeli stary Resident nie jest przypisany do żadnego innego protokołu poza obecnym, usuń go
                if (!await _dbContext.InspectionProtocols.AnyAsync(ip => ip.Id != inspectionProtocolId && ip.ResidentId == oldResident.Id))
                {
                    await DeleteAsync(oldResident.Id, cancellationToken);
                    //TODO saveChangesAsync?
                }
                return residentWithTheSameDataFromDB.Id;
            }
            //OPCJA 2:
            //W DB nie ma Residenta o podanych danych, ale do starego Residenta są przypisane Protokoły
            //--> utwórz nowego Residenta, a starego nie ruszaj
            if (await _dbContext.InspectionProtocols.AnyAsync(ip => ip.Id != inspectionProtocolId && ip.ResidentId == oldResident.Id))
            {
                return await AddAsync(newResident, cancellationToken);
            }

            //OPCJA 3:
            //W DB nie ma Residenta o podanych danych i do starego Residenta nie ma przypisanych żadnych protokołów oprócz tego
            //--> utwórz nowego Residenta, a starego nie ruszaj
            oldResident.FirstName = newResident.FirstName;
            oldResident.LastName= newResident.LastName;
            oldResident.PhoneNumber = newResident.PhoneNumber;
            
            UpdateAsync(oldResident, cancellationToken);
            return oldResident.Id;
        }
    }

}
