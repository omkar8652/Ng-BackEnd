using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.MasterAddressProof
{
    public class MstAddressProofQuery : IRequest<List<MstAddressProof>>
    {
        public MstAddressProofQuery()
        {
            
        }
    }
}