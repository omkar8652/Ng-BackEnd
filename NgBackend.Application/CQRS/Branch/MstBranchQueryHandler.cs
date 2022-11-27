using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.Branch
{
    public class MstBranchQueryHandler : IRequestHandler<MstBranchQuery, List<MstBranch>>
    {

        private readonly IMstBranch _mstBranch;

        public MstBranchQueryHandler(IMstBranch mstBranch)
        {
            _mstBranch = mstBranch;
        }

        public Task<List<MstBranch>> Handle(MstBranchQuery request, CancellationToken cancellationToken)
        {
            var result = _mstBranch.GetAll();
            return result;
            throw new NotImplementedException();
        }
    }
}