using Microsoft.IdentityModel.Tokens;
using System.Diagnostics;
using System.Threading.Tasks;
using YouKassaAssistant.UI.Domain;
using YouKassaAssistant.UI.FormDialog;
using YouKassaAssistant.UI.Infrastructure.Repositories;
using YouKassaAssistant.UI.UseCase;

namespace YouKassaAssistant.UI;

public partial class FormClient : Form
{
    private readonly CreateConnectionToBack _sendToBack;
    private readonly ClientRepository _clientRepository;

    private byte[]? bytesImage = null;
    private bool isFire = false;

    public FormClient(CreateConnectionToBack sendToBack, ClientRepository clientRepository)
    {
        InitializeComponent();
        _sendToBack = sendToBack;
        _clientRepository = clientRepository;
    }

    private async void FormMain_Load(object sender, EventArgs e)
    {
        guna2ComboBox1.SelectedIndex = 0;
    }

    private async Task UpdateTiketsInfo()
    {
        var sortOrder = guna2ComboBox1.Text;

        await UseCaseGenerateListTikets.GenerateElementTikets(flowLayoutPanel1, _sendToBack, sortOrder, false, clientRepository: _clientRepository);
    }

    private void guna2ControlBox2_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void guna2HtmlLabel1_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog
        {
            Filter = "Изображения (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp",
            Title = "Выберите изображение"
        };

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            guna2PictureBox1.Visible = true;
            guna2PictureBox1.Image = new Bitmap(openFileDialog.FileName);

            bytesImage = ImageToByteArray(guna2PictureBox1.Image);

            MessageBox.Show("Изображение загружено!");
        }
    }

    private async void btnCreateTiket_Click(object sender, EventArgs e)
    {
        try
        {
            if (Theme.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Заполните тему обращения!", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Description.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Заполните описание обращения!", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (bytesImage is null)
            {
                var check = MessageBox.Show("Вы уверены, что хотите продолжить без фото?", "Валидация", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.No)
                {
                    return;
                }
            }

            var request = new Tikets
            {
                Theme = Theme.Text,
                Description = Description.Text,
                ImageBytes = bytesImage,
                IsFire = isFire
            };

            await _clientRepository.CreateTikets(request);
            await UpdateTiketsInfo();

            Theme.Text = "";
            Description.Text = "";
            bytesImage = null;
            guna2PictureBox1.Image = null;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка: {ex.Message}", "Не удалось создать задание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private byte[] ImageToByteArray(Image image)
    {
        using var ms = new MemoryStream();
        image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
        return ms.ToArray();
    }

    private void guna2Button3_Click(object sender, EventArgs e)
    {
        var foreColor = new Color();
        var questionText = "";

        if (isFire)
        {
            foreColor = Color.FromArgb(67, 74, 84);
            questionText = "Не срочные обращения берутся в порядке живой очереди.\nВы уверены, что хотите убрать срочность?";
        }
        else
        {
            foreColor = Color.FromArgb(16, 20, 27);
            questionText = "Срочные обращения берутся в первую очередь. Но помните, что при пренебрежение этим признаком мы начнем его игнорировать у Ваших обращений!\nВы уверены, что хотите отметить срочность?";

        }

        var check = MessageBox.Show(questionText, "Установка срочности обращения", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (check == DialogResult.Yes)
        {
            guna2Button3.ForeColor = foreColor;
            guna2Button3.Font = new Font("Segoe UI Emoji", 15f, !isFire ? FontStyle.Bold : FontStyle.Regular);
            isFire = !isFire;
        }
    }

    private void btnHistory_Click(object sender, EventArgs e)
    {
        DialogHistory form = new(_sendToBack, clientRepository: _clientRepository);
        form.Show();
    }

    private void btnLk_Click(object sender, EventArgs e)
    {
        DialogPartnerInfo form = new(_sendToBack);
        form.Show();
    }

    private async void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        await UpdateTiketsInfo();
    }

    private void guna2PictureBox1_Click(object sender, EventArgs e)
    {
        if (bytesImage is not null)
        {
            var tempFilePath = Path.GetTempFileName() + ".jpg";

            File.WriteAllBytes(tempFilePath, bytesImage);

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

    private async void guna2Button1_Click(object sender, EventArgs e)
    {
        await UpdateTiketsInfo();
    }
}
