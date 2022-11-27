using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.State
{
    public class MstStateQueryHandler : IRequestHandler<MstStateQuery, List<MstState>>
    {
         private readonly IMstState _mstState;

        public MstStateQueryHandler(IMstState mstState)
        {
            _mstState = mstState;
        }

        public Task<List<MstState>> Handle(MstStateQuery request, CancellationToken cancellationToken)
        {
             var Result = _mstState.GetAll();
            return Result;
            throw new NotImplementedException();
        }
    }
}