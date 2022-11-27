using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;
using NgBackend.Infrastructure.Data;

namespace NgBackend.Infrastructure.Services.Persistence
{
    public class MstBusinessUnitRepo : IMstBusinessUnit
    {
        private readonly DotNetDBcontext _dotNetDBcontext;
        public MstBusinessUnitRepo(DotNetDBcontext dotNetDBcontext)
        {
            _dotNetDBcontext = dotNetDBcontext;
        }
        public async Task<List<MstBusinessUnit>> GetAll() 
        {
             var Result = _dotNetDBcontext.MstBusinessUnits.ToList();
            return  Result;
            throw new NotImplementedException();
        }
    }
}