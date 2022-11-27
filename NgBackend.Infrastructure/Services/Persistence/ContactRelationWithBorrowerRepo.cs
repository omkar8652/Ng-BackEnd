using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;
using NgBackend.Infrastructure.Data;

namespace NgBackend.Infrastructure.Services.Persistence
{
    public class ContactRelationWithBorrowerRepo : IContactRelationWithBorrower
    {
        private readonly DotNetDBcontext _dotNetDBcontext;

        public ContactRelationWithBorrowerRepo(DotNetDBcontext dotNetDBcontext)
        {
            _dotNetDBcontext = dotNetDBcontext;
        }

        public async Task<List<ContactRelationWithBorrower>> GetAll()
        {
            var Result = _dotNetDBcontext.ContactRelationWithBorrowers.ToList();
            return Result;
            throw new NotImplementedException();
        }
    }
}