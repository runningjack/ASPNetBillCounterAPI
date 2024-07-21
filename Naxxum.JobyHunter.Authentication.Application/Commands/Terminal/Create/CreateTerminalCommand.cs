using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Authentication.Application.Common.Interfaces;
using Authentication.Domain.Entities;

namespace Authentication.Application.Commands.Terminal.Create
{
    public class CreateTerminalCommand : IRequest<int>
    {
        public string TerminalId { get; set; }
        public int BaudRate { get; set; }
        public string Model { get; set; }
    }

    public class CreateTerminalCommandHandler : IRequestHandler<CreateTerminalCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateTerminalCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Handle(CreateTerminalCommand request, CancellationToken cancellationToken)
        {
            var terminal = new Terminal
            {
                TerminalId = request.TerminalId,
                //Location = request.Location,
                BaudRate = request.BaudRate,
                Model = request.Model,
                Model = request.Model
            };

            _unitOfWork.GetRepository<Terminal>().Add(terminal);
            await _unitOfWork.SaveAsync();

            return terminal.Id;
        }

    }

}
