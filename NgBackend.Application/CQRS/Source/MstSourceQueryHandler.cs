using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.Source
{
    public class MstSourceQueryHandler : IRequestHandler<MstSourceQuery, List<MstSource>>
    {
       
         private readonly IMstSource _mstSource;
        public MstSourceQueryHandler(IMstSource mstSource)
        {
            _mstSource = mstSource;
        }
        public Task<List<MstSource>> Handle(MstSourceQuery request, CancellationToken cancellationToken)
        {
            var Result = _mstSource.GetAll();
            return Result;
            throw new NotImplementedException();
        }
    }
}