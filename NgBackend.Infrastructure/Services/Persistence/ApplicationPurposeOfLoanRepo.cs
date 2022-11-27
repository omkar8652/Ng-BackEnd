using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;
using NgBackend.Infrastructure.Data;

namespace NgBackend.Infrastructure.Services.Persistence
{
    public class ApplicationPurposeOfLoanRepo : IApplicationPurposeOfLoan
    {
         private readonly DotNetDBcontext _dotNetDBcontext;

        public ApplicationPurposeOfLoanRepo(DotNetDBcontext dotNetDBcontext)
        {
            _dotNetDBcontext = dotNetDBcontext;
        }

        public async Task<List<ApplicationPurposeOfLoan>> GetAll()
        {
            var Result = _dotNetDBcontext.ApplicationPurposeOfLoans.ToList();
            return Result;
            throw new NotImplementedException();
        }
    }
}