using System.ComponentModel;

namespace YouKassaAssistant.UI.Domain;

/// <summary>
/// Отчет по выполненным работам
/// </summary>
public class ReportResultTikets
{
    /// <summary>
    /// Дата отчета
    /// </summary>
    [DisplayName("Дата отчета")]
    public DateTime DateReport { get; set; }

    /// <summary>
    /// Количество обращений
    /// </summary>
    [DisplayName("Количество обращений")]
    public int CountTikets { get; set; }

    /// <summary>
    /// Сумма за обращения
    /// </summary>
    [DisplayName("Сумма за обращения")]
    public decimal SumTikets { get; set; }
}
