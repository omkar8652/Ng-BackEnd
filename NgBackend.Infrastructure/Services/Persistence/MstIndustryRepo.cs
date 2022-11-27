using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;
using NgBackend.Infrastructure.Data;

namespace NgBackend.Infrastructure.Services.Persistence
{
    public class MstIndustryRepo : IMstIndustry
    {
        private readonly DotNetDBcontext _dotNetDBcontext;

        public MstIndustryRepo(DotNetDBcontext dotNetDBcontext)
        {
            _dotNetDBcontext = dotNetDBcontext;
        }
        public async Task<List<MstIndustry>> GetAll()
        {
             var Result = _dotNetDBcontext.MstIndustries.ToList();
            return Result;
            throw new NotImplementedException();
        }
    }
}