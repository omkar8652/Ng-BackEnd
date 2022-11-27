using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.Interfaces.Persistence
{
    public interface IMstInternalAgents
    {
          public Task<List<MstInternalAgents>> GetAll();
    }
}