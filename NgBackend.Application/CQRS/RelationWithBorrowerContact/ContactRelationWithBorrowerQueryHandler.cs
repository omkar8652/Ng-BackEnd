using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.RelationWithBorrowerContact
{
    public class ContactRelationWithBorrowerQueryHandler : IRequestHandler<ContactRelationWithBorrowerQuery, List<ContactRelationWithBorrower>>
    {
        private readonly IContactRelationWithBorrower _contactRelationWithBorrower;

        public ContactRelationWithBorrowerQueryHandler(IContactRelationWithBorrower contactRelationWithBorrower)
        {
            _contactRelationWithBorrower = contactRelationWithBorrower;
        }

        public Task<List<ContactRelationWithBorrower>> Handle(ContactRelationWithBorrowerQuery request, CancellationToken cancellationToken)
        {
            var Result = _contactRelationWithBorrower.GetAll();
            return Result;
            throw new NotImplementedException();
        }
    }
}