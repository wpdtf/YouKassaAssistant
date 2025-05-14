using MailKit.Net.Smtp;
using MimeKit;

namespace YouKassaAssistant.Api;

[ApiController]
[Route("api/other")]
public class OtherController(DataBaseContext dbContext) : ControllerBase
{
    private readonly IDbConnection connection = new SqlConnection(dbContext.Database.GetConnectionString());

    private readonly string Name = "Ваш кассовый ассистент";
    private readonly string Login = "lecarstvo21@gmail.com";
    private readonly string Password = "reqc lshh gxqi huhi";

    /// <summary>
    /// Отправить код подтверждения
    /// </summary>
    /// <response code="204">Код отправлен успешно</response>
    [HttpPost("send-code")]
    public async Task<ActionResult> SendCodeAsync(string email, int code)
    {
        var message = new MimeMessage();
        message.From.Add(new MailboxAddress(Name, Login));
        message.To.Add(new MailboxAddress("", email));
        message.Subject = "Код подтверждения!";
        message.Body = new TextPart("plain") { Text = $"Для подтверждения почты введите {code} в приложении. Никому не сообщайте код!" };

        using var client = new SmtpClient();
        await client.ConnectAsync("smtp.gmail.com", 465, true);
        await client.AuthenticateAsync(Login, Password);
        await client.SendAsync(message);
        await client.DisconnectAsync(true);

        return NoContent();
    }

    /// <summary>
    /// Проверить наличие пользователя по логику
    /// </summary>
    /// <returns>Пользователь</returns>
    /// <response code="200">Найденный пользователь</response>
    [HttpGet("check-login")]
    public async Task<ActionResult> CheckLoginAsync(string email)
    {
        var sql = @$"SELECT dbo.НайтиЛогин('{email}') as IsFind";
        var result = await connection.QueryFirstOrDefaultAsync<bool>(sql);
        return Ok(result);
    }
}