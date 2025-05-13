using Guna.UI2.WinForms;
using YouKassaAssistant.UI.Domain;
using YouKassaAssistant.UI.FormDialog;
using YouKassaAssistant.UI.Infrastructure.Repositories;

namespace YouKassaAssistant.UI.UseCase;

class UseCaseGenerateListTikets
{
    private static List<Tikets> tikets = [];
    private static List<Worker> worker = [];

    public static async Task GenerateElementTikets(FlowLayoutPanel flowLayoutPanel, CreateConnectionToBack _sendToBack, string filter, bool isReadOnly, ClientRepository clientRepository = null, WorkerRepository workerRepository = null)
    {
        flowLayoutPanel.Controls.Clear();

        if (CurrentUser.Position is "")
        {
            tikets = await clientRepository.GetListTiketsAsync(filter);
        }
        else
        {
            tikets = await workerRepository.GetListTiketsAsync(filter);
            worker = await workerRepository.GetListWorkerAsync();
        }

        foreach (var item in tikets)
        {
            var element = new TiketsPanel(item, worker, workerRepository);

            element.CheckButton.Click += (s, e) =>
            {
                DialogTikets form = new(_sendToBack, item, isReadOnly, clientRepository, workerRepository);
                form.Show();
            };

            flowLayoutPanel.Controls.Add(element);
        }
    }
}