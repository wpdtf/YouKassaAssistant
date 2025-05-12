using Guna.UI2.WinForms;
using System.ComponentModel;
using YouKassaAssistant.UI.Domain;
using YouKassaAssistant.UI.Infrastructure.Repositories;

namespace YouKassaAssistant.UI;

public class MessageElement : Guna2Panel
{
    private MessageFromTikets messageInfo;
    private readonly ClientRepository _clientRepository;
    private readonly WorkerRepository _workerRepository;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2HtmlLabel DateSendLabel { get; private set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2HtmlLabel OptionalLabel { get; private set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2TextBox TextMessage { get; private set; }

    [DefaultValue("")]
    public MessageFromTikets MessageInfo
    {
        get => messageInfo;
        set
        {
            if (messageInfo != value)
            {
                messageInfo = value;
            }
        }
    }

    public MessageElement()
    {
        InitializeComponent();
    }

    public MessageElement(MessageFromTikets message, ClientRepository clientRepository = null, WorkerRepository workerRepository = null) : this()
    {
        MessageInfo = message;
        _clientRepository = clientRepository;
        _workerRepository = workerRepository;

        TextMessage.Text = MessageInfo.TextMessage;
        DateSendLabel.Text = $"{MessageInfo.DateSendMessage}";

        if (MessageInfo.NameCompanion != "")
        {
            OptionalLabel.ForeColor = Color.Black;
            OptionalLabel.Location = new Point(0, 70);
            OptionalLabel.Size = new Size(68, 17);
            OptionalLabel.Font = new Font("Segoe UI", 9F);
            OptionalLabel.Text = MessageInfo.NameCompanion;

            DateSendLabel.Location = new Point(0, 83);
            DateSendLabel.Size = new Size(87, 17);

            TextMessage.Location = new Point(0, 3);
            TextMessage.Size = new Size(339, 68);
        }

        UpdateInfoOrderPanel(message);
    }

    public void UpdateInfoOrderPanel(MessageFromTikets message)
    {
        if (MessageInfo.NameCompanion == "")
            OptionalLabel.Visible = !message.IsVisible;
    }

    private void InitializeComponent()
    {
        this.Anchor = AnchorStyles.Right;
        this.BorderColor = Color.Transparent;
        this.AutoSize = true;
        this.BorderRadius = 10;
        this.BorderThickness = 2;
        this.Location = new Point(0, 0);
        this.Size = new Size(460, 190);

        OptionalLabel = new Guna2HtmlLabel();
        OptionalLabel.BackColor = Color.Transparent;
        OptionalLabel.Font = new Font("Segoe UI Emoji", 30F);
        OptionalLabel.ForeColor = Color.FromArgb(16, 20, 27);
        OptionalLabel.Location = new Point(341, 55); 
        OptionalLabel.Size = new Size(19, 55); 
        OptionalLabel.Text = "•";

        DateSendLabel = new Guna2HtmlLabel();
        DateSendLabel.BackColor = Color.Transparent;
        DateSendLabel.Font = new Font("Segoe UI", 9F);
        DateSendLabel.ForeColor = Color.Black;
        DateSendLabel.Location = new Point(366, 77);
        DateSendLabel.Size = new Size(87, 17);

        TextMessage = new Guna2TextBox();
        TextMessage.BorderRadius = 12;
        TextMessage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        TextMessage.AutoSize = true;
        TextMessage.ScrollBars = ScrollBars.Vertical;
        TextMessage.Cursor = Cursors.IBeam;
        TextMessage.DisabledState.BorderColor = Color.FromArgb(16, 20, 27);
        TextMessage.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
        TextMessage.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
        TextMessage.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
        TextMessage.FocusedState.BorderColor = Color.FromArgb(16, 20, 27);
        TextMessage.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        TextMessage.ForeColor = Color.Black;
        TextMessage.HoverState.BorderColor = Color.FromArgb(16, 20, 27);
        TextMessage.Location = new Point(114, 3);
        TextMessage.Multiline = true;
        TextMessage.ReadOnly = true;
        TextMessage.SelectedText = "";
        TextMessage.Size = new Size(339, 68);

        // Добавление элементов
        this.Controls.Add(TextMessage);
        this.Controls.Add(OptionalLabel);
        this.Controls.Add(DateSendLabel);
    }

    public async Task UpdateInfoOrderAsync()
    {
        while (true)
        {
            await Task.Delay(5000);

            var result = new MessageFromTikets();

            if (CurrentUser.Position.Count() == 0)
                result = await _clientRepository.GetMessageAsync(MessageInfo.IdMessage);
            else
                result = await _clientRepository.GetMessageAsync(MessageInfo.IdMessage);

            UpdateInfoOrderPanel(result);
        }
    }
}