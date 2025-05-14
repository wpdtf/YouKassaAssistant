using System.Text.RegularExpressions;
using YouKassaAssistant.UI.Domain;
using YouKassaAssistant.UI.Infrastructure.Repositories;
using YouKassaAssistant.UI.UseCase;

namespace YouKassaAssistant.UI.FormDialog;

public partial class DialogWorkerEdit : Form
{
    private readonly CreateConnectionToBack _sendToBack;
    private Worker LocalWorker;
    private WorkerRepository _workerRepository;
    private DialogWorkerList workerList;

    public DialogWorkerEdit(CreateConnectionToBack sendToBack, bool isCreate, Worker worker, WorkerRepository workerRepository, DialogWorkerList dialogWorkerList)
    {
        InitializeComponent();
        _sendToBack = sendToBack;
        LocalWorker = worker;
        _workerRepository = workerRepository;
        workerList = dialogWorkerList;

        var listPosition = new List<string>();
        listPosition.Add("админ");
        listPosition.Add("младший технический сотрудник");
        listPosition.Add("технический сотрудник");
        listPosition.Add("старший технический сотрудник");

        guna2ComboBox1.Items.AddRange(listPosition.ToArray());

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
            Middlename.Text = LocalWorker.MiddleName;
            contact1.Text = LocalWorker.Phone;

            guna2ComboBox1.SelectedItem = LocalWorker.Position;
            email.Text = LocalWorker.Login;
        }
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
        if (!CheckInfo())
            return;

        var request = new Worker()
        {
            FirstName = Firstname.Text,
            LastName = Lastname.Text,
            MiddleName = Middlename.Text,
            Phone = contact1.Text,
            Position = guna2ComboBox1.Text,
            WorkerId = LocalWorker.WorkerId
        };

        await _workerRepository.UpdateWorkerAsync(request);

        await workerList.UpdateListAsync();
        this.Close();
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

        if (string.IsNullOrWhiteSpace(guna2ComboBox1.Text))
        {
            MessageBox.Show("Обязательно нужно выбрать должность", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

    private async Task<bool> CheckAuthInfo()
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

        if ((LocalWorker is null || LocalWorker.Login.Length == 0) && await _sendToBack.CheckLoginAsync(email.Text))
        {
            MessageBox.Show("Введенный логин уже существует", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            email.Focus();
            return false;
        }

        if (LocalWorker is not null && LocalWorker.Login != email.Text && await _sendToBack.CheckLoginAsync(email.Text))
        {
            MessageBox.Show("Введенный логин уже существует", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            email.Focus();
            return false;
        }

        return true;
    }

    private async void guna2Button1_Click(object sender, EventArgs e)
    {
        if (!await CheckAuthInfo())
            return;

        if (!CheckInfo())
            return;

        var request = new RegistrationWorker()
        {
            FirstName = Firstname.Text,
            LastName = Lastname.Text,
            MiddleName = Middlename.Text,
            Phone = contact1.Text,
            Position = guna2ComboBox1.Text,
            Login = email.Text,
            Password = UseCaseSHA256.HashPassword(password1.Text)
        };

        await _workerRepository.CreateWorkerAsync(request);

        await workerList.UpdateListAsync();
        this.Close();
    }

    private async void guna2Button2_Click_1(object sender, EventArgs e)
    {
        if (!await CheckAuthInfo())
            return;

        var request = new AuthDTO()
        {
            Login = email.Text,
            Password = UseCaseSHA256.HashPassword(password1.Text)
        };

        await _workerRepository.UpdateUserWorkerAsync(request, LocalWorker.WorkerId);

        await workerList.UpdateListAsync();
        this.Close();
    }
}