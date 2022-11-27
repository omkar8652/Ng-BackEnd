using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;
using NgBackend.Infrastructure.Data;

namespace NgBackend.Infrastructure.Services.Persistence
{
    public class MstBusinessEntityTypeRepo : IMstBusinessEntityType
    {
        private readonly DotNetDBcontext _dotNetDBcontext;

        public MstBusinessEntityTypeRepo(DotNetDBcontext dotNetDBcontext)
        {
            _dotNetDBcontext = dotNetDBcontext;
        }

        public async Task<List<MstBusinessEntityType>> GetAll()
        {
            var Result = _dotNetDBcontext.MstBusinessEntityTypes.ToList();
            return Result;
            throw new NotImplementedException();
        }
    }
}