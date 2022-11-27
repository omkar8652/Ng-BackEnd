using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.Mst_UtilityMaster
{
    public class UtilityMasterQueryHandler : IRequestHandler<UtilityMasterQuery, List<UtilityMaster>>
    {
        private readonly IUtilityMaster _utilityMaster;

        public UtilityMasterQueryHandler(IUtilityMaster utilityMaster)
        {
            _utilityMaster = utilityMaster;
        }

        public Task<List<UtilityMaster>> Handle(UtilityMasterQuery request, CancellationToken cancellationToken)
        {
            var Result = _utilityMaster.GetAll();
            return Result;
            throw new NotImplementedException();
        }
    }
}