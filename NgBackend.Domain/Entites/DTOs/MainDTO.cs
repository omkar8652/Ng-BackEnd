using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace NgBackend.Domain.Entites.DTOs
{
    public class MainDTO : IRequest<ApplicationDTOResp>
    {
          public CustBankInfoDTO custBankInfoDTO {get; set;}
          public ApplicationDTO applicationDTO {get; set;}
    }
}