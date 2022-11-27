using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.BankInfo
{
    public class CustomerBankInfoQueryHandler : IRequestHandler<CustomerBankInfoQuery, List<CustomerBankInfo>>
    {
        private readonly ICustomerBankInfo _customerBankInfo;
      

        public CustomerBankInfoQueryHandler(ICustomerBankInfo customerBankInfo)
        {
            _customerBankInfo = customerBankInfo;
        }

        public Task<List<CustomerBankInfo>> Handle(CustomerBankInfoQuery request, CancellationToken cancellationToken)
        {
            var Result = _customerBankInfo.GetAll();
            return Result;
            throw new NotImplementedException();
        }
    }
}