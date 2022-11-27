using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.MstBusinessAddress
{
    public class BusinessAddressQuery : IRequest<List<BusinessAddress>>
    {
        public BusinessAddressQuery()
        {
            
        }
    }
}