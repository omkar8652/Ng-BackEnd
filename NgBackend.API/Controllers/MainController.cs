using Microsoft.AspNetCore.Mvc;
using NgBackend.Domain.Msgs;
using MediatR;
using NgBackend.Domain.Entites.DTOs;
using NgBackend.Domain.Entites.Models;
using NgBackend.Infrastructure.Kafka;

using Microsoft.AspNetCore.Authorization;
using NgBackend.Application.Interfaces.ExternalServiceCall;

namespace NgBackend.API.Controllers;

[ApiController]
[Route("[controller]")]
public class MainController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly Messages _message;
    private readonly IMediator _mediatR;
    private readonly KafkaProducer _kafkaProducer;
    private readonly KafkaConsumer _kafkaConsumer;
    private readonly IExternalSerivce _externalSerivce;

    public MainController(ILogger<WeatherForecastController> logger, Messages message, IMediator mediatR, KafkaProducer kafkaProducer, KafkaConsumer kafkaConsumer, IExternalSerivce externalSerivce)
    {
        _logger = logger;
        _message = message;
        _mediatR = mediatR;
        _kafkaProducer = kafkaProducer;
        _kafkaConsumer = kafkaConsumer;
        _externalSerivce = externalSerivce;
    }

    // [HttpGet(Name = "GetWeatherForecast")]
    // public IEnumerable<WeatherForecast> Get()
    // {
    //     return Enumerable.Range(1, 5).Select(index => new WeatherForecast
    //     {
    //         Date = DateTime.Now.AddDays(index),
    //         TemperatureC = Random.Shared.Next(-20, 55),
    //         Summary = Summaries[Random.Shared.Next(Summaries.Length)]
    //     })
    //     .ToArray();
    // }

    [HttpGet("test-api")]
    public String test()
    {
        throw new Exception();
    }

    [HttpPost("user")]
    public async Task<IActionResult> CreateUser(UserCommand userCommand)
    {
        var resp = await _mediatR.Send(userCommand);
        return Ok(resp);
        // throw new Exception();
    }

    [HttpPost("kafka-producer-test")]
    [AllowAnonymous]
    public async Task<IActionResult> kafkaTestProducerAsync(KProducerCommand kProducerCommand)
    {
        // Console.WriteLine(kProducerCommand);
        // var resp=_mediator.Send(kProducerCommand);
        var resp = await _kafkaProducer.produceMsg(kProducerCommand);

        return Ok(resp);

    }


    [HttpPost("kafka-consumer-test")]
    [AllowAnonymous]
    public async Task<IActionResult> kafkaTestConsumerAsync(KProducerCommand kProducerCommand)
    {
        // Console.WriteLine(kProducerCommand);
        // var resp=_mediator.Send(kProducerCommand);
        _kafkaConsumer.consumeMsg();

        return Ok();



    }

    [HttpGet("test-otherMicroServiceCall")]
    [AllowAnonymous]
    public async Task<IActionResult> testGetAsync()
    {
        var resp = await _externalSerivce.otherMicroServiceCall();
        return Ok(resp);

    }

    [HttpPost("test-camunda")]
        [AllowAnonymous]
        public async Task<IActionResult> testAsync(string id, Dictionary<string, object> Dictemplate)
        {
            var resp = await _externalSerivce.StartProcess(id, Dictemplate);
            return Ok(resp);

        }
}
