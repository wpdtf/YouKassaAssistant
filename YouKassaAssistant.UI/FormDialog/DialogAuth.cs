using System.Text.RegularExpressions;
using System.Threading.Tasks;
using YouKassaAssistant.UI.Domain;
using YouKassaAssistant.UI.Infrastructure.Repositories;
using YouKassaAssistant.UI.UseCase;

namespace YouKassaAssistant.UI.FormDialog;

public partial class DialogAuth : Form
{
    private readonly CreateConnectionToBack _sendToBack;
    private readonly ClientRepository _clientRepository;
    private readonly WorkerRepository _workerRepository;

    public DialogAuth(CreateConnectionToBack sendToBack, ClientRepository clientRepository, WorkerRepository workerRepository)
    {
        InitializeComponent();
        _sendToBack = sendToBack;
        _clientRepository = clientRepository;
        _workerRepository = workerRepository;
    }

    private void _btnCancel_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void FormRegister_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (this.DialogResult == DialogResult.None)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }

    private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
    {
        UseCasePasswordChar.CheckChar(password1);
    }

    private async void guna2Button2_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(email.Text))
        {
            MessageBox.Show("Введите логин (email)", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            email.Focus();
            return;
        }

        var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        if (!emailRegex.IsMatch(email.Text))
        {
            MessageBox.Show("Введите корректный логин (email)", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            email.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(password1.Text))
        {
            MessageBox.Show("Введите пароль", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            password1.Focus();
            return;
        }

        AuthDTO request = new() { Login = email.Text, Password = UseCaseSHA256.HashPassword(password1.Text) };

        await _sendToBack.AuthenticateAsync(request);

        if (CurrentUser.Id > 0)
        {
            if (CurrentUser.Position is "Админ")
            {
                FormAdmin form = new(_sendToBack);
                form.Show();
            }
            else if (CurrentUser.Position.Count() > 0)
            {
                FormWorker form = new(_sendToBack);
                form.Show();
            }
            else
            {
                FormClient form = new(_sendToBack, _clientRepository);
                form.Show();
            }

            this.Hide();
        }
    }

    private void guna2HtmlLabel1_Click(object sender, EventArgs e)
    {
        DialogRegistration form = new(_sendToBack);
        form.Show();
    }
}