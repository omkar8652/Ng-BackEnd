using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;
using NgBackend.Infrastructure.Data;

namespace NgBackend.Infrastructure.Services.Persistence
{
    public class MstSchemeRepo : IMstScheme
    {
        private readonly DotNetDBcontext _dotNetDBcontext;

        public MstSchemeRepo(DotNetDBcontext dotNetDBcontext)
        {
            _dotNetDBcontext = dotNetDBcontext;
        }

        public async Task<List<MstScheme>> GetAll()
        {
            var result = _dotNetDBcontext.MstSchemes.ToList();
            return result;
            throw new NotImplementedException();
        }
    }
}