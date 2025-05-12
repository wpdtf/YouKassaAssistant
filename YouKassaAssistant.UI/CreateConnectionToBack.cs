using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using YouKassaAssistant.UI.Domain;

namespace YouKassaAssistant.UI;

public class CreateConnectionToBack
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _jsonOptions;

    public CreateConnectionToBack()
    {
        _httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:5000/api/") };
        _jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
    }

    public async Task AuthenticateAsync(AuthDTO request)
    {
        var json = JsonSerializer.Serialize(request, _jsonOptions);
        var content = new StringContent(json, Encoding.UTF8, new MediaTypeHeaderValue("application/json"));

        try
        {
            var response = await _httpClient.PostAsync("main/auth", content);

            if (response.IsSuccessStatusCode)
            {
                var responseJson = await response.Content.ReadAsStringAsync();

                var client = JsonSerializer.Deserialize<Auth>(responseJson, _jsonOptions);
                UpdateCurrentUser(client);
            }
            else
            {
                throw new Exception(await response.Content.ReadAsStringAsync());
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void UpdateCurrentUser(Auth user)
    {
        CurrentUser.Id = user.UserId;
        CurrentUser.Position = user.Position;
    }

    public async Task CreateUserAsync(Registration request)
    {
        var json = JsonSerializer.Serialize(request, _jsonOptions);
        var content = new StringContent(json, Encoding.UTF8, new MediaTypeHeaderValue("application/json"));

        try
        {
            var response = await _httpClient.PostAsync("main/create-client", content);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(await response.Content.ReadAsStringAsync());
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public async Task UpdateClientAsync(ClientInfo request)
    {
        var json = JsonSerializer.Serialize(request, _jsonOptions);
        var content = new StringContent(json, Encoding.UTF8, new MediaTypeHeaderValue("application/json"));

        try
        {
            var response = await _httpClient.PutAsync("main/update-client", content);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(await response.Content.ReadAsStringAsync());
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public async Task UpdateUserScoreAsync(float score)
    {
        try
        {
            var response = await _httpClient.PutAsync($"main/update-client-score?score={score.ToString().Replace(',', '.')}&clientId={CurrentUser.Id}", null);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(await response.Content.ReadAsStringAsync());
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public async Task<ClientInfo> GetUserInfo()
    {
        try
        {
            var response = await _httpClient.GetAsync($"main/client?clientId={CurrentUser.Id}");

            if (response.IsSuccessStatusCode)
            {
                var responseJson = await response.Content.ReadAsStringAsync();
                var client = JsonSerializer.Deserialize<ClientInfo>(responseJson, _jsonOptions);

                return client;
            }
            else
            {
                throw new Exception(await response.Content.ReadAsStringAsync());
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return new();
        }
    }

    public async Task<bool> CheckLoginAsync(string email)
    {
        try
        {
            var response = await _httpClient.GetAsync($"other/check-login?email={email}");

            if (response.IsSuccessStatusCode)
            {
                var result = Convert.ToBoolean(await response.Content.ReadAsStringAsync());
                return result;
            }
            else
            {
                throw new Exception(await response.Content.ReadAsStringAsync());
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return true;
        }
    }

    public async Task SendCodeEmail(string email, int code)
    {
        try
        {
            var response = await _httpClient.PostAsync($"other/send-code?email={email}&code={code}", null);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(await response.Content.ReadAsStringAsync());
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public async Task UpdateUserAsync(AuthDTO authDTO)
    {
        var json = JsonSerializer.Serialize(authDTO, _jsonOptions);
        var content = new StringContent(json, Encoding.UTF8, new MediaTypeHeaderValue("application/json"));

        try
        {
            var response = await _httpClient.PutAsync($"main/update-user?clientId={CurrentUser.Id}", content);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(await response.Content.ReadAsStringAsync());
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
