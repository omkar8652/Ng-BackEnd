using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NgBackend.Application.CQRS.MasterTitles;
using NgBackend.Domain.Entites.DTOs;
using NgBackend.Infrastructure.Data;

namespace NgBackend.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MstTitlesController : ControllerBase
    {
        private readonly IMediator _mediator;

        private readonly DotNetDBcontext _dotnetDbContext;
        public MstTitlesController(IMediator mediator, DotNetDBcontext dotnetDbContext)
        {
            _mediator = mediator;
            _dotnetDbContext = dotnetDbContext;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            Console.WriteLine("!st");
            var command = new MstTitlesQuery();
            Console.WriteLine("2st");
            var result = await _mediator.Send(command);
            Console.WriteLine("3st");
            Console.WriteLine(result);
            return Ok(result);
        }


        [HttpPost("applications")]

        public async Task<ApplicationDTOResp> CreateApplications(MainDTO mainDTO)
        {
            // Console.WriteLine(kProducerCommand);
            // var resp=_mediator.Send(kProducerCommand);
            // _kafkaConsumer.consumeMsg();

            var resp = await _mediator.Send(mainDTO);
            return resp;

        }
    }

}