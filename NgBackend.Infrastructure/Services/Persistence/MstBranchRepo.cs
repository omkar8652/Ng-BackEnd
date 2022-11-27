using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;
using NgBackend.Infrastructure.Data;

namespace NgBackend.Infrastructure.Services.Persistence
{
    public class MstBranchRepo : IMstBranch
    {
        private readonly DotNetDBcontext _dotNetDBcontext;

        public MstBranchRepo(DotNetDBcontext dotNetDBcontext)
        {
            _dotNetDBcontext = dotNetDBcontext;
        }

        public async Task<List<MstBranch>> GetAll()
        {
            var result = _dotNetDBcontext.MstBranches.ToList();
            return result;
            throw new NotImplementedException();
        }
    }
}