using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;
using NgBackend.Infrastructure.Data;

namespace NgBackend.Infrastructure.Services.Persistence
{
    public class BusinessAddressRepo : IBusinessAddress
    {
          private readonly DotNetDBcontext _dotNetDBcontext;

        public BusinessAddressRepo(DotNetDBcontext dotNetDBcontext)
        {
            _dotNetDBcontext = dotNetDBcontext;
        }
        public async Task<List<BusinessAddress>> GetAll()
        {
            var Result = _dotNetDBcontext.BusinessAddresses.ToList();
            return Result;
            throw new NotImplementedException();
        }
    }
}