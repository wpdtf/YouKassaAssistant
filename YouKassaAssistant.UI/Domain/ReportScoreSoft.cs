using System.ComponentModel;

namespace YouKassaAssistant.UI.Domain;

/// <summary>
/// Отчет по оценкам приложений
/// </summary>
public class ReportScoreSoft
{
    /// <summary>
    /// Оценка приложения
    /// </summary>
    [DisplayName("Оценка приложения")]
    public float Score { get; set; }

    /// <summary>
    /// Количество клиентов
    /// </summary>
    [DisplayName("Количество клиентов")]
    public int CountClient { get; set; }
}
