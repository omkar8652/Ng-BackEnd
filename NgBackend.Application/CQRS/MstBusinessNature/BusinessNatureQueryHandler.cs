using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.MstBusinessNature
{
    public class BusinessNatureQueryHandler : IRequestHandler<BusinessNatureQuery, List<BusinessNature>>
    {
        private readonly IBusinessNature _businessNature;

        public BusinessNatureQueryHandler(IBusinessNature businessNature)
        {
            _businessNature = businessNature;
        }

        public Task<List<BusinessNature>> Handle(BusinessNatureQuery request, CancellationToken cancellationToken)
        {
            var Result = _businessNature.GetAll();
            return Result;
            throw new NotImplementedException();
        }
    }
}