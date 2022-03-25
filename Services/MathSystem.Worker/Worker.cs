using MathSystem.Operations.Interfaces;

namespace MathSystem.Worker
{
  public class Worker : BackgroundService
  {
    private readonly ILogger<Worker> _logger;
    private readonly IDivisionOperation _division;
    public Worker(ILogger<Worker> logger, IDivisionOperation division)
    {
      _logger = logger;
      _division = division;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
      while (!stoppingToken.IsCancellationRequested)
      {
        _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

        Console.WriteLine(string.Join(",",_division.GetDividers(1000)));

        await Task.Delay(1000, stoppingToken);
      }
    }
  }
}