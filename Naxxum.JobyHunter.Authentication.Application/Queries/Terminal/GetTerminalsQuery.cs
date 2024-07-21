using Authentication.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Authentication.Domain.Entities;
using MediatR;
using Authentication.Application.DTOs;

namespace Authentication.Application.Queries.Terminal
{
    public class GetTerminalsQuery : IRequest<List<TerminalResponseDTO>>
    {
    }

    public class GetTerminalsQueryHandler : IRequestHandler<GetTerminalsQuery, List<TerminalResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetTerminalsQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<TerminalResponseDTO>> Handle(GetTerminalsQuery request, CancellationToken cancellationToken)
        {
            var terminals = await _unitOfWork.GetRepository<Terminal>().GetAllAsync();
            return terminals.Select(t => new TerminalResponseDTO
            {
                TerminalId = t.TerminalId,
                Location = t.Location,
                BaudRate = t.BaudRate,
                Manufacturer = t.Manufacturer,
                Model = t.Model
            }).ToList();
        }
    }

}
