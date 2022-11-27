using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;
using NgBackend.Infrastructure.Data;

namespace NgBackend.Infrastructure.Services.Persistence
{
    public class MstDsaRepo : IMstDsa    
    {
            private readonly DotNetDBcontext _dotNetDBcontext;

        public MstDsaRepo(DotNetDBcontext dotNetDBcontext)
        {
            _dotNetDBcontext = dotNetDBcontext;
        }

        public async Task<List<MstDsa>> GetAll()
        {   
            var Result = _dotNetDBcontext.MstDsas.ToList();
            return Result;
            throw new NotImplementedException();
        }
    }
}