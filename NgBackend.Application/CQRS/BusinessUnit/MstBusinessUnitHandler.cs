using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.BusinessUnit
{
    public class MstBusinessUnitHandler : IRequestHandler<MstBusinessUnitQuery, List<MstBusinessUnit>>
    {
        
        private readonly IMstBusinessUnit _mstBusinessUnit;
        public MstBusinessUnitHandler(IMstBusinessUnit mstBusinessUnit)
        {
            _mstBusinessUnit = mstBusinessUnit;
        }
        public Task<List<MstBusinessUnit>> Handle(MstBusinessUnitQuery request, CancellationToken cancellationToken)
        {
            var Result = _mstBusinessUnit.GetAll();
            return Result;
            throw new NotImplementedException();
        }
    }
}