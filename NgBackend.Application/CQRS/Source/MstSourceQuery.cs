using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.Source
{
    public class MstSourceQuery : IRequest<List<MstSource>>
    {
        public MstSourceQuery()
        {
        }
    }
}