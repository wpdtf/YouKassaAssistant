using System.ComponentModel;

namespace YouKassaAssistant.UI.Domain;

/// <summary>
/// Модель для сотрудника
/// </summary>
public class Worker : AuthDTO
{
    /// <summary>
    /// Ключ сотрудника
    /// </summary>
    [DisplayName("ИдСотрудника")]
    [Browsable(false)]
    public int WorkerId { get; set; }

    /// <summary>
    /// Фамилия сотрудника
    /// </summary>
    [DisplayName("Фамилия сотрудника")]
    public string FirstName { get; set; }

    /// <summary>
    /// Имя сотрудника
    /// </summary>
    [DisplayName("Имя сотрудника")]
    public string LastName { get; set; }

    /// <summary>
    /// Отчество сотрудника
    /// </summary>
    [DisplayName("Отчество сотрудника")]
    public string MiddleName { get; set; }

    /// <summary>
    /// Позиция сотрудника
    /// </summary>
    [DisplayName("Позиция сотрудника")]
    public string Position { get; set; }

    /// <summary>
    /// Телефон сотрудника
    /// </summary>
    [DisplayName("Телефон сотрудника")]
    public string Phone { get; set; }
}
