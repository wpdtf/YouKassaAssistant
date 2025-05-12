using System.Text.RegularExpressions;
using YouKassaAssistant.UI.Domain;
using YouKassaAssistant.UI.UseCase;

namespace YouKassaAssistant.UI.FormDialog;

public partial class DialogWorkerEdit : Form
{
    private readonly CreateConnectionToBack _sendToBack;
    private Worker LocalWorker;

    public DialogWorkerEdit(CreateConnectionToBack sendToBack, bool isCreate, Worker worker)
    {
        InitializeComponent();
        _sendToBack = sendToBack;
        LocalWorker = worker;

        if (isCreate)
        {
            btnSave.Visible = false;
            guna2Button2.Visible = false;

            guna2Button1.Visible = true;
        }
        else
        {
            btnSave.Visible = true;
            guna2Button2.Visible = true;

            guna2Button1.Visible = false;

            Lastname.Text = LocalWorker.LastName;
            Firstname.Text = LocalWorker.FirstName;
        }
    }

    public async Task UpdateListMessageAsync()
    {

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

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (!CheckInfo())
            return;
    }

    private bool CheckInfo()
    {
        var phoneRegex = new Regex(@"^9\d{9}$");

        if (string.IsNullOrWhiteSpace(Lastname.Text))
        {
            MessageBox.Show("Введите фамилию", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Lastname.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(Firstname.Text))
        {
            MessageBox.Show("Введите имя", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Firstname.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(Middlename.Text))
        {
            MessageBox.Show("Введите отчество", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Middlename.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(contact1.Text))
        {
            MessageBox.Show("Введите контактный телефон для связи", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            contact1.Focus();
            return false;
        }

        if (!phoneRegex.IsMatch(contact1.Text))
        {
            MessageBox.Show("Номер телефона должен начинаться с 9 и содержать еще 9 цифр", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            contact1.Focus();
            return false;
        }

        return true;
    }

    private bool CheckAuthInfo()
    {
        if (string.IsNullOrWhiteSpace(email.Text))
        {
            MessageBox.Show("Введите логин (email)", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            email.Focus();
            return false;
        }

        var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        if (!emailRegex.IsMatch(email.Text))
        {
            MessageBox.Show("Введите корректный логин (email)", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            email.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(password1.Text))
        {
            MessageBox.Show("Введите пароль", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            password1.Focus();
            return false;
        }

        if (!Regex.IsMatch(password1.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$"))
        {
            MessageBox.Show("Слишком простой пароль", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            password1.Focus();
            return false;
        }

        if (password1.Text != password2.Text)
        {
            MessageBox.Show("Пароли не совпадают", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            password1.Focus();
            return false;
        }

        return true;
    }

    private void guna2Button1_Click(object sender, EventArgs e)
    {
        if (!CheckAuthInfo())
            return;

        if (!CheckInfo())
            return;
    }

    private void guna2Button2_Click_1(object sender, EventArgs e)
    {
        if (!CheckAuthInfo())
            return;
    }
}