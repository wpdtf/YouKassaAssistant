using System.Data;
using System.Windows.Forms;
using YouKassaAssistant.UI.Domain;

namespace YouKassaAssistant.UI.Infrastructure.Repositories;

public class WorkerRepository(DataBaseContext dbContext)
{
    private readonly IDbConnection connection = new SqlConnection(dbContext.Database.GetConnectionString());

    public async Task<List<WorkerStatistic>> GetListWorkerStatisticAsync()
    {
        var sql = @$"exec dbo.������������������������������";
        var result = await connection.QueryAsync<WorkerStatistic>(sql);
        return result.ToList();
    }

    public async Task<List<Worker>> GetListWorkerAsync()
    {
        var sql = @$"exec dbo.��������������������";
        var result = await connection.QueryAsync<Worker>(sql);
        return result.ToList();
    }

    public async Task<List<Worker>> GetFullListWorkerAsync()
    {
        var sql = @$"exec dbo.������������������������";
        var result = await connection.QueryAsync<Worker>(sql);
        return result.ToList();
    }

    public async Task<List<Tikets>> GetListTiketsAsync(string order)
    {
        var txt = $", @�� = {CurrentUser.Id}";

        var sql = @$"exec dbo.���������������� @������� = N'{order}'{(CurrentUser.Position == "�����" ? "" : txt)}";
        var result = await connection.QueryAsync<Tikets>(sql);
        return result.ToList();
    }

    public void UpdateWorkerTiketsAsync(int tiketsId, int workerId)
    {
        var sql = @"exec dbo.����������������������������������� 
            @����������� = @tiketsId, 
            @�� = @workerId";

        var parameters = new
        {
            tiketsId,
            workerId
        };

        connection.Execute(sql, parameters);
    }

    public async Task<List<ReportResultTikets>> GetListTiketsAsync()
    {
        var sql = @$"exec dbo.�������������������������";
        var result = await connection.QueryAsync<ReportResultTikets>(sql);
        return result.ToList();
    }

    public async Task<List<ReportResultTikets>> GetStatisticsAsync()
    {
        var sql = @$"exec dbo.�������������������������";
        var result = await connection.QueryAsync<ReportResultTikets>(sql);
        return result.ToList();
    }

    public async Task<List<ReportScoreSoft>> GetScoreSoftAsync()
    {
        var sql = @$"exec dbo.��������������������������";
        var result = await connection.QueryAsync<ReportScoreSoft>(sql);
        return result.ToList();
    }

    public async Task<List<ReportScoreSoft>> GetScoreTiketsAsync()
    {
        var sql = @$"exec dbo.�������������������������";
        var result = await connection.QueryAsync<ReportScoreSoft>(sql);
        return result.ToList();
    }

    public async Task UpdateWorkerAsync(Worker worker)
    {
        var sql = @$"exec dbo.�������������������� @��� = N'{worker.FirstName}',
                                    @������� = N'{worker.LastName}',
                                    @�������� = N'{worker.MiddleName}',
                                    @����������������� = N'{worker.Phone}',
                                    @��������� = N'{worker.Position}',
                                    @������������ = N'{worker.WorkerId}'";

        await connection.ExecuteAsync(sql);
    }

    public async Task UpdateUserWorkerAsync(AuthDTO authDTO, int workerId)
    {
        var sql = @$"exec dbo.�������������������������������� @����� = N'{authDTO.Login}',
                                    @������ = N'{authDTO.Password}',
                                    @������������ = {workerId}";

        await connection.ExecuteAsync(sql);
    }

    public async Task CreateWorkerAsync(RegistrationWorker registrationDTO)
    {
        var sql = @$"exec dbo.��������������������� @����� = N'{registrationDTO.Login}', 
                                    @������ = N'{registrationDTO.Password}',
                                    @��� = N'{registrationDTO.FirstName}',
                                    @������� = N'{registrationDTO.LastName}',
                                    @�������� = N'{registrationDTO.MiddleName}',
                                    @��������� = N'{registrationDTO.Position}',
                                    @����������������� = N'{registrationDTO.Phone}'";

        await connection.ExecuteAsync(sql);
    }

    public void UpdatePriceAsync(int tiketsId, decimal price)
    {
        var sql = @"exec dbo.����������������������� 
            @����������� = @tiketsId, 
            @��������� = @price";

        var parameters = new
        {
            tiketsId,
            price
        };

        connection.Execute(sql, parameters);
    }

    public async Task SendMessageAsync(string message, int tiketsId)
    {
        var sql = @"exec dbo.������������������2 
            @����� = @message, 
            @����������� = @tiketsId, 
            @������������ = @workerId";

        var parameters = new
        {
            message,
            tiketsId,
            workerId = CurrentUser.Id
        };

        await connection.ExecuteAsync(sql, parameters);
    }

    public async Task<List<MessageFromTikets>> GetListMessageAsync(int tiketsId)
    {
        var sql = @$"exec dbo.������������������������������������ @����������� = {tiketsId}";
        var result = await connection.QueryAsync<MessageFromTikets>(sql);
        return result.ToList();
    }

    public async Task<MessageFromTikets> GetMessageAsync(int messageId)
    {
        var sql = @$"exec dbo.���������������������������� @����������� = {messageId}";
        var result = await connection.QueryFirstAsync<MessageFromTikets>(sql);
        return result;
    }

    public void UpdateStatusTiketsAsync(int tiketsId, string status)
    {
        var sql = @"exec dbo.�������������������������� 
            @����������� = @tiketsId, 
            @������ = @status";

        var parameters = new
        {
            tiketsId,
            status
        };

        connection.Execute(sql, parameters);
    }

    public Tikets GetTiketsAsync(int tiketsId)
    {
        var sql = @$"exec dbo.������������������ @����������� = {tiketsId}";
        var result = connection.QueryFirst<Tikets>(sql);
        return result;
    }
}