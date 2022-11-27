using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.Scheme
{
    public class MstSchemeQuery : IRequest<List<MstScheme>>
    {
        public MstSchemeQuery()
        {
        }
    }
}