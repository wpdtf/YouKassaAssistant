using System.Data;
using System.Windows.Forms;
using YouKassaAssistant.UI.Domain;

namespace YouKassaAssistant.UI.Infrastructure.Repositories;

public class WorkerRepository(DataBaseContext dbContext)
{
    private readonly IDbConnection connection = new SqlConnection(dbContext.Database.GetConnectionString());

    public async Task<List<WorkerStatistic>> GetListWorkerStatisticAsync()
    {
        var sql = @$"exec dbo.ПолучениеСтатистикиСотрудников";
        var result = await connection.QueryAsync<WorkerStatistic>(sql);
        return result.ToList();
    }

    public async Task<List<Worker>> GetListWorkerAsync()
    {
        var sql = @$"exec dbo.ПолучениеСотрудников";
        var result = await connection.QueryAsync<Worker>(sql);
        return result.ToList();
    }

    public async Task<List<Worker>> GetFullListWorkerAsync()
    {
        var sql = @$"exec dbo.ПолучениеВсехСотрудников";
        var result = await connection.QueryAsync<Worker>(sql);
        return result.ToList();
    }

    public async Task<List<Tikets>> GetListTiketsAsync(string order)
    {
        var txt = $", @Ид = {CurrentUser.Id}";

        var sql = @$"exec dbo.ЗаявкиСотрудника @Условие = N'{order}'{(CurrentUser.Position == "админ" ? "" : txt)}";
        var result = await connection.QueryAsync<Tikets>(sql);
        return result.ToList();
    }

    public void UpdateWorkerTiketsAsync(int tiketsId, int workerId)
    {
        var sql = @"exec dbo.ОбновлениеОтветственногоЗаОбращение 
            @ИдОбращения = @tiketsId, 
            @Ид = @workerId";

        var parameters = new
        {
            tiketsId,
            workerId
        };

        connection.Execute(sql, parameters);
    }

    public async Task<List<ReportResultTikets>> GetListTiketsAsync()
    {
        var sql = @$"exec dbo.СтатистикаВыполненыхРабот";
        var result = await connection.QueryAsync<ReportResultTikets>(sql);
        return result.ToList();
    }

    public async Task<List<ReportResultTikets>> GetStatisticsAsync()
    {
        var sql = @$"exec dbo.СтатистикаВыполненыхРабот";
        var result = await connection.QueryAsync<ReportResultTikets>(sql);
        return result.ToList();
    }

    public async Task<List<ReportScoreSoft>> GetScoreSoftAsync()
    {
        var sql = @$"exec dbo.СтатистикаОценкиПриложений";
        var result = await connection.QueryAsync<ReportScoreSoft>(sql);
        return result.ToList();
    }

    public async Task<List<ReportScoreSoft>> GetScoreTiketsAsync()
    {
        var sql = @$"exec dbo.СтатистикаОценкиОбращений";
        var result = await connection.QueryAsync<ReportScoreSoft>(sql);
        return result.ToList();
    }

    public async Task UpdateWorkerAsync(Worker worker)
    {
        var sql = @$"exec dbo.ОбновлениеСотрудника @Имя = N'{worker.FirstName}',
                                    @Фамилия = N'{worker.LastName}',
                                    @Отчество = N'{worker.MiddleName}',
                                    @КонтактныйТелефон = N'{worker.Phone}',
                                    @Должность = N'{worker.Position}',
                                    @ИдСотрудника = N'{worker.WorkerId}'";

        await connection.ExecuteAsync(sql);
    }

    public async Task UpdateUserWorkerAsync(AuthDTO authDTO, int workerId)
    {
        var sql = @$"exec dbo.ОбновленияПользователяСотрудника @Логин = N'{authDTO.Login}',
                                    @Пароль = N'{authDTO.Password}',
                                    @ИдСотрудника = {workerId}";

        await connection.ExecuteAsync(sql);
    }

    public async Task CreateWorkerAsync(RegistrationWorker registrationDTO)
    {
        var sql = @$"exec dbo.РегистрацияСотрудника @Логин = N'{registrationDTO.Login}', 
                                    @Пароль = N'{registrationDTO.Password}',
                                    @Имя = N'{registrationDTO.FirstName}',
                                    @Фамилия = N'{registrationDTO.LastName}',
                                    @Отчество = N'{registrationDTO.MiddleName}',
                                    @Должность = N'{registrationDTO.Position}',
                                    @КонтактныйТелефон = N'{registrationDTO.Phone}'";

        await connection.ExecuteAsync(sql);
    }

    public void UpdatePriceAsync(int tiketsId, decimal price)
    {
        var sql = @"exec dbo.ОбновлениеЦеныОбращения 
            @ИдОбращения = @tiketsId, 
            @стоимость = @price";

        var parameters = new
        {
            tiketsId,
            price
        };

        connection.Execute(sql, parameters);
    }

    public async Task SendMessageAsync(string message, int tiketsId)
    {
        var sql = @"exec dbo.ОтправитьСообщение2 
            @Текст = @message, 
            @ИдОбращения = @tiketsId, 
            @ИдСотрудника = @workerId";

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
        var sql = @$"exec dbo.ПолучениеСообщенийПоЗаявкеСотруднику @ИдОбращения = {tiketsId}";
        var result = await connection.QueryAsync<MessageFromTikets>(sql);
        return result.ToList();
    }

    public async Task<MessageFromTikets> GetMessageAsync(int messageId)
    {
        var sql = @$"exec dbo.ПолучениеСообщенияСотрудника @ИдСообщения = {messageId}";
        var result = await connection.QueryFirstAsync<MessageFromTikets>(sql);
        return result;
    }

    public void UpdateStatusTiketsAsync(int tiketsId, string status)
    {
        var sql = @"exec dbo.ОбновлениеСтатусаОбращения 
            @ИдОбращения = @tiketsId, 
            @Статус = @status";

        var parameters = new
        {
            tiketsId,
            status
        };

        connection.Execute(sql, parameters);
    }

    public Tikets GetTiketsAsync(int tiketsId)
    {
        var sql = @$"exec dbo.ПолучениеОбращения @ИдОбращения = {tiketsId}";
        var result = connection.QueryFirst<Tikets>(sql);
        return result;
    }
}