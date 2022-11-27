using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.Industry
{
    public class MstIndustryQueryHandler : IRequestHandler<MstIndustryQuery, List<MstIndustry>>
    {
        private readonly IMstIndustry _mstIndustry;

        public MstIndustryQueryHandler(IMstIndustry mstIndustry)
        {
            _mstIndustry = mstIndustry;
        }

        public Task<List<MstIndustry>> Handle(MstIndustryQuery request, CancellationToken cancellationToken)
        {
            var Result = _mstIndustry.GetAll();
            return Result;
            throw new NotImplementedException();
        }
    }
}