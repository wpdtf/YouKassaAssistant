namespace YouKassaAssistant.Api;

[ApiController]
[Route("api/main")]
public class MainController(DataBaseContext dbContext) : ControllerBase
{
    private readonly IDbConnection connection = new SqlConnection(dbContext.Database.GetConnectionString());

    /// <summary>
    /// Авторизация
    /// </summary>
    /// <param name="authDTO">Данные для аутентификации</param>
    /// <returns>Клиент</returns>
    /// <response code="200">Авторизация успешна</response>
    /// <response code="401">Неверные учетные данные</response>
    [HttpPost("auth")]
    public async Task<ActionResult<AuthResult>> AuthenticateAsync(AuthDTO authDTO)
    {
        var sql = @$"exec dbo.Авторизация @Логин = N'{authDTO.Login}', @Пароль = N'{authDTO.Password}'";
        var result = await connection.QueryFirstAsync<AuthResult>(sql);

        if (result.UserId == 0)
        {
            return Unauthorized("Неверный логин или пароль");
        }

        return Ok(result);
    }

    /// <summary>
    /// Регистрация
    /// </summary>
    /// <param name="registrationDTO">Данные для регистрации</param>
    /// <response code="204">Регистрация успешна</response>
    [HttpPost("create-client")]
    public async Task<ActionResult> CreateClientAsync(RegistrationDTO registrationDTO)
    {
        var sql = @$"exec dbo.РегистрацияКлиента @Логин = N'{registrationDTO.Login}', 
                                    @Пароль = N'{registrationDTO.Password}',
                                    @Имя = N'{registrationDTO.FirstName}',
                                    @Фамилия = N'{registrationDTO.LastName}',
                                    @Отчество = N'{registrationDTO.MiddleName}',
                                    @КонтактныйТелефон = N'{registrationDTO.Phone}'";

        await connection.ExecuteAsync(sql);

        return NoContent();
    }

    /// <summary>
    /// Обновление информации по клиенту
    /// </summary>
    /// <param name="clientInfoDTO">Данные для обновления</param>
    /// <response code="204">Успешное обновление</response>
    [HttpPut("update-client")]
    public async Task<ActionResult> UpdateClientAync(ClientInfoDTO clientInfoDTO)
    {
        var sql = @$"exec dbo.ОбновленияКлиента @Имя = N'{clientInfoDTO.FirstName}',
                                    @Фамилия = N'{clientInfoDTO.LastName}',
                                    @Отчество = N'{clientInfoDTO.MiddleName}',
                                    @КонтактныйТелефон = N'{clientInfoDTO.Phone}',
                                    @КонтактныйТелефон2 = N'{clientInfoDTO.PhoneOther}',
                                    @ПолноеНаименование = N'{clientInfoDTO.FullNameCompany}',
                                    @Наименование = N'{clientInfoDTO.NameCompany}',
                                    @ОГРН = N'{clientInfoDTO.OGRN}',
                                    @ИНН = N'{clientInfoDTO.INN}',
                                    @ЮридическийАдрес = N'{clientInfoDTO.CompanyAddress}',
                                    @ИдКлиента = N'{clientInfoDTO.ClientId}'";

        await connection.ExecuteAsync(sql);

        return NoContent();
    }

    /// <summary>
    /// Обновление оценки по клиенту
    /// </summary>
    /// <param name="score">Оценка клиента</param>
    /// <param name="clientId">По какому клиенту</param>
    /// <response code="204">Успешное обновление</response>
    [HttpPut("update-client-score")]
    public async Task<ActionResult> UpdateScoreClientAync(float score, int clientId)
    {
        var sql = @$"exec dbo.ОбновлениеОценкиПриложения @Оценка = {score},
                                    @ИдКлиента = {clientId}";

        await connection.ExecuteAsync(sql);

        return NoContent();
    }

    /// <summary>
    /// Получение информации по клиенту
    /// </summary>
    /// <param name="clientId">По какому клиенту</param>
    /// <returns>Данные по клиенту</returns>
    /// <response code="200">Получение данных по клиенту</response>
    [HttpGet("client")]
    public async Task<ActionResult> GetClientAsync(int clientId)
    {
        var sql = @$"exec dbo.ПолучениеИнформацииПоКлиенту @ИдКлиента = {clientId}";
        var result = await connection.QueryFirstOrDefaultAsync<ClientInfo>(sql);

        return Ok(result);
    }

    /// <summary>
    /// Обновление информации по пользователю клиента
    /// </summary>
    /// <param name="authDTO">Данные для обновления</param>
    /// <param name="clientId">По какому клиенту</param>
    /// <response code="204">Успешное обновление</response>
    [HttpPut("update-user")]
    public async Task<ActionResult> UpdateUserAync(AuthDTO authDTO, int clientId)
    {
        var sql = @$"exec dbo.ОбновленияПользователяКлиента @Логин = N'{authDTO.Login}',
                                    @Пароль = N'{authDTO.Password}',
                                    @ИдКлиента = {clientId}";

        await connection.ExecuteAsync(sql);

        return NoContent();
    }
}