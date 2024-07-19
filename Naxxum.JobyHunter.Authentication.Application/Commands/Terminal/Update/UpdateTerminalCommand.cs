using Authentication.Application.Common.Interfaces;
using MediatR;

namespace Authentication.Application.Commands.Terminal.Update
{
    public class UpdateTerminalCommand : IRequest<int>
    {
        public string TerminalId { get; set; }
        public string Location { get; set; }
        public int BaudRate { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
    }

    public class UpdateTerminalCommandHandler : IRequestHandler<UpdateTerminalCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateTerminalCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Handle(UpdateTerminalCommand request, CancellationToken cancellationToken)
        {
            var terminal = await _unitOfWork.GetRepository<Terminal>().GetByIdAsync(request.TerminalId);
            if (terminal == null)
            {
                return 0;
            }

            terminal.Location = request.Location;
            terminal.BaudRate = request.BaudRate;
            terminal.Manufacturer = request.Manufacturer;
            terminal.Model = request.Model;

            _unitOfWork.GetRepository<Terminal>().Update(terminal);
            await _unitOfWork.SaveAsync();

            return 1;
        }
    }
}
