using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.SalesUserMstAgents
{
    public class MstAgentsQuery : IRequest<List<MstAgents>>
    {
        public MstAgentsQuery()
        {
        }
    }
}