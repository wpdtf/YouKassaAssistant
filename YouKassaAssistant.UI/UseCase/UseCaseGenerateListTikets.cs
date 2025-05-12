using YouKassaAssistant.UI.Domain;
using YouKassaAssistant.UI.FormDialog;
using YouKassaAssistant.UI.Infrastructure.Repositories;

namespace YouKassaAssistant.UI.UseCase;

class UseCaseGenerateListTikets
{
    private static List<Tikets> tikets = new();
    private static List<Worker> worker = new();

    public static async Task GenerateElementTikets(FlowLayoutPanel flowLayoutPanel, CreateConnectionToBack _sendToBack, string filter, bool isReadOnly, ClientRepository clientRepository = null, WorkerRepository workerRepository = null)
    {
        var random = new Random();

        if (CurrentUser.Position is "")
        {
            tikets = await clientRepository.GetListTiketsAsync(filter);
        }
        else
        {

        }

            flowLayoutPanel.Controls.Clear();

        foreach (var item in tikets)
        {
            var element = new TiketsPanel(item, worker);

            element.CheckButton.Click += (s, e) =>
            {
                DialogTikets form = new(_sendToBack, item, isReadOnly, clientRepository, workerRepository);
                form.Show();
            };

            flowLayoutPanel.Controls.Add(element);
        }
    }
}

/*
        worker.Add(new Worker
        {
            WorkerId = 1,
            FirstName = "qwe",
            LastName = "qweqweqwe",
            DateStart = DateTime.Now.AddDays(random.Next(-40, -20)).AddMinutes(random.Next(-40, -20)).AddHours(random.Next(-40, -20)).AddSeconds(random.Next(-40, -20)),
            Phone = "adasdasda",
            Position = "asdasdas"
        });

        worker.Add(new Worker
        {
            WorkerId = 1,
            FirstName = "asd",
            LastName = "asdasdasd",
            DateStart = DateTime.Now.AddDays(random.Next(-40, -20)).AddMinutes(random.Next(-40, -20)).AddHours(random.Next(-40, -20)).AddSeconds(random.Next(-40, -20)),
            Phone = "adasdasda",
            Position = "asdasdas"
        });

        worker.Add(new Worker
        {
            WorkerId = 2,
            FirstName = "zxc",
            LastName = "zxczxczxc",
            DateStart = DateTime.Now.AddDays(random.Next(-40, -20)).AddMinutes(random.Next(-40, -20)).AddHours(random.Next(-40, -20)).AddSeconds(random.Next(-40, -20)),
            Phone = "adasdasda",
            Position = "asdasdas"
        });

        worker.Add(new Worker
        {
            WorkerId = 3,
            FirstName = "rty",
            LastName = "rtyrtyrty",
            DateStart = DateTime.Now.AddDays(random.Next(-40, -20)).AddMinutes(random.Next(-40, -20)).AddHours(random.Next(-40, -20)).AddSeconds(random.Next(-40, -20)),
            Phone = "adasdasda",
            Position = "asdasdas"
        });

        worker.Add(new Worker
        {
            WorkerId = 4,
            FirstName = "fgh",
            LastName = "fghfghfgh",
            DateStart = DateTime.Now.AddDays(random.Next(-40, -20)).AddMinutes(random.Next(-40, -20)).AddHours(random.Next(-40, -20)).AddSeconds(random.Next(-40, -20)),
            Phone = "adasdasda",
            Position = "asdasdas"
        });

        worker.Add(new Worker
        {
            WorkerId = 5,
            FirstName = "vbn",
            LastName = "vbnvbnvbn",
            DateStart = DateTime.Now.AddDays(random.Next(-40, -20)).AddMinutes(random.Next(-40, -20)).AddHours(random.Next(-40, -20)).AddSeconds(random.Next(-40, -20)),
            Phone = "adasdasda",
            Position = "asdasdas"
        });
*/