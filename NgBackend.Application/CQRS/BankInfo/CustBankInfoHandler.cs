using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mapster;
using MediatR;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.DTOs;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.BankInfo
{
    public class CustBankInfoHandler : IRequestHandler<MainDTO, ApplicationDTOResp>
    {
        private readonly ICustomerBankInfo _customerBankInfo;

        public CustBankInfoHandler(ICustomerBankInfo customerBankInfo)
        {
            _customerBankInfo = customerBankInfo;
        }

        public async Task<ApplicationDTOResp> Handle(MainDTO request, CancellationToken cancellationToken)
        {
            var applicationDTO = request.applicationDTO.Adapt<Applications>();
            var custBankInfoDTO = request.custBankInfoDTO.Adapt<CustomerBankInfo>();
            var custBankInfoDTOResp = await _customerBankInfo.POST(custBankInfoDTO);
            applicationDTO.CustomerBankInfoId = int.Parse(custBankInfoDTOResp.CustomerBankInfoId.ToString());
            applicationDTO.LeadId = Guid.NewGuid().ToString();

            // var test = request.custBankInfoDTO.BankName;
            
            return new ApplicationDTOResp();
            throw new NotImplementedException();
        }
    }
}