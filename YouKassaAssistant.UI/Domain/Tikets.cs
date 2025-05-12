namespace YouKassaAssistant.UI.Domain;

/// <summary>
/// ������ ��� ���������
/// </summary>
public class Tikets
{
    /// <summary>
    /// ���� ���������
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// �������� ���������
    /// </summary>
    public string Theme { get; set; }

    /// <summary>
    /// �������� ���������
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// ���� ���������
    /// </summary>
    public byte[]? ImageBytes { get; set; }

    /// <summary>
    /// ������ ���������
    /// </summary>
    public string Status { get; set; }

    /// <summary>
    /// ������ ���������
    /// </summary>
    public float Score { get; set; }

    /// <summary>
    /// ����� �� ����������� ���������
    /// </summary>
    public bool IsVisible { get; set; }

    /// <summary>
    /// ������� �� ���������
    /// </summary>
    public bool IsFire { get; set; }

    /// <summary>
    /// ���� ���������
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// ���� ��������� ���������
    /// </summary>
    public DateTime DateCreate { get; set; }

    /// <summary>
    /// ���� ����������
    /// </summary>
    public int WorkerId { get; set; }

    /// <summary>
    /// ��� ����������
    /// </summary>
    public string WorkerFullName { get; set; }
}
