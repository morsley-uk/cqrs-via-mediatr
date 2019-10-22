using CqrsViaMediatR.Domain.Models;
using MediatR;

namespace CqrsViaMediatR.Application.Queries
{
    public class TestQuery : IRequest<Test>
    {
    }
}