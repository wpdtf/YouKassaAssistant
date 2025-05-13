using YouKassaAssistant.UI.FormDialog;
using YouKassaAssistant.UI.Infrastructure.Repositories;
using YouKassaAssistant.UI.UseCase;

namespace YouKassaAssistant.UI;

public partial class FormAdmin : Form
{
    private readonly CreateConnectionToBack _sendToBack;
    private readonly WorkerRepository _workerRepository;

    public FormAdmin(CreateConnectionToBack sendToBack, WorkerRepository workerRepository)
    {
        InitializeComponent();
        _sendToBack = sendToBack;
        _workerRepository = workerRepository;
    }

    private async void FormMain_Load(object sender, EventArgs e)
    {
        await UpdateStatisticWorkerAsync();
        guna2ComboBox1.SelectedIndex = 0;
    }

    private async Task UpdateTiketsInfo()
    {
        var sortOrder = guna2ComboBox1.Text;

        await UseCaseGenerateListTikets.GenerateElementTikets(flowLayoutPanel1, _sendToBack, sortOrder, false, workerRepository: _workerRepository);
    }

    private async Task UpdateStatisticWorkerAsync()
    {
        guna2DataGridView1.DataSource = await _workerRepository.GetListWorkerStatisticAsync();
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

    private void btnLk_Click(object sender, EventArgs e)
    {
        DialogStatisctics form = new(_sendToBack, _workerRepository);
        form.Show();
    }

    private void guna2Button1_Click(object sender, EventArgs e)
    {
        DialogWorkerList form = new(_sendToBack, _workerRepository);
        form.Show();
    }

    private async void guna2Button2_Click(object sender, EventArgs e)
    {
        await UpdateTiketsInfo();
        await UpdateStatisticWorkerAsync();
    }

    private async void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        await UpdateTiketsInfo();
    }
}
