using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.MaritalStatus
{
    public class MstMarStatusQueryHandler : IRequestHandler<MstMarStatusQuery, List<MstMarStatus>>
    {
       private readonly IMstMarStatus _mstMarStatus;

        public MstMarStatusQueryHandler(IMstMarStatus mstMarStatus)
        {
            _mstMarStatus = mstMarStatus;
        }

        public Task<List<MstMarStatus>> Handle(MstMarStatusQuery request, CancellationToken cancellationToken)
        {
            var Result = _mstMarStatus.GetAll();
            return Result;
            throw new NotImplementedException();
        }
    }
}