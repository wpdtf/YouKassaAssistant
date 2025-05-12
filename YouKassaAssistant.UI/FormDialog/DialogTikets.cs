using Guna.UI2.WinForms;
using System.Diagnostics;
using System.Threading.Tasks;
using YouKassaAssistant.UI.Domain;
using YouKassaAssistant.UI.Infrastructure.Repositories;

namespace YouKassaAssistant.UI.FormDialog;

public partial class DialogTikets : Form
{
    private readonly CreateConnectionToBack _sendToBack;
    private Tikets Tikets;
    private List<MessageFromTikets> listMessage = new List<MessageFromTikets>();
    private readonly ClientRepository _clientRepository;
    private readonly WorkerRepository _workerRepository;

    public DialogTikets(CreateConnectionToBack sendToBack, Tikets tikets, bool isReadOnly = false, ClientRepository clientRepository = null, WorkerRepository workerRepository = null)
    {
        InitializeComponent();
        _sendToBack = sendToBack;
        Tikets = tikets;
        _clientRepository = clientRepository;
        _workerRepository = workerRepository;

        guna2Button1.Enabled = !isReadOnly;
        guna2Button2.Enabled = !isReadOnly;

        UpdateForm();
        UpdateListMessageAsync();
    }

    private void UpdateForm()
    {
        Tikets = _clientRepository.GetTiketsAsync(Tikets.Id);

        RatingStar.Value = Tikets.Score;

        label3.Text = $"Обращение: {Tikets.Id}";

        Theme.Text = Tikets.Theme;
        Description.Text = Tikets.Description;

        if (Tikets.ImageBytes is not null)
            Images.Image = ByteArrayToImage(Tikets.ImageBytes);


        switch (Tikets.Status)
        {
            case "новое":
                guna2Button2.Text = "Отменить";
                break;
            case "в работе":
                if (CurrentUser.Position.Count() > 0)
                {
                    guna2Button2.Text = "Готово";
                    price.Visible = true;
                }
                else
                    guna2Button2.Visible = false;
                break;
            case "ждем оплаты":
                if (CurrentUser.Position.Count() > 0)
                    guna2Button2.Visible = false;
                else
                    guna2Button2.Text = "Оплатить";
                break;
            case "возвращено":
                if (CurrentUser.Position.Count() > 0)
                    guna2Button2.Text = "Готово";
                else
                    guna2Button2.Visible = false;
                break;
            case "завершено":
                RatingStar.ReadOnly = false;
                guna2Button2.Text = "Вернуть";
                break;
        }
    }

    public async Task UpdateListMessageAsync()
    {
        flowLayoutPanel1.Controls.Clear();

        if (CurrentUser.Position.Count() == 0)
            listMessage = await _clientRepository.GetListMessageAsync(Tikets.Id);
        else
            listMessage = await _clientRepository.GetListMessageAsync(Tikets.Id);


        foreach (var item in listMessage)
        {
            var element = new MessageElement(item, _clientRepository, _workerRepository);

            if (!element.MessageInfo.IsVisible)
                element.UpdateInfoOrderAsync();

            flowLayoutPanel1.Controls.Add(element);
        }

        flowLayoutPanel1.VerticalScroll.Value = flowLayoutPanel1.VerticalScroll.Minimum;
        TimeUpdateListMessageAsync();
    }

    private bool ValidateFields()
    {
        if (string.IsNullOrWhiteSpace(_Message.Text))
        {
            MessageBox.Show("Введите сообщение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _Message.Focus();
            return false;
        }

        return true;
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

    private Image ByteArrayToImage(byte[] byteArray)
    {
        MemoryStream ms = new MemoryStream(byteArray);
        return Image.FromStream(ms);
    }

    private void Images_Click(object sender, EventArgs e)
    {
        if (Tikets.ImageBytes is not null)
        {
            var tempFilePath = Path.GetTempFileName() + ".jpg";

            File.WriteAllBytes(tempFilePath, Tikets.ImageBytes);

            Process.Start(new ProcessStartInfo
            {
                FileName = tempFilePath,
                UseShellExecute = true
            });
        }
        else
        {
            MessageBox.Show("Фотография не загружена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void guna2Button2_Click(object sender, EventArgs e)
    {
        switch (Tikets.Status)
        {
            case "новое":
                _clientRepository.UpdateStatusTiketsAsync(Tikets.Id, "завершено");
                break;
            case "в работе":
                if (CurrentUser.Position.Count() > 0)
                    _clientRepository.UpdateStatusTiketsAsync(Tikets.Id, "ждем оплаты");
                break;
            case "ждем оплаты":
                _clientRepository.UpdateStatusTiketsAsync(Tikets.Id, "завершено");
                break;
            case "возвращено":
                _clientRepository.UpdateStatusTiketsAsync(Tikets.Id, "завершено");
                break;
            case "завершено":
                _clientRepository.UpdateStatusTiketsAsync(Tikets.Id, "возвращено");
                break;
        }

        UpdateForm();
    }

    private async void guna2Button1_Click(object sender, EventArgs e)
    {
        try
        {
            if (!ValidateFields())
            {
                return;
            }

            if (CurrentUser.Position.Count() == 0)
                await _clientRepository.CreateMessageAsync(Tikets.Id, _Message.Text);
            else
                await _clientRepository.CreateMessageAsync(Tikets.Id, _Message.Text);

            _Message.Text = "";
            await UpdateListMessageAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            this.Enabled = true;
        }
    }

    private async Task TimeUpdateListMessageAsync()
    {
        while (true)
        {
            await Task.Delay(5000);

            var result = new List<MessageFromTikets>();

            if (CurrentUser.Position.Count() == 0)
                result = await _clientRepository.GetListMessageAsync(Tikets.Id);
            else
                result = await _clientRepository.GetListMessageAsync(Tikets.Id);

            if (result.Count != listMessage.Count)
            {
                await UpdateListMessageAsync();
                break;
            }
        }
    }

    private async void RatingStar_ValueChanged(object sender, EventArgs e)
    {
        _clientRepository.UpdateScoreTiketsAsync(Tikets.Id, RatingStar.Value);
    }
}