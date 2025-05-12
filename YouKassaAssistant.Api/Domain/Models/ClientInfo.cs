namespace YouKassaAssistant.Api.Domain.Models;

/// <summary>
/// ��� ���������� �� �������
/// </summary>
public class ClientInfo
{
    /// <summary>
    /// �������
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// ���
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// ��������
    /// </summary>
    public string MiddleName { get; set; }

    /// <summary>
    /// �������
    /// </summary>
    public string Phone { get; set; }

    /// <summary>
    /// �������������� �������
    /// </summary>
    public string PhoneOther { get; set; }

    /// <summary>
    /// ������ ������������ �����������
    /// </summary>
    public string FullNameCompany { get; set; }

    /// <summary>
    /// ������������ �����������
    /// </summary>
    /// <remarks>����������� ������������</remarks>
    public string NameCompany { get; set; }

    /// <summary>
    /// ����
    /// </summary>
    public string OGRN { get; set; }

    /// <summary>
    /// ���
    /// </summary>
    public string INN { get; set; }

    /// <summary>
    /// ����������� ����� �����������
    /// </summary>
    public string CompanyAddress { get; set; }

    /// <summary>
    /// ����� �������
    /// </summary>
    public string Login { get; set; }

    /// <summary>
    /// �������� ������ �������
    /// </summary>
    public float Score { get; set; }
}