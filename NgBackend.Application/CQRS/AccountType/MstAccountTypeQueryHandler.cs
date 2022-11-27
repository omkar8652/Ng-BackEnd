using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.AccountType
{
    public class MstAccountTypeQueryHandler : IRequestHandler<MstAccountTypeQuery, List<MstAccountType>>
    {
        private readonly IMstAccountType _mstAccountType;

        public MstAccountTypeQueryHandler(IMstAccountType mstAccountType)
        {
            _mstAccountType = mstAccountType;
        }

        public Task<List<MstAccountType>> Handle(MstAccountTypeQuery request, CancellationToken cancellationToken)
        {
            var Result = _mstAccountType.GetAll();
            return Result;
            throw new NotImplementedException();
        }
    }
}