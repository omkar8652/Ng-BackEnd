using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.MasterAddressProof
{
    public class MstAddressProofQueryHandler : IRequestHandler<MstAddressProofQuery, List<MstAddressProof>>
    {
        private readonly IMstAddressProof _mstAddressProof;

        public MstAddressProofQueryHandler(IMstAddressProof mstAddressProof)
        {
            _mstAddressProof = mstAddressProof;
        }

        public Task<List<MstAddressProof>> Handle(MstAddressProofQuery request, CancellationToken cancellationToken)
        {
            var Result = _mstAddressProof.GetAll();
            return Result;
            throw new NotImplementedException();
        }
    }
}