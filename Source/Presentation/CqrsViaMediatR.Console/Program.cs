using System.Reflection;
using System.Threading.Tasks;
using CqrsViaMediatR.Application.Command;
using CqrsViaMediatR.Application.IoC;
using CqrsViaMediatR.Application.Queries;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CqrsViaMediatR.Console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Set up DI in our console app...
            var executingAssembly = Assembly.GetExecutingAssembly();
            var serviceProvider = new ServiceCollection().AddMediatR(executingAssembly)
                                                         .AddApplication()
                                                         .BuildServiceProvider();

            // Get a handle on out MediatR instance via DI...
            var mediatr = serviceProvider.GetService<IMediator>();

            // Set up our 1st request in the form of a query...
            var query = new TestQuery
            {
                // Query related data goes here...
            };

            // Get MediatR to call the corresponding handler to service the query...
            var result = await mediatr.Send(query);

            // Set up our 2nd request in the form of a command...
            var command = new TestCommand
            {
                // Command related data goes here...
            };

            // Get MediatR to call the corresponding handler to service the command...
            await mediatr.Send(command);

            System.Console.WriteLine("MediatR!");
        }
    }
}
