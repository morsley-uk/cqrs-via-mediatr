using System.Threading;
using System.Threading.Tasks;
using CqrsViaMediatR.Application.Queries;
using CqrsViaMediatR.Domain.Models;
using MediatR;

namespace CqrsViaMediatR.Application.Handlers
{
    public class TestQueryHandler : IRequestHandler<TestQuery, Test>
    {
        public Task<Test> Handle(TestQuery request, CancellationToken cancellationToken)
        {
            // Do some interesting stuff here to get your Test object...
            var test = new Test();

            return Task.FromResult<Test>(test);
        }
    }
}