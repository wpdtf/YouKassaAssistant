using System.Text.RegularExpressions;
using YouKassaAssistant.UI.Domain;
using YouKassaAssistant.UI.UseCase;

namespace YouKassaAssistant.UI.FormDialog;

public partial class DialogRegistration : Form
{
    private readonly CreateConnectionToBack _sendToBack;
    private int Code { get; set; }
    private Registration Registration { get; set; }

    public DialogRegistration(CreateConnectionToBack sendToBack)
    {
        InitializeComponent();
        _sendToBack = sendToBack;

        var random = new Random();
        Code = random.Next(1000, 9999);
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
        UseCasePasswordChar.CheckChar(password2);
    }

    private async void btnSave_Click(object sender, EventArgs e)
    {
        if (btnSave.Text is "Подтвердить")
        {
            if (Convert.ToInt32(CheckCode.Text) == Code)
            {
                await _sendToBack.CreateUserAsync(Registration);
                this.Close();
            }
            else
            {
                MessageBox.Show("Введен неверный код подтверждения!", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        else
        {
            var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            var phoneRegex = new Regex(@"^9\d{9}$");
            var passwordRegex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$");

            if (string.IsNullOrWhiteSpace(email.Text))
            {
                MessageBox.Show("Введите логин (email)", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                email.Focus();
                return;
            }

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

            if (!passwordRegex.IsMatch(password1.Text))
            {
                MessageBox.Show("Слишком простой пароль", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                password1.Focus();
                return;
            }

            if (password1.Text != password2.Text)
            {
                MessageBox.Show("Пароли не совпадают", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                password1.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(Lastname.Text))
            {
                MessageBox.Show("Введите фамилию", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Lastname.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(Firstname.Text))
            {
                MessageBox.Show("Введите имя", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Firstname.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(Middlename.Text))
            {
                MessageBox.Show("Введите отчество", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Middlename.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(contact1.Text))
            {
                MessageBox.Show("Введите контактный телефон для связи", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contact1.Focus();
                return;
            }

            if (!phoneRegex.IsMatch(contact1.Text))
            {
                MessageBox.Show("Номер телефона должен начинаться с 9 и содержать еще 9 цифр", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contact1.Focus();
                return;
            }

            if (await _sendToBack.CheckLoginAsync(email.Text))
            {
                MessageBox.Show("Введенный логин уже существует", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                email.Focus();
                return;
            }

            Registration = new()
            {
                FirstName = Firstname.Text,
                LastName = Lastname.Text,
                MiddleName = Middlename.Text,
                Phone = contact1.Text,
                Login = email.Text,
                Password = UseCaseSHA256.HashPassword(password1.Text)
            };

            MessageBox.Show($"На почту {email.Text} мы отправили код подтверждения, введите его в поле для успешной регистрации!", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CheckCode.Visible = true;
            btnSave.Text = "Подтвердить";

            await _sendToBack.SendCodeEmail(email.Text, Code);
        }
    }
}