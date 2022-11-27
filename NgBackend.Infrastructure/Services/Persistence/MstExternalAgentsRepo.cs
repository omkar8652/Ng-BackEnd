using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;
using NgBackend.Infrastructure.Data;

namespace NgBackend.Infrastructure.Services.Persistence
{
    public class MstExternalAgentsRepo : IMstExternalAgents
    {
        private readonly DotNetDBcontext _dotNetDBcontext;

        public MstExternalAgentsRepo(DotNetDBcontext dotNetDBcontext)
        {
            _dotNetDBcontext = dotNetDBcontext;
        }

        public async Task<List<MstExternalAgents>> GetAll()
        {
            var Result = _dotNetDBcontext.MstExternalAgents.ToList();
            return Result;
            throw new NotImplementedException();
        }
    }
}