using Authentication.Application.Commands.Terminal.Create;
using Authentication.Application.Commands.Terminal.Delete;
using Authentication.Application.DTOs;
using Authentication.Application.Queries.Terminal;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Authentication.Application.Commands.Terminal.Create;
using Authentication.Application.Commands.Terminal.Delete;
using Authentication.Application.Commands.Terminal.Update;
using Authentication.Application.DTOs;
using Authentication.Application.Queries.Terminal;

namespace Authentication.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerminalController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TerminalController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("Create")]
        [ProducesDefaultResponseType(typeof(int))]
        public async Task<ActionResult> CreateTerminal(CreateTerminalCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpGet("GetAll")]
        [ProducesDefaultResponseType(typeof(List<TerminalResponseDTO>))]
        public async Task<IActionResult> GetAllTerminalsAsync()
        {
            return Ok(await _mediator.Send(new GetTerminalsQuery()));
        }

        [HttpDelete("Delete/{terminalId}")]
        [ProducesDefaultResponseType(typeof(int))]
        public async Task<IActionResult> DeleteTerminal(string terminalId)
        {
            var result = await _mediator.Send(new DeleteTerminalCommand() { TerminalId = terminalId });
            return Ok(result);
        }

        [HttpGet("GetTerminalDetails/{terminalId}")]
        [ProducesDefaultResponseType(typeof(TerminalDetailsResponseDTO))]
        public async Task<IActionResult> GetTerminalDetails(string terminalId)
        {
            var result = await _mediator.Send(new GetTerminalDetailsQuery() { TerminalId = terminalId });
            return Ok(result);
        }

        [HttpPut("Update")]
        [ProducesDefaultResponseType(typeof(int))]
        public async Task<ActionResult> UpdateTerminal(UpdateTerminalCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
