using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.DTOs;
using NgBackend.Domain.Entites.Models;
using NgBackend.Infrastructure.Data;

namespace NgBackend.Infrastructure.Services.Persistence
{
    public class CustomerBankInfoRepo : ICustomerBankInfo
    {
         private readonly DotNetDBcontext _dotNetDBcontext;

        public CustomerBankInfoRepo(DotNetDBcontext dotNetDBcontext)
        {
            _dotNetDBcontext = dotNetDBcontext;
        }

       

        public async Task<List<CustomerBankInfo>> GetAll()
        {
            var Result = _dotNetDBcontext.CustomerBankInfos.ToList();
            return Result; 
            throw new NotImplementedException();
        }

         public async Task<CustomerBankInfo> POST(CustomerBankInfo customerBankInfo)
        {
             var resp =  _dotNetDBcontext.CustomerBankInfos.Add(customerBankInfo);
              await _dotNetDBcontext.SaveChangesAsync();
               return customerBankInfo;
            throw new NotImplementedException();
        }

    }
}