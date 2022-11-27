using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.BusinessRegistered
{
    public class MstBusinessRegisteredQueryHandler : IRequestHandler<MstBusinessRegisteredQuery, List<MstBusinessRegistered>>
    {
        private readonly IMstBusinessRegistered _mstBusinessRegistered;

        public MstBusinessRegisteredQueryHandler(IMstBusinessRegistered mstBusinessRegistered)
        {
            _mstBusinessRegistered = mstBusinessRegistered;
        }

        public Task<List<MstBusinessRegistered>> Handle(MstBusinessRegisteredQuery request, CancellationToken cancellationToken)
        {
            var Result = _mstBusinessRegistered.GetAll();
            return Result;
            throw new NotImplementedException();
        }
    }
}