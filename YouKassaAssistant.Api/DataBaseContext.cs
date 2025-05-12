namespace YouKassaAssistant.Api;

public class DataBaseContext : DbContext
{
    public DataBaseContext(DbContextOptions<DataBaseContext> configure) : base(configure)
    {
    }
}
