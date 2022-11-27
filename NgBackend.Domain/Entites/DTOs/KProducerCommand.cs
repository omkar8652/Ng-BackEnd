// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

using MediatR;

namespace NgBackend.Domain.Entites.DTOs;

public record KProducerCommand(
    string input
) : IRequest<KProducerCommandResp>;


