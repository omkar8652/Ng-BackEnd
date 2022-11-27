using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.DsaCode
{
    public class MstDsaQueryHandler : IRequestHandler<MstDsaQuery, List<MstDsa>>
    {
        private readonly IMstDsa _mstDsa;
       
        public MstDsaQueryHandler(IMstDsa mstDsa)
        {
            _mstDsa = mstDsa;
        }

        public Task<List<MstDsa>> Handle(MstDsaQuery request, CancellationToken cancellationToken)
        {
            var result = _mstDsa.GetAll();
            return result;
            throw new NotImplementedException();
        }
    }
}