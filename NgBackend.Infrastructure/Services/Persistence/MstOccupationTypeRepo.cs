using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;
using NgBackend.Infrastructure.Data;

namespace NgBackend.Infrastructure.Services.Persistence
{
    public class MstOccupationTypeRepo : IMstOccupationType
    {
        private readonly DotNetDBcontext _dotNetDBcontext;
        public MstOccupationTypeRepo(DotNetDBcontext dotNetDBcontext)
        {
            _dotNetDBcontext = dotNetDBcontext;
        }
        public async Task<List<MstOccupationType>> GetAll()
        {
            var Result = _dotNetDBcontext.MstOccupationTypes.ToList();
            return Result;
            throw new NotImplementedException();
        }
    }
}