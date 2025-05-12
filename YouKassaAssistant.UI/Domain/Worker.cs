using System.ComponentModel;

namespace YouKassaAssistant.UI.Domain;

/// <summary>
/// ������ ��� ����������
/// </summary>
public class Worker
{
    /// <summary>
    /// ���� ����������
    /// </summary>
    [DisplayName("������������")]
    [Browsable(false)]
    public int WorkerId { get; set; }

    /// <summary>
    /// ������� ����������
    /// </summary>
    [DisplayName("������� ����������")]
    public string FirstName { get; set; }

    /// <summary>
    /// ��� ����������
    /// </summary>
    [DisplayName("��� ����������")]
    public string LastName { get; set; }

    /// <summary>
    /// ������� ����������
    /// </summary>
    [DisplayName("������� ����������")]
    public string Position { get; set; }

    /// <summary>
    /// ������� ����������
    /// </summary>
    [DisplayName("������� ����������")]
    public string Phone { get; set; }

    /// <summary>
    /// ���� ������ ������ ����������
    /// </summary>
    [DisplayName("���� ������ ������ ����������")]
    public DateTime DateStart { get; set; }
}
