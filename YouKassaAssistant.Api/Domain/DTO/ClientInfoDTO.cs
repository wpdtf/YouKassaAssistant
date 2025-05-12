namespace YouKassaAssistant.Api.Domain.DTO;

/// <summary>
/// ������ ��� ���������� ���������� �� �������
/// </summary>
public class ClientInfoDTO
{
    /// <summary>
    /// ���� �������
    /// </summary>
    public int ClientId { get; set; }

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
}
