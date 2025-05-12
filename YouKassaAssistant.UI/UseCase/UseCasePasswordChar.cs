using Guna.UI2.WinForms;

namespace YouKassaAssistant.UI.UseCase;

class UseCasePasswordChar
{
    public static void CheckChar(Guna2TextBox checkTextBox)
    {
        checkTextBox.PasswordChar = checkTextBox.PasswordChar is '●' ? '\0' : '●';
    }
}
