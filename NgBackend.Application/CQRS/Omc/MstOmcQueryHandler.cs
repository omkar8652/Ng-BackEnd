using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.Omc
{
    public class MstOmcQueryHandler : IRequestHandler<MstOmcQuery, List<MstOmc>>
    {
        private readonly IMstOmc _mstOmc;

        public MstOmcQueryHandler(IMstOmc mstOmc)
        {
            _mstOmc = mstOmc;
        }
       
        public Task<List<MstOmc>> Handle(MstOmcQuery request, CancellationToken cancellationToken)
        {
            var result = _mstOmc.GetAll();
            return result;
            throw new NotImplementedException();
        }
    }
}