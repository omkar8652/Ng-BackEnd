using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.ControlProgram
{
    public class MstControlProgramQuery : IRequest<List<MstControlProgram>>
    {
        public MstControlProgramQuery()
        {
        }
    }
}