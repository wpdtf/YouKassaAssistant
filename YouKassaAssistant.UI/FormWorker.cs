using Microsoft.IdentityModel.Tokens;
using YouKassaAssistant.UI.Domain;
using YouKassaAssistant.UI.FormDialog;
using YouKassaAssistant.UI.Infrastructure.Repositories;
using YouKassaAssistant.UI.UseCase;

namespace YouKassaAssistant.UI;

public partial class FormWorker : Form
{
    private readonly CreateConnectionToBack _sendToBack;
    private WorkerRepository _workerRepository;

    public FormWorker(CreateConnectionToBack sendToBack, WorkerRepository workerRepository)
    {
        InitializeComponent();
        _sendToBack = sendToBack;
        _workerRepository = workerRepository;
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
        guna2ComboBox1.SelectedIndex = 0;
    }

    private async Task UpdateTiketsInfo()
    {
        var sortOrder = guna2ComboBox1.Text;

        await UseCaseGenerateListTikets.GenerateElementTikets(flowLayoutPanel1, _sendToBack, sortOrder, false, workerRepository: _workerRepository);
    }

    private void guna2ControlBox2_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void btnHistory_Click(object sender, EventArgs e)
    {
        DialogHistory form = new(_sendToBack, workerRepository: _workerRepository);
        form.Show();
    }

    private async void guna2Button1_Click(object sender, EventArgs e)
    {
        await UpdateTiketsInfo();
    }

    private async void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        await UpdateTiketsInfo();
    }
}
