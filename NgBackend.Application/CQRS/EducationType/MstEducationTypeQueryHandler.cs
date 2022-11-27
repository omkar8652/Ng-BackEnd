using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.EducationType
{
    public class MstEducationTypeQueryHandler : IRequestHandler<MstEducationTypeQuery, List<MstEducationType>>
    {
        private readonly IMstEducationType _mstEducationType;

        public MstEducationTypeQueryHandler(IMstEducationType mstEducationType)
        {
            _mstEducationType = mstEducationType;
        }

        public Task<List<MstEducationType>> Handle(MstEducationTypeQuery request, CancellationToken cancellationToken)
        {
            var result = _mstEducationType.GetAll();
            return result;
            throw new NotImplementedException();
        }
    }
}