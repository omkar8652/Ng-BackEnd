using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.InternalAgents
{
    public class MstInternalAgentsHandler  : IRequestHandler<MstInternalAgentsQuery, List<MstInternalAgents>>
    {
        // IMstInternalAgents

          private readonly IMstInternalAgents _IMstInternalAgents;
        public MstInternalAgentsHandler(IMstInternalAgents mstInternalAgents)
        {
            _IMstInternalAgents = mstInternalAgents;
        }

        public Task<List<MstInternalAgents>> Handle(MstInternalAgentsQuery request, CancellationToken cancellationToken)
        {
            var Result = _IMstInternalAgents.GetAll();
            return Result;
            throw new NotImplementedException();
        }
    }
}