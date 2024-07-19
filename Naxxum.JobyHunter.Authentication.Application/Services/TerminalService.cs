using Authentication.Application.Commands.Terminal.Create;
using Authentication.Application.Common.Interfaces;
using Authentication.Application.Queries.Terminal;
using Authentication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Application.Services
{
    public class TerminalService : ITerminalService
    {
        private readonly IUnitOfWork _unitOfWork;
        public TerminalService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void CreateTerminal(CreateTerminalCommand command)
        {
            var handler = new CreateTerminalCommandHandler(_unitOfWork);
            handler.Handle(command);
        }

        public IEnumerable<Terminal> GetTerminals()
        {
            var handler = new GetTerminalsQueryHandler(_unitOfWork);
            return handler.Handle(new GetTerminalsQuery());
        }
    }
}
