using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;
using NgBackend.Infrastructure.Data;

namespace NgBackend.Infrastructure.Services.Persistence
{
    public class MstUserRepo : IMstUser
    {
        private readonly DotNetDBcontext _dotNetDBcontext;

        public MstUserRepo(DotNetDBcontext dotNetDBcontext)
        {
            _dotNetDBcontext = dotNetDBcontext;
        }

        public async Task<List<MstUser>> GetAll()
        {
            var result = _dotNetDBcontext.MstUsers.ToList();
            return result;
            throw new NotImplementedException();
        }
    }
}