using System.Data;
using YouKassaAssistant.UI.Domain;

namespace YouKassaAssistant.UI.Infrastructure.Repositories;

public class ClientRepository(DataBaseContext dbContext)
{
    private readonly IDbConnection connection = new SqlConnection(dbContext.Database.GetConnectionString());

    public async Task<List<Tikets>> GetListTiketsAsync(string order)
    {
        var sql = @$"exec dbo.ЗаявкиКлиента @Ид = {CurrentUser.Id}, @Условие = N'{order}'";
        var result = await connection.QueryAsync<Tikets>(sql);
        return result.ToList();
    }

    public async Task CreateTikets(Tikets tikets)
    {
        var sql = @"exec dbo.СозданияОбращения 
            @Тема = @Theme, 
            @Описание = @Description, 
            @Изображение = @ImageBytes,
            @Срочное = @IsFire,
            @ИдКлиента = @ClientId";

        var parameters = new DynamicParameters();
        parameters.Add("@Theme", tikets.Theme);
        parameters.Add("@Description", tikets.Description);
        parameters.Add("@ImageBytes", tikets.ImageBytes, DbType.Binary);
        parameters.Add("@IsFire", tikets.IsFire);
        parameters.Add("@ClientId", CurrentUser.Id);

        await connection.ExecuteAsync(sql, parameters);
    }

    public async Task<List<MessageFromTikets>> GetListMessageAsync(int tiketsId)
    {
        var sql = @$"exec dbo.ПолучениеСообщенийПоЗаявкеКлиенту @ИдОбращения = {tiketsId}";
        var result = await connection.QueryAsync<MessageFromTikets>(sql);
        return result.ToList();
    }

    public async Task CreateMessageAsync(int tiketsId, string message)
    {
        var sql = @"exec dbo.ОтправитьСообщение 
            @Текст = @message, 
            @ИдОбращения = @tiketsId";

        var parameters = new
        {
            message,
            tiketsId
        };

        await connection.ExecuteAsync(sql, parameters);
    }

    public async Task<MessageFromTikets> GetMessageAsync(int messageId)
    {
        var sql = @$"exec dbo.ПолучениеСообщенияКлиенту @ИдСообщения = {messageId}";
        var result = await connection.QueryFirstAsync<MessageFromTikets>(sql);
        return result;
    }

    public async Task UpdateScoreTiketsAsync(int tiketsId, float score)
    {
        var sql = @"exec dbo.ОбновлениеОценкиОбращения 
            @ИдОбращения = @tiketsId, 
            @Оценка = @score";

        var parameters = new
        {
            tiketsId,
            score
        };

        await connection.ExecuteAsync(sql, parameters);
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