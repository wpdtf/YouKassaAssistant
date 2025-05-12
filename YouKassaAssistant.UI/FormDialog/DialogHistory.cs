using YouKassaAssistant.UI.Infrastructure.Repositories;
using YouKassaAssistant.UI.UseCase;

namespace YouKassaAssistant.UI.FormDialog;

public partial class DialogHistory : Form
{
    private readonly CreateConnectionToBack _sendToBack;
    private readonly ClientRepository _clientRepository;
    private readonly WorkerRepository _workerRepository;

    public DialogHistory(CreateConnectionToBack sendToBack, ClientRepository clientRepository = null, WorkerRepository workerRepository = null)
    {
        InitializeComponent();
        _sendToBack = sendToBack;
        _clientRepository = clientRepository;
        _workerRepository = workerRepository;

        UpdateListMessageAsync();
    }

    public async Task UpdateListMessageAsync()
    {
        await UseCaseGenerateListTikets.GenerateElementTikets(flowLayoutPanel1, _sendToBack, "закрытые", true, _clientRepository, _workerRepository);
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
}