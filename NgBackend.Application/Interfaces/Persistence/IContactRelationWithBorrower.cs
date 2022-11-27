using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.Interfaces.Persistence
{
    public interface IContactRelationWithBorrower 
    {
        public Task<List<ContactRelationWithBorrower>> GetAll();
    }
}