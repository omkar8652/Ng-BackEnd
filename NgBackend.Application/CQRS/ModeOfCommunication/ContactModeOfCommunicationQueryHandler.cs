using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.ModeOfCommunication
{
    public class ContactModeOfCommunicationQueryHandler : IRequestHandler<ContactModeOfCommunicationQuery, List<ContactModeOfCommunication>>
    {
        private readonly IContactModeOfCommunication _contactModeOfCommunication;

        public ContactModeOfCommunicationQueryHandler(IContactModeOfCommunication contactModeOfCommunication)
        {
            _contactModeOfCommunication = contactModeOfCommunication;
        }

        public Task<List<ContactModeOfCommunication>> Handle(ContactModeOfCommunicationQuery request, CancellationToken cancellationToken)
        {
            var Result = _contactModeOfCommunication.GetAll();
            return Result;
            throw new NotImplementedException();
        }
    }
}