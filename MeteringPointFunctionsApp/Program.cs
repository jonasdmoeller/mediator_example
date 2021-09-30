using MediatR;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SomeLibrary.Data;

namespace MeteringPointFunctionsApp
{
    public class Program
    {
        public static void Main()
        {
            var host = new HostBuilder()
                .ConfigureFunctionsWorkerDefaults()
                .ConfigureServices(services =>
                {
                    services.AddScoped<IDataAccess, DataAccess>();
                    services.AddMediatR(typeof(DataAccess).Assembly);
                })
                .Build();

            host.Run();
        }
    }
}