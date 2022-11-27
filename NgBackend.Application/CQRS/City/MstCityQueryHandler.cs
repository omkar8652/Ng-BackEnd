using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.City
{
    public class MstCityQueryHandler : IRequestHandler<MstCityQuery, List<MstCity>>
    {
        private readonly IMstCity _mstCity;

        public MstCityQueryHandler(IMstCity mstCity)
        {
            _mstCity = mstCity;
        }

        public Task<List<MstCity>> Handle(MstCityQuery request, CancellationToken cancellationToken)
        {
            var result = _mstCity.GetAll();
            return result;
            throw new NotImplementedException();
        }
    }
}