using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;
using NgBackend.Infrastructure.Data;

namespace NgBackend.Infrastructure.Services.Persistence
{
    public class MstStateRepo : IMstState
    {
          private readonly DotNetDBcontext _dotNetDBcontext;

        public MstStateRepo(DotNetDBcontext dotNetDBcontext)
        {
            _dotNetDBcontext = dotNetDBcontext;
        }

        public async Task<List<MstState>> GetAll()
        {
            var Result = _dotNetDBcontext.MstStates.ToList();
            return Result;
            throw new NotImplementedException();
        }
    }
}