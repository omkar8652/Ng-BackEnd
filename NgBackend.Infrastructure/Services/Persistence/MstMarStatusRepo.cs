using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;
using NgBackend.Infrastructure.Data;

namespace NgBackend.Infrastructure.Services.Persistence
{
    public class MstMarStatusRepo : IMstMarStatus
    {
          private readonly DotNetDBcontext _dotNetDBcontext;
        public MstMarStatusRepo(DotNetDBcontext dotNetDBcontext)
        {
            _dotNetDBcontext = dotNetDBcontext;
        }
        public async Task<List<MstMarStatus>> GetAll()
        {
            var Result = _dotNetDBcontext.MstMarStatuses.ToList();
            return  Result;
            throw new NotImplementedException();
        }
    }
}