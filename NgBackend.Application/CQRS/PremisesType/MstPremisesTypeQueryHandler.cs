using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.PremisesType
{
    public class MstPremisesTypeQueryHandler : IRequestHandler<MstPremisesTypeQuery, List<MstPremisesType>>
    {
        private readonly IMstPremisesType _mstPremisesType;

        public MstPremisesTypeQueryHandler(IMstPremisesType mstPremisesType)
        {
            _mstPremisesType = mstPremisesType;
        }

        public Task<List<MstPremisesType>> Handle(MstPremisesTypeQuery request, CancellationToken cancellationToken)
        {
            var result = _mstPremisesType.GetAll();
            return result;
            throw new NotImplementedException();
        }
    }
}