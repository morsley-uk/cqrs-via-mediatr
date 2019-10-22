using System.Threading;
using System.Threading.Tasks;
using CqrsViaMediatR.Application.Command;
using MediatR;

namespace CqrsViaMediatR.Application.Handlers
{
    public class TestCommandHandler : IRequestHandler<TestCommand>
    {
        public Task<Unit> Handle(TestCommand request, CancellationToken cancellationToken)
        {
            // Do some interesting stuff here...

            return Task.FromResult(Unit.Value);
        }
    }
}