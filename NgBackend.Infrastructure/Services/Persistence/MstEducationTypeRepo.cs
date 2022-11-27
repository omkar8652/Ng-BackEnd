using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;
using NgBackend.Infrastructure.Data;

namespace NgBackend.Infrastructure.Services.Persistence
{
    public class MstEducationTypeRepo : IMstEducationType
    {
        private readonly DotNetDBcontext _dotNetDBcontext;

        public MstEducationTypeRepo(DotNetDBcontext dotNetDBcontext)
        {
            _dotNetDBcontext = dotNetDBcontext;
        }

        public async Task<List<MstEducationType>> GetAll()
        {
            var Result = _dotNetDBcontext.MstEducationTypes.ToList();
            return Result;
            throw new NotImplementedException();
        }
    }
}