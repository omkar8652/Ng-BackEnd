using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.Scheme
{
    public class MstSchemeQueryHandler : IRequestHandler<MstSchemeQuery, List<MstScheme>>
    {
        private readonly  IMstScheme _mstScheme;

        public MstSchemeQueryHandler(IMstScheme mstScheme)
        {
            _mstScheme = mstScheme;
        }

        public Task<List<MstScheme>> Handle(MstSchemeQuery request, CancellationToken cancellationToken)
        {
            var Result = _mstScheme.GetAll();
            return Result;
            throw new NotImplementedException();
        }

       
    }
}