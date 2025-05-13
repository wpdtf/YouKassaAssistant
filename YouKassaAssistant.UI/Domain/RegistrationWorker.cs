namespace YouKassaAssistant.UI.Domain;

/// <summary>
/// Модель для регистрации клиента
/// </summary>
public class RegistrationWorker
{
    /// <summary>
    /// Логин клиента
    /// </summary>
    public string Login { get; set; }

    /// <summary>
    /// Пароль клиента
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    /// Фамилия
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Имя
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Отчество
    /// </summary>
    public string MiddleName { get; set; }

    /// <summary>
    /// Телефон
    /// </summary>
    public string Phone { get; set; }

    /// <summary>
    /// Должность
    /// </summary>
    public string Position { get; set; }
}
