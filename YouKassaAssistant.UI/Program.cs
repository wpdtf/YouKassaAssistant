global using Dapper;
global using Microsoft.Data.SqlClient;
global using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using YouKassaAssistant.UI.FormDialog;
using YouKassaAssistant.UI.Infrastructure.Repositories;

namespace YouKassaAssistant.UI;

internal static class Program
{
    private static IServiceProvider? _serviceProvider;

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        var services = new ServiceCollection();
        services.AddSingleton<CreateConnectionToBack>();
        services.AddDbContext<DataBaseContext>(x =>
         x.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=“вой ассовыйјссистент;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=True;"));

        services.AddSingleton<ClientRepository>();
        services.AddSingleton<WorkerRepository>();

        _serviceProvider = services.BuildServiceProvider();

        ApplicationConfiguration.Initialize();

        var clientRepository = _serviceProvider.GetRequiredService<ClientRepository>();
        var workerRepository = _serviceProvider.GetRequiredService<WorkerRepository>();
        var sendToBack = _serviceProvider.GetRequiredService<CreateConnectionToBack>();

        Application.Run(new DialogAuth(sendToBack, clientRepository, workerRepository));
    }
}
