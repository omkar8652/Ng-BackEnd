using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NgBackend.Domain.Entites.DTOs;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.Interfaces.Persistence
{
    public interface ICustomerBankInfo
    {
        public Task<List<CustomerBankInfo>> GetAll();

         public Task<CustomerBankInfo> POST(CustomerBankInfo customerBankInfo);

    
    }
}