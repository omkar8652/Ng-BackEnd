using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.OccupationType
{
    public class MstOccupationTypeQueryHandler : IRequestHandler<MstOccupationTypeQuery, List<MstOccupationType>>
    {
        private readonly IMstOccupationType _mstOccupationType;

        public MstOccupationTypeQueryHandler(IMstOccupationType mstOccupationType)
        {
            _mstOccupationType = mstOccupationType;
        }

        public Task<List<MstOccupationType>> Handle(MstOccupationTypeQuery request, CancellationToken cancellationToken)
        {
            var Result = _mstOccupationType.GetAll();
            return Result;
            throw new NotImplementedException();
        }
    }
}