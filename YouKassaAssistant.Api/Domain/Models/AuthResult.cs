namespace YouKassaAssistant.Api.Domain.Models;

/// <summary>
/// Модель для работы с авторизацией
/// </summary>
public class AuthResult
{
    /// <summary>
    /// Ключ пользователя
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Должность сотрудника
    /// </summary>
    /// <remarks>У клиента будет пустота</remarks>
    public string Position { get; set; }
}