using Application.FullAddresses.DTOs;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Interfaces.UnitOfWork;
using Infrastructure.Models.Domain;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.FullAddresses.HelperMethods
{
    public class FullAddressCRUDHelper
    {
        private readonly IRepositoriesUnitOfWork _unitOfWork;

        public FullAddressCRUDHelper(IRepositoriesUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
