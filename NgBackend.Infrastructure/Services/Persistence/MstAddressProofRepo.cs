using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;
using NgBackend.Infrastructure.Data;

namespace NgBackend.Infrastructure.Services.Persistence
{
    public class MstAddressProofRepo : IMstAddressProof
    {
          private readonly DotNetDBcontext _dotNetDBcontext;

        public MstAddressProofRepo(DotNetDBcontext dotNetDBcontext)
        {
            _dotNetDBcontext = dotNetDBcontext;
        }

        public async Task<List<MstAddressProof>> GetAll()
        {
            var Result = _dotNetDBcontext.MstAddressProofs.ToList();
            return Result;
            throw new NotImplementedException();
        }
    }
}