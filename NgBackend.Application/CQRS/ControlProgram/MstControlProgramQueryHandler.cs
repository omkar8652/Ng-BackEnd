using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.ControlProgram
{
    public class MstControlProgramQueryHandler : IRequestHandler<MstControlProgramQuery, List<MstControlProgram>>
    {
        private readonly IMstControlProgram _mstControlProgram;

        public MstControlProgramQueryHandler(IMstControlProgram mstControlProgram)
        {
            _mstControlProgram = mstControlProgram;
        }

        public Task<List<MstControlProgram>> Handle(MstControlProgramQuery request, CancellationToken cancellationToken)
        {
            var result =  _mstControlProgram.GetAll();
            return result;
            throw new NotImplementedException();
        }
    }
}