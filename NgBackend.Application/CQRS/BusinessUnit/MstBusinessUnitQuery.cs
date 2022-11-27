using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.BusinessUnit
{
    public class MstBusinessUnitQuery : IRequest<List<MstBusinessUnit>>
    {
        public MstBusinessUnitQuery()
        {
            
        }
    }
}