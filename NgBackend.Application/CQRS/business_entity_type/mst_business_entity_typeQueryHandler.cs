using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.business_entity_type
{
    public class mst_business_entity_typeQueryHandler : IRequestHandler<mst_business_entity_typeQuery, List<MstBusinessEntityType>>
    {
        private readonly  IMstBusinessEntityType _mstBusinessEntityType;

        public mst_business_entity_typeQueryHandler(IMstBusinessEntityType mstBusinessEntityType)
        {
            _mstBusinessEntityType = mstBusinessEntityType;
        }

        public Task<List<MstBusinessEntityType>> Handle(mst_business_entity_typeQuery request, CancellationToken cancellationToken)
        {
            var result = _mstBusinessEntityType.GetAll();
            return result;
            throw new NotImplementedException();
        }
    }
}