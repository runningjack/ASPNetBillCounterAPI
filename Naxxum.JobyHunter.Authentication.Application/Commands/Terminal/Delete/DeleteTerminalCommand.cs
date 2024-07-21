using Authentication.Application.Common.Interfaces;
using MediatR;

namespace Authentication.Application.Commands.Terminal.Delete
{
    public class DeleteTerminalCommand : IRequest<int>
    {
        public string TerminalId { get; set; }
    }

    public class DeleteTerminalCommandHandler : IRequestHandler<DeleteTerminalCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteTerminalCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Handle(DeleteTerminalCommand request, CancellationToken cancellationToken)
        {
            var terminal = await _unitOfWork.GetRepository<Terminal>().GetByIdAsync(request.TerminalId);
            if (terminal == null)
            {
                return 0;
            }

            _unitOfWork.GetRepository<Terminal>().Remove(terminal);
            await _unitOfWork.SaveAsync();

            return 1;
        }
    }
}
