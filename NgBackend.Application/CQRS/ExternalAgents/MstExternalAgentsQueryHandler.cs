using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.ExternalAgents
{
    public class MstExternalAgentsQueryHandler : IRequestHandler<MstExternalAgentsQuery, List<MstExternalAgents>>
    {
          private  readonly IMstExternalAgents _mstExternalAgents;

        public MstExternalAgentsQueryHandler( IMstExternalAgents mstExternalAgents)
        {
            _mstExternalAgents = mstExternalAgents;
                
        }
        public Task<List<MstExternalAgents>> Handle(MstExternalAgentsQuery request, CancellationToken cancellationToken)
        {
            var Result = _mstExternalAgents.GetAll();
            return Result;
            throw new NotImplementedException();
        }
    }
}