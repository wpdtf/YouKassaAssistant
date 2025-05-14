using YouKassaAssistant.UI.Domain;
using YouKassaAssistant.UI.Infrastructure.Repositories;
using YouKassaAssistant.UI.UseCase;

namespace YouKassaAssistant.UI.FormDialog;

public partial class DialogWorkerList : Form
{
    private readonly CreateConnectionToBack _sendToBack;
    private WorkerRepository _workerRepository;

    public DialogWorkerList(CreateConnectionToBack sendToBack, WorkerRepository workerRepository)
    {
        InitializeComponent();
        _sendToBack = sendToBack;
        _workerRepository = workerRepository;
        UpdateListAsync();
    }

    public async Task UpdateListAsync()
    {
        guna2DataGridView1.DataSource = await _workerRepository.GetFullListWorkerAsync();
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

    private void guna2Button4_Click(object sender, EventArgs e)
    {
        if (!UseCaseIsSelecedRow.IsSelecedRow(guna2DataGridView1))
        {
            return;
        }

        var selectedRow = guna2DataGridView1.SelectedRows[0];
        var selectedModel = selectedRow.DataBoundItem;

        if (selectedModel is Worker selectedWorker)
        {
            DialogWorkerEdit form = new(_sendToBack, false, selectedWorker, _workerRepository, this);
            form.Show();
        }
    }

    private void guna2Button3_Click(object sender, EventArgs e)
    {
        DialogWorkerEdit form = new(_sendToBack, true, null, _workerRepository, this);
        form.Show();
    }
}