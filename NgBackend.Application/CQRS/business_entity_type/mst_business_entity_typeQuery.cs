using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.business_entity_type
{
    public class mst_business_entity_typeQuery : IRequest<List<MstBusinessEntityType>>
    {
        public mst_business_entity_typeQuery()
        {
            
        }
    }
}