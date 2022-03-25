using MathSystem.Worker;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureWebHostDefaults(webBuilder =>
    {
      webBuilder.UseStartup<Startup>();
    })
    .ConfigureServices(services =>
    {
      services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();
