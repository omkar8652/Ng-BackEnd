using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.DsaCode
{
    public class MstDsaQuery : IRequest<List<MstDsa>>
    {
        
        public MstDsaQuery()
        {
        }

      
    }
}