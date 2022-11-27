// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using MediatR;
// using NgBackend.Application.Interfaces.Persistence;
// using NgBackend.Domain.Entites.DTOs;
// using NgBackend.Domain.Entites.Models;
// using NgBackend.Domain.Msgs;

// namespace NgBackend.Application.CQRS.UserHandler
// {
//     public class UserCommandHandler : IRequestHandler<UserCommand, User>
//     {
//         private readonly IUserRepo _userRepo;
//         private readonly Messages _messages;

//         public UserCommandHandler(IUserRepo userRepo, Messages messages)
//         {
//             _userRepo = userRepo;
//             _messages = messages;
//         }

//         public async Task<User> Handle(UserCommand request, CancellationToken cancellationToken)
//         {

//             var user = new User(request.FirstName, request.LastName, request.Email, request.Password);
//             var resp = _userRepo.Add(user);
//             return resp;
//             // throw new NotImplementedException();
//         }
//     }
// }