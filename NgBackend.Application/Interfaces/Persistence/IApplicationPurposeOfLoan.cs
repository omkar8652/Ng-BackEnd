using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.Interfaces.Persistence
{
    public interface IApplicationPurposeOfLoan
    {
        public Task<List<ApplicationPurposeOfLoan>> GetAll();
    }
}