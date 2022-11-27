using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;
using NgBackend.Infrastructure.Data;

namespace NgBackend.Infrastructure.Services.Persistence
{
    public class MstBusinessRegisteredRepo : IMstBusinessRegistered
    {
         private readonly DotNetDBcontext _dotNetDBcontext;

        public MstBusinessRegisteredRepo(DotNetDBcontext dotNetDBcontext)
        {
            _dotNetDBcontext = dotNetDBcontext;
        }

        public async Task<List<MstBusinessRegistered>> GetAll()
        {
            var Result = _dotNetDBcontext.MstBusinessRegistereds.ToList();
            return Result;
            throw new NotImplementedException();
        }
    }
}