using Authentication.Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerminalManagement.Application.DTOs;

namespace Authentication.Application.Queries.Terminal
{
    public class GetTerminalDetailsQuery : IRequest<TerminalDetailsResponseDTO>
    {
        public string TerminalId { get; set; }
    }

    public class GetTerminalDetailsQueryHandler : IRequestHandler<GetTerminalDetailsQuery, TerminalDetailsResponseDTO>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetTerminalDetailsQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<TerminalDetailsResponseDTO> Handle(GetTerminalDetailsQuery request, CancellationToken cancellationToken)
        {
            var terminal = await _unitOfWork.GetRepository<Terminal>().GetByIdAsync(request.TerminalId);
            if (terminal == null)
            {
                return null;
            }

            return new TerminalDetailsResponseDTO
            {
                TerminalId = terminal.TerminalId,
                Location = terminal.Location,
                BaudRate = terminal.BaudRate,
                Manufacturer = terminal.Manufacturer,
                Model = terminal.Model
            };
        }
    }
}
