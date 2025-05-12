namespace YouKassaAssistant.Api.Domain.DTO;

/// <summary>
/// ������ ��� ����������� �������
/// </summary>
public class RegistrationDTO
{
    /// <summary>
    /// ����� �������
    /// </summary>
    public string Login { get; set; }

    /// <summary>
    /// ������ �������
    /// </summary>
    public string Password { get; set; }

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
}
