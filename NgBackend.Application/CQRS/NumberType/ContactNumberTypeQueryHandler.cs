using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.NumberType
{
    public class ContactNumberTypeQueryHandler : IRequestHandler<ContactNumberTypeQuery, List<ContactNumberType>>
    {
        private readonly IContactNumberType _contactNumberType;

        public ContactNumberTypeQueryHandler(IContactNumberType contactNumberType)
        {
            _contactNumberType = contactNumberType;
        }

        public Task<List<ContactNumberType>> Handle(ContactNumberTypeQuery request, CancellationToken cancellationToken)
        {
            var Result = _contactNumberType.GetAll();
            return Result;
            throw new NotImplementedException();
        }
    }
}