using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.PurposeOfLoan
{
    public class ApplicationPurposeOfLoanQueryHandler : IRequestHandler<ApplicationPurposeOfLoanQuery, List<ApplicationPurposeOfLoan>>
    {
        private readonly IApplicationPurposeOfLoan _applicationPurposeOfLoan;

        public ApplicationPurposeOfLoanQueryHandler(IApplicationPurposeOfLoan applicationPurposeOfLoan)
        {
            _applicationPurposeOfLoan = applicationPurposeOfLoan;
        }

        public Task<List<ApplicationPurposeOfLoan>> Handle(ApplicationPurposeOfLoanQuery request, CancellationToken cancellationToken)
        {   
            var Result = _applicationPurposeOfLoan.GetAll();
            return Result;
            throw new NotImplementedException();
        }
    }
}