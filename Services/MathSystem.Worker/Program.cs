using MathSystem.Operations.Implements;
using MathSystem.Operations.Interfaces;
using MathSystem.Worker;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
      services.AddHostedService<Worker>();
      services.AddScoped<IDivisionOperation, DivisionOperation>();
    })
    .Build();

await host.RunAsync();
