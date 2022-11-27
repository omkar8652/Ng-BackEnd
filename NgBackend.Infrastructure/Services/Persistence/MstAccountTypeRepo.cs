using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;
using NgBackend.Infrastructure.Data;

namespace NgBackend.Infrastructure.Services.Persistence
{
    public class MstAccountTypeRepo : IMstAccountType
    {
          private readonly DotNetDBcontext _dotNetDBcontext;

        public MstAccountTypeRepo(DotNetDBcontext dotNetDBcontext)
        {
            _dotNetDBcontext = dotNetDBcontext;
        }
        public async Task<List<MstAccountType>> GetAll()
        {
            var Result = _dotNetDBcontext.MstAccountTypes.ToList();
            return Result;
            throw new NotImplementedException();
        }
    }
}