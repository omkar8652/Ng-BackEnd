using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Application.CQRS.User;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.MasterUser
{
    public class MstUserQueryHandler : IRequestHandler<MstUserQuery, List<MstUser>>
    {
        private readonly IMstUser _mstUser;

        public MstUserQueryHandler(IMstUser mstUser)
        {
            _mstUser = mstUser;
        }

        public Task<List<MstUser>> Handle(MstUserQuery request, CancellationToken cancellationToken)
        {
            var result = _mstUser.GetAll();
            return result;
            throw new NotImplementedException();
        }
    }
}