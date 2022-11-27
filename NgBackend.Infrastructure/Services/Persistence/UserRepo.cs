using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// using BuberDinner.infrastructure.Data;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Entites.Models;
using NgBackend.Infrastructure.Data;

namespace NgBackend.Infrastructure.Services.Persistence
{
    public class UserRepo : IUserRepo
    {
        private static readonly List<User> _users = new List<User>();
        private readonly DotNetDBcontext _dotNetDBcontext;

        public UserRepo(DotNetDBcontext dotNetDBcontext)
        {
            _dotNetDBcontext = dotNetDBcontext;
        }

        public User Add(User user)
        {
            Console.WriteLine("ADDING USER==>>" + user);
            // Console.WriteLine(_users.Capacity);
            // _users.Add(user);
            // Console.WriteLine(_users);
            // _dotNetDBcontext.user.Add(user);
            // _dotNetDBcontext.SaveChanges();
            // throw new NotImplementedException();
            return user;
        }

        public List<User> GetUserByEmail(string email)
        {
            var resp = new List<User>();
    // (from roles in _dotNetDBcontext.user
    //                     where roles.Email == email
    //                     select roles).ToList();
            return resp;
            // throw new NotImplementedException();?
        }

        public void MakeTestCall()
        {
            throw new NotImplementedException();
        }
    }
}