using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;
using NgBackend.Infrastructure.Data;

namespace NgBackend.Infrastructure.Services.Persistence
{
    public class MstPremisesTypeRepo : IMstPremisesType
    {
          private readonly DotNetDBcontext _dotNetDBcontext;

        public MstPremisesTypeRepo(DotNetDBcontext dotNetDBcontext)
        {
            _dotNetDBcontext = dotNetDBcontext;
        }

        public async Task<List<MstPremisesType>> GetAll()
        {
            var Result = _dotNetDBcontext.MstPremisesTypes.ToList();
            return Result;
            throw new NotImplementedException();
        }
    }
}