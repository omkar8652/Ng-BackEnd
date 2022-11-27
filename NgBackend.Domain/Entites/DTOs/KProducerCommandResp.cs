// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

using Confluent.Kafka;
using MediatR;

namespace NgBackend.Domain.Entites.DTOs;

public record KProducerCommandResp(
    string msg,
    string topic,
    PersistenceStatus status
);


