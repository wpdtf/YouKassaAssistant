using System.ComponentModel;

namespace YouKassaAssistant.UI.Domain;

public class AuthDTO
{
    [DisplayName("Логин для входа")]
    public string Login { get; set; } = string.Empty;

    [Browsable(false)]
    public string Password { get; set; } = string.Empty;
} 