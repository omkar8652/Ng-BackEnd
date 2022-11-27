using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.MasterTitles
{
    public class MstTitlesQueryHandler : IRequestHandler<MstTitlesQuery, List<MstTitles>>
    {
         private readonly IMstTitlesRepo _mstTitlesRepo;
        public MstTitlesQueryHandler(IMstTitlesRepo mstTitlesRepo)
        {
            _mstTitlesRepo = mstTitlesRepo;
        }
        public Task<List<MstTitles>> Handle(MstTitlesQuery request, CancellationToken cancellationToken)
        {
            var Result = _mstTitlesRepo.GetAll();
            return Result;
            throw new NotImplementedException();
        }
    }
}