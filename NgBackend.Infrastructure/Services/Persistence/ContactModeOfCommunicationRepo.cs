using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;
using NgBackend.Infrastructure.Data;

namespace NgBackend.Infrastructure.Services.Persistence
{
    public class ContactModeOfCommunicationRepo : IContactModeOfCommunication
    {
         private readonly DotNetDBcontext _dotNetDBcontext;

        public ContactModeOfCommunicationRepo(DotNetDBcontext dotNetDBcontext)
        {
            _dotNetDBcontext = dotNetDBcontext;
        }

        public async Task<List<ContactModeOfCommunication>> GetAll()
        {
            var Result = _dotNetDBcontext.ContactModeOfCommunications.ToList();
            return Result;
            throw new NotImplementedException();
        }
    }
}