using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Domain.Entites.DTOs;

public record UserCommand(
    string FirstName,
    string LastName,
    string Email,
    string Password
) : IRequest<User>;

