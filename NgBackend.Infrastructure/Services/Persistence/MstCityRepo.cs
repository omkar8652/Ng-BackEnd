using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;
using NgBackend.Infrastructure.Data;

namespace NgBackend.Infrastructure.Services.Persistence
{
    public class MstCityRepo : IMstCity
    {
        private readonly DotNetDBcontext _dotNetDBcontext;

        public MstCityRepo(DotNetDBcontext dotNetDBcontext)
        {
            _dotNetDBcontext = dotNetDBcontext;
        }

        public async Task<List<MstCity>> GetAll()
        {
             var Result = _dotNetDBcontext.MstCities.ToList();
            return  Result;
            throw new NotImplementedException();
        }
    }
}