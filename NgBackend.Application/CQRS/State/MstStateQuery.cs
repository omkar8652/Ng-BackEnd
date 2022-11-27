using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.State
{
    public class MstStateQuery : IRequest<List<MstState>>
    {
        public MstStateQuery()
        {
        }
    }
}