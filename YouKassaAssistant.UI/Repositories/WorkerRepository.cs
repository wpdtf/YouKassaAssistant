using System.Data;
using YouKassaAssistant.UI.Domain;

namespace YouKassaAssistant.UI.Infrastructure.Repositories;

public class WorkerRepository(DataBaseContext dbContext)
{
    private readonly IDbConnection connection = new SqlConnection(dbContext.Database.GetConnectionString());

}