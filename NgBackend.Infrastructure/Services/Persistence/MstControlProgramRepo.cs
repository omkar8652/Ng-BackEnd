using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;
using NgBackend.Infrastructure.Data;

namespace NgBackend.Infrastructure.Services.Persistence
{

    public class MstControlProgramRepo : IMstControlProgram
    {
        private readonly DotNetDBcontext _dotNetDBcontext;
        public MstControlProgramRepo(DotNetDBcontext dotNetDBcontext)
        {
            _dotNetDBcontext = dotNetDBcontext;
        }

        public async Task<List<MstControlProgram>> GetAll()
        {
            var Result = _dotNetDBcontext.MstControlPrograms.ToList();
            return  Result;
            throw new NotImplementedException();
        }
    }
}