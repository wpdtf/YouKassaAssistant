namespace YouKassaAssistant.Api.Domain.DTO;

/// <summary>
/// Модель для обновления информации по клиенту
/// </summary>
public class ClientInfoDTO
{
    /// <summary>
    /// Ключ клиента
    /// </summary>
    public int ClientId { get; set; }

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
}
