using Microsoft.IdentityModel.Tokens;
using YouKassaAssistant.UI.Domain;
using YouKassaAssistant.UI.FormDialog;
using YouKassaAssistant.UI.UseCase;

namespace YouKassaAssistant.UI;

public partial class FormWorker : Form
{
    private readonly CreateConnectionToBack _sendToBack;

    public FormWorker(CreateConnectionToBack sendToBack)
    {
        InitializeComponent();
        _sendToBack = sendToBack;
    }

    private async void FormMain_Load(object sender, EventArgs e)
    {
        guna2ComboBox1.SelectedIndex = 0;

        await UpdateTiketsInfo();
    }

    private async Task UpdateTiketsInfo()
    {
        var sortOrder = guna2ComboBox1.Text;

        await UseCaseGenerateListTikets.GenerateElementTikets(flowLayoutPanel1, _sendToBack, sortOrder, false);
    }

    private void guna2ControlBox2_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void btnHistory_Click(object sender, EventArgs e)
    {
        DialogHistory form = new(_sendToBack);
        form.Show();
    }
}
