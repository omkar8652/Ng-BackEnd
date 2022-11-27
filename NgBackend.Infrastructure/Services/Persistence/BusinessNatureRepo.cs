using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;
using NgBackend.Infrastructure.Data;

namespace NgBackend.Infrastructure.Services.Persistence
{
    public class BusinessNatureRepo : IBusinessNature
    {
           private readonly DotNetDBcontext _dotNetDBcontext;

        public BusinessNatureRepo(DotNetDBcontext dotNetDBcontext)
        {
            _dotNetDBcontext = dotNetDBcontext;
        }

        public async Task<List<BusinessNature>> GetAll()
        {
            var Result = _dotNetDBcontext.BusinessNatures.ToList();
            return Result;
            throw new NotImplementedException();
        }
    }
}