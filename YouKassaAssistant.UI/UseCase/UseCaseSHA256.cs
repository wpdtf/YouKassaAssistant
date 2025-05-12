using System.Security.Cryptography;
using System.Text;

namespace YouKassaAssistant.UI.UseCase;

class UseCaseSHA256
{
    public static string HashPassword(string password)
    {
        byte[] bytes = SHA256.HashData(Encoding.UTF8.GetBytes(password));
        return Convert.ToBase64String(bytes);
    }
}
