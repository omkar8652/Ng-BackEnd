using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Confluent.Kafka;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace NgBackend.Infrastructure.Kafka
{
    public class KafkaConsumer
    {
        private readonly ConsumerConfig _producerConfig;

        private readonly ConfigurationBuilder _configurationBuilder;

        public KafkaConsumer(IOptionsSnapshot<ConsumerConfig> producerConfig,ConfigurationBuilder configurationBuilder)
        {
            _producerConfig = producerConfig.Get("kafkaConsumer");
            _configurationBuilder=configurationBuilder;
        }

        public void consumeMsg()
        {
            _producerConfig.GroupId = "kafka-consumer";
            _producerConfig.BootstrapServers = "localhost:9092";

            // Console.WriteLine("Inside Consumer1");
            using var consumer = new ConsumerBuilder<Null, string>(_producerConfig).Build();
            // Console.WriteLine("Inside Consumer2");
            consumer.Subscribe("process-topic");
            // Console.WriteLine("Inside Consumer3");
            while (true)
            {
                var result = consumer.Consume();
                if (result?.Message == null) { continue; }
                // Console.WriteLine("Inside Consumer");
                var json = JsonConvert.SerializeObject(result.Message);
                Console.WriteLine("===>>> " + json);
                // Console.WriteLine("Inside Consumer");
                // return "";
            }
        }

    }
}