using System.ComponentModel;

namespace YouKassaAssistant.UI.Domain;

/// <summary>
/// ������ ��� ���������� �����������
/// </summary>
public class WorkerStatistic
{
    /// <summary>
    /// ���� ����������
    /// </summary>
    [DisplayName("������������")]
    [Browsable(false)]
    public int WorkerId { get; set; }

    /// <summary>
    /// ��� ����������
    /// </summary>
    [DisplayName("��� ����������")]
    public string FirstName { get; set; }

    /// <summary>
    /// ���������� ������ ������
    /// </summary>
    [DisplayName("���������� ������ ������")]
    public int CountStatistic { get; set; }
}
