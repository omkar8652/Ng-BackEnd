using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.ModeOfCommunication
{
    public class ContactModeOfCommunicationQuery : IRequest<List<ContactModeOfCommunication>>
    {
        public ContactModeOfCommunicationQuery()
        {
        }
    }
}