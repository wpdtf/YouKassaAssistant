using System.ComponentModel;

namespace YouKassaAssistant.UI.Domain;

/// <summary>
/// ����� �� ������� ����������
/// </summary>
public class ReportScoreSoft
{
    /// <summary>
    /// ������ ����������
    /// </summary>
    [DisplayName("������ ����������")]
    public float Score { get; set; }

    /// <summary>
    /// ���������� ��������
    /// </summary>
    [DisplayName("���������� ��������")]
    public int CountClient { get; set; }
}
