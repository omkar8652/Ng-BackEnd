using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NgBackend.Domain.Entites.Models
{
    public class User
    {
        public User(int id, string? firstName, string? lastName, string? email, string? password, Dictionary<string, object>? map)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            this.map = map;
        }

        public User(int id, string? firstName, string? lastName, string? email, string? password)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
          
        }

         public User( string? firstName, string? lastName, string? email, string? password)
        {
            
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
          
        }

        public User()
        {
        }

        [Key]
        public int Id{get; set;}
        public string? FirstName {get; set;}

        public string? LastName {get; set;}
        public string? Email {get; set;}
        public string? Password {get; set;}

        public Dictionary<string,object>? map { get; set; }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return "User :: "+Email+" "+FirstName+" "+LastName+" "+Password;
        }
    }
}