using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;
using NgBackend.Infrastructure.Data;

namespace NgBackend.Infrastructure.Services.Persistence
{
    public class MstAgentsRepo : IMstAgents
    {
         private readonly DotNetDBcontext _dotNetDBcontext;

        public MstAgentsRepo(DotNetDBcontext dotNetDBcontext)
        {
            _dotNetDBcontext = dotNetDBcontext;
        }

        public async Task<List<MstAgents>> GetAll()
        {   
            var result = _dotNetDBcontext.MstAgents.ToList();
            return result;
            throw new NotImplementedException();
        }
    }
}