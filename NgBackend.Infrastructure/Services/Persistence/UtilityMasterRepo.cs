using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;
using NgBackend.Infrastructure.Data;

namespace NgBackend.Infrastructure.Services.Persistence
{
    public class UtilityMasterRepo : IUtilityMaster
    {
        private readonly DotNetDBcontext _dotNetDBcontext;

        public UtilityMasterRepo(DotNetDBcontext dotNetDBcontext)
        {
            _dotNetDBcontext = dotNetDBcontext;
        }

        public async Task<List<UtilityMaster>> GetAll()
        {
            var result = _dotNetDBcontext.UtilityMasters.ToList();
            return result;
            throw new NotImplementedException();
        }
    }
}