using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.Country
{
    public class MstCountryQueryHandler : IRequestHandler<MstCountryQuery, List<MstCountry>>
    {
        private readonly IMstCountry _mstCountry;

        public MstCountryQueryHandler(IMstCountry mstCountry)
        {
            _mstCountry = mstCountry;
        }

        public Task<List<MstCountry>> Handle(MstCountryQuery request, CancellationToken cancellationToken)
        {
            var result = _mstCountry.GetAll();
            return result;
            throw new NotImplementedException();
        }
    }
}