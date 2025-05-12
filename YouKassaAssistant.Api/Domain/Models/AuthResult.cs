namespace YouKassaAssistant.Api.Domain.Models;

/// <summary>
/// ������ ��� ������ � ������������
/// </summary>
public class AuthResult
{
    /// <summary>
    /// ���� ������������
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// ��������� ����������
    /// </summary>
    /// <remarks>� ������� ����� �������</remarks>
    public string Position { get; set; }
}