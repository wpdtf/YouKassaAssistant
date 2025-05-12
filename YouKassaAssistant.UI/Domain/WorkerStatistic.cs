using System.ComponentModel;

namespace YouKassaAssistant.UI.Domain;

/// <summary>
/// Модель для статистики сотрудников
/// </summary>
public class WorkerStatistic
{
    /// <summary>
    /// Ключ сотрудника
    /// </summary>
    [DisplayName("ИдСотрудника")]
    [Browsable(false)]
    public int WorkerId { get; set; }

    /// <summary>
    /// ФИО сотрудника
    /// </summary>
    [DisplayName("ФИО сотрудника")]
    public string FirstName { get; set; }

    /// <summary>
    /// Количество взятых заявок
    /// </summary>
    [DisplayName("Количество взятых заявок")]
    public int CountStatistic { get; set; }
}
