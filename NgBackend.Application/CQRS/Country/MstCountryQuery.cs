using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.CQRS.Country
{
    public class MstCountryQuery : IRequest<List<MstCountry>>
    {
        public MstCountryQuery()
        {
        }
    }
}