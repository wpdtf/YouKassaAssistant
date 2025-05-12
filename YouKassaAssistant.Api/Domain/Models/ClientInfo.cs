namespace YouKassaAssistant.Api.Domain.Models;

/// <summary>
/// Вся информация по клиенту
/// </summary>
public class ClientInfo
{
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
    /// Дополнительный телефон
    /// </summary>
    public string PhoneOther { get; set; }

    /// <summary>
    /// Полное наименование организации
    /// </summary>
    public string FullNameCompany { get; set; }

    /// <summary>
    /// Наименование организации
    /// </summary>
    /// <remarks>Сокращенное наименование</remarks>
    public string NameCompany { get; set; }

    /// <summary>
    /// ОГРН
    /// </summary>
    public string OGRN { get; set; }

    /// <summary>
    /// ИНН
    /// </summary>
    public string INN { get; set; }

    /// <summary>
    /// Юридический адрес организации
    /// </summary>
    public string CompanyAddress { get; set; }

    /// <summary>
    /// Логин клиента
    /// </summary>
    public string Login { get; set; }

    /// <summary>
    /// Получить оценку клиента
    /// </summary>
    public float Score { get; set; }
}