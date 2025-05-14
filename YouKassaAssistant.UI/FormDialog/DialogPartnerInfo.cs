using System.Text.RegularExpressions;
using YouKassaAssistant.UI.Domain;
using YouKassaAssistant.UI.UseCase;

namespace YouKassaAssistant.UI.FormDialog;

public partial class DialogPartnerInfo : Form
{
    private readonly CreateConnectionToBack _sendToBack;
    private string LastLogin;

    public DialogPartnerInfo(CreateConnectionToBack sendToBack)
    {
        InitializeComponent();
        _sendToBack = sendToBack;
        UpdateListMessageAsync();
    }

    public async Task UpdateListMessageAsync()
    {
        var result = await _sendToBack.GetUserInfo();

        email.Text = result.Login;
        LastLogin = result.Login;

        Firstname.Text = result.FirstName;
        Lastname.Text = result.LastName;
        Middlename.Text = result.LastName;
        contact1.Text = result.Phone;
        contact2.Text = result.PhoneOther;
        FullnameOrg.Text = result.FullNameCompany;
        NameOrg.Text = result.NameCompany;
        OGRN.Text = result.OGRN;
        INN.Text = result.INN;
        FullAddress.Text = result.CompanyAddress;

        RatingStar.Value = result.Score;
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

    private async void RatingStar_ValueChanged(object sender, EventArgs e)
    {
        await _sendToBack.UpdateUserScoreAsync(RatingStar.Value);
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

        if (!Regex.IsMatch(password1.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$"))
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

        if (LastLogin != email.Text && await _sendToBack.CheckLoginAsync(email.Text))
        {
            MessageBox.Show("Введенный логин уже существует", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            email.Focus();
            return;
        }

        AuthDTO request = new()
        {
            Login = email.Text,
            Password = UseCaseSHA256.HashPassword(password1.Text)
        };

        await _sendToBack.UpdateUserAsync(request);

        await UpdateListMessageAsync();
    }

    private async void btnSave_Click(object sender, EventArgs e)
    {
        var phoneRegex = new Regex(@"^9\d{9}$");

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

        if (!string.IsNullOrWhiteSpace(contact2.Text))
        {
            if (!phoneRegex.IsMatch(contact2.Text))
            {
                MessageBox.Show("Номер телефона должен начинаться с 9 и содержать еще 9 цифр", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contact2.Focus();
                return;
            }
        }

        if (string.IsNullOrWhiteSpace(FullnameOrg.Text))
        {
            MessageBox.Show("Введите полное наименование организации", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            FullnameOrg.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(NameOrg.Text))
        {
            MessageBox.Show("Введите сокращенное наименование организации", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            NameOrg.Focus();
            return;
        }

        if (FullnameOrg.Text.Count() < NameOrg.Text.Count())
        {
            MessageBox.Show("Сокращенное наименование не может быть больше полного наименования", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            NameOrg.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(OGRN.Text))
        {
            MessageBox.Show("Введите ОГРН вашей организации", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            OGRN.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(INN.Text))
        {
            MessageBox.Show("Введите ИНН вашей организации", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            INN.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(FullAddress.Text))
        {
            MessageBox.Show("Введите полный адрес вашей организации", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            FullAddress.Focus();
            return;
        }

        ClientInfo request = new()
        {
            ClientId = CurrentUser.Id,
            FirstName = Firstname.Text,
            LastName = Lastname.Text,
            MiddleName = Middlename.Text,
            Phone = contact1.Text,
            PhoneOther = contact2.Text,
            FullNameCompany = FullnameOrg.Text,
            NameCompany = NameOrg.Text,
            OGRN = OGRN.Text,
            INN = INN.Text,
            CompanyAddress = FullAddress.Text
        };

        await _sendToBack.UpdateClientAsync(request);

        await UpdateListMessageAsync();
    }
}