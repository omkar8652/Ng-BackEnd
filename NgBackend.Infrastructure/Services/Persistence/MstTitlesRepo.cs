using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;
using NgBackend.Infrastructure.Data;

namespace NgBackend.Infrastructure.Services.Persistence
{
    public class MstTitlesRepo : IMstTitlesRepo
    {
         private readonly DotNetDBcontext _dotNetDBcontext;
        public MstTitlesRepo(DotNetDBcontext dotNetDBcontext)
        {
            _dotNetDBcontext = dotNetDBcontext;
        }

        public async Task<List<MstTitles>> GetAll()
        {
            var Result = _dotNetDBcontext.MstTitles.ToList();
            return  Result;
            throw new NotImplementedException();
        }
    }
}