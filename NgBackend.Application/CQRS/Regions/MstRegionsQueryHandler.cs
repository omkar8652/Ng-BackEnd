using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.Regions
{
    public class MstRegionsQueryHandler : IRequestHandler<MstRegionsQuery, List<MstRegion>>
    {
        private readonly IMstRegions _mstRegions;

        public MstRegionsQueryHandler(IMstRegions mstRegions)
        {
            _mstRegions = mstRegions;
        }

        public Task<List<MstRegion>> Handle(MstRegionsQuery request, CancellationToken cancellationToken)
        {
            var result = _mstRegions.GetAll();
            return result;
            throw new NotImplementedException();
        }
    }
}