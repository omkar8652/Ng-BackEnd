using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;
using NgBackend.Infrastructure.Data;

namespace NgBackend.Infrastructure.Services.Persistence
{
    public class MstRegionsRepo : IMstRegions
    {
        private readonly DotNetDBcontext _dotNetDBcontext;

        public MstRegionsRepo(DotNetDBcontext dotNetDBcontext)
        {
            _dotNetDBcontext = dotNetDBcontext;
        }

        public async Task<List<MstRegion>> GetAll()
        {
            var result = _dotNetDBcontext.MstRegions.ToList();
            return result;
            throw new NotImplementedException();
        }
    }
}