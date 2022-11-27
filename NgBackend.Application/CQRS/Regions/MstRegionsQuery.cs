using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.Regions
{
    public class MstRegionsQuery : IRequest<List<MstRegion>>
    {
        public MstRegionsQuery()
        {
        }
    }
}