using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.SalesUserMstAgents
{
    public class MstAgentsQueryHandler : IRequestHandler<MstAgentsQuery, List<MstAgents>>
    {
        private readonly IMstAgents _mstAgents;

        public MstAgentsQueryHandler(IMstAgents mstAgents)
        {
            _mstAgents = mstAgents;
        }

        public Task<List<MstAgents>> Handle(MstAgentsQuery request, CancellationToken cancellationToken)
        {
            var result = _mstAgents.GetAll();
            return result;
            throw new NotImplementedException();
        }
    }
}