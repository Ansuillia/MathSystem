using MathSystem.Business.Interfaces;
using MathSystem.Business.Operations;
using MathSystem.Repository;

namespace MathSystem.Worker
{
  public class Startup
  {
    public IConfiguration Configuration { get; }
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
      // Poderia criar uma classe pra adicionar as dependêncais
      services.AddSingleton<IDivisionOperationBLL, DivisionOperationBLL>();
      // Adicionei como singleton porque o item estará na memória
      services.AddSingleton<IDivisionRepository, DivisionRepository>();

      services.AddControllers();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseRouting();

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}
