using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.MstBusinessAddress
{
    public class BusinessAddressQueryHandler : IRequestHandler<BusinessAddressQuery, List<BusinessAddress>>
    {
        private readonly IBusinessAddress _businessAddress;

        public BusinessAddressQueryHandler(IBusinessAddress businessAddress)
        {
            _businessAddress = businessAddress;
        }

        public Task<List<BusinessAddress>> Handle(BusinessAddressQuery request, CancellationToken cancellationToken)
        {
            var Result = _businessAddress.GetAll();
            return Result;
            throw new NotImplementedException();
        }
    }
}