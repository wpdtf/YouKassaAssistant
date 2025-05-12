using Microsoft.IdentityModel.Tokens;
using YouKassaAssistant.UI.Domain;
using YouKassaAssistant.UI.FormDialog;
using YouKassaAssistant.UI.UseCase;

namespace YouKassaAssistant.UI;

public partial class FormAdmin : Form
{
    private readonly CreateConnectionToBack _sendToBack;

    public FormAdmin(CreateConnectionToBack sendToBack)
    {
        InitializeComponent();
        _sendToBack = sendToBack;
    }

    private async void FormMain_Load(object sender, EventArgs e)
    {
        guna2ComboBox1.SelectedIndex = 0;

        await UpdateTiketsInfo();
        await UpdateStatisticWorkerAsync();
    }

    private async Task UpdateTiketsInfo()
    {
        var sortOrder = guna2ComboBox1.Text;

        await UseCaseGenerateListTikets.GenerateElementTikets(flowLayoutPanel1, _sendToBack, sortOrder, false);
    }

    private async Task UpdateStatisticWorkerAsync()
    {
        var workerList = new List<WorkerStatistic>();

        workerList.Add(new WorkerStatistic { WorkerId = 1, FirstName = "Стермененко Василий", CountStatistic = 12 });
        workerList.Add(new WorkerStatistic { WorkerId = 2, FirstName = "Афгустий Александр", CountStatistic = 5 });
        workerList.Add(new WorkerStatistic { WorkerId = 3, FirstName = "Петрищев Петр", CountStatistic = 10 });
        workerList.Add(new WorkerStatistic { WorkerId = 4, FirstName = "Формилявцев Артем", CountStatistic = 8 });

        guna2DataGridView1.DataSource = workerList;
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

    private void btnLk_Click(object sender, EventArgs e)
    {
        DialogStatisctics form = new(_sendToBack);
        form.Show();
    }

    private void guna2Button1_Click(object sender, EventArgs e)
    {

    }
}
