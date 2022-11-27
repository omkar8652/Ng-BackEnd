using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Application.Interfaces.Persistence
{
    public interface IUserRepo
    {
        List<User> GetUserByEmail(string email);

        User Add(User user);

        void MakeTestCall();
    }
}