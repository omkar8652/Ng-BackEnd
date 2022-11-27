using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using Confluent.Kafka;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using NgBackend.Domain.Entites.DTOs;
using NgBackend.Domain.Msgs;

namespace NgBackend.Infrastructure.Kafka
{
    public class KafkaProducer
    {
        private readonly ProducerConfig _producerConfig;
        private readonly Messages _messages;

        public KafkaProducer(IOptionsSnapshot<ProducerConfig> producerConfig, Messages messages)
        {
            _producerConfig = producerConfig.Get("kafkaProducer");
            _messages = messages;
        }

        public async Task<KProducerCommandResp> produceMsg(KProducerCommand request)
        {
            var json = JsonConvert.SerializeObject(request);
            using var producer = new ProducerBuilder
            <Null, string>(_producerConfig).Build();

            var result = await producer.ProduceAsync
            ("process-topic", new Message<Null, string>
            {
                Value = json.ToString()
            });

            if (result.Status == PersistenceStatus.NotPersisted)
            {
                throw new Exception(_messages.kafkaError);
            }
            return new KProducerCommandResp(result.Value, result.Topic, result.Status);
        }
    }
}