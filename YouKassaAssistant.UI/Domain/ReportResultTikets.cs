using System.ComponentModel;

namespace YouKassaAssistant.UI.Domain;

/// <summary>
/// ����� �� ����������� �������
/// </summary>
public class ReportResultTikets
{
    /// <summary>
    /// ���� ������
    /// </summary>
    [DisplayName("���� ������")]
    public DateTime DateReport { get; set; }

    /// <summary>
    /// ���������� ���������
    /// </summary>
    [DisplayName("���������� ���������")]
    public int CountTikets { get; set; }

    /// <summary>
    /// ����� �� ���������
    /// </summary>
    [DisplayName("����� �� ���������")]
    public decimal SumTikets { get; set; }
}
