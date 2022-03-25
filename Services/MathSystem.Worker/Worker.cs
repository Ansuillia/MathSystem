using MathSystem.Repository;

namespace MathSystem.Worker
{
  public class Worker : BackgroundService
  {
    private readonly ILogger<Worker> _logger;
    private readonly IServiceProvider _serviceProvider;
    private readonly IDivisionRepository _divisionRepository;
    public Worker(ILogger<Worker> logger, IServiceProvider serviceProvider, IDivisionRepository divisionRepository)
    {
      _logger = logger;
      _serviceProvider = serviceProvider;
      _divisionRepository = divisionRepository;
    }

    protected override async Task ExecuteAsync(CancellationToken cancellationToken)
    {
      while (!cancellationToken.IsCancellationRequested)
      {
        _logger.LogInformation($"{nameof(Worker)} is running.");

        await DoWorkAsync(cancellationToken);
      }
    }

    private Task DoWorkAsync(CancellationToken cancellationToken)
    {
      _logger.LogInformation($"{nameof(Worker)} is working.");
      while (!cancellationToken.IsCancellationRequested)
      {
        _divisionRepository.MakeDivision();
      }
      return Task.CompletedTask;
    }

    public override async Task StopAsync(CancellationToken cancellationToken)
    {
      _logger.LogInformation(
          $"{nameof(Worker)} is stopping.");

      await base.StopAsync(cancellationToken);
    }
  }
}