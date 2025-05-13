using Guna.UI2.WinForms;
using System.ComponentModel;
using YouKassaAssistant.UI.Domain;
using YouKassaAssistant.UI.Infrastructure.Repositories;

namespace YouKassaAssistant.UI;

public class TiketsPanel : Guna2Panel
{
    private Tikets tikets;
    private WorkerRepository _workerRepository;
    private List<Worker> _workers;

    private bool isChecked = false;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2HtmlLabel ThemeLabel { get; private set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2HtmlLabel DescriptionLabel { get; private set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2HtmlLabel AboutInfoLabel { get; private set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2HtmlLabel PriceLabel { get; private set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2HtmlLabel CheckedLabel { get; private set; }


    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2Button CheckButton { get; private set; }
    
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2Button FireButton { get; private set; }


    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2RatingStar RatingStarCheked { get; private set; }


    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2Panel BorderPanel { get; private set; }


    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2ComboBox WorkerComboBox { get; private set; }


    [DefaultValue("")]
    public Tikets TiketsInfo
    {
        get => tikets;
        set
        {
            if (tikets != value)
            {
                tikets = value;
            }
        }
    }

    public TiketsPanel()
    {
        InitializeComponent();
    }

    public TiketsPanel(Tikets order, List<Worker> workers, WorkerRepository workerRepository = null) : this()
    {
        _workerRepository = workerRepository;
        _workers = workers;
        tikets = order;

        UpdateInfoOrderPanel();
    }

    public void UpdateInfoOrderPanel()
    {
        ThemeLabel.Text = $"Тема: {tikets.Theme}";
        DescriptionLabel.Text = $"Описание: {(tikets.Description.Count() > 30 ? tikets.Description.Substring(0, 30) + "..." : tikets.Description)}";
        AboutInfoLabel.Text = $"Статус: {tikets.Status}; Поставлено: {tikets.DateCreate:g}";
        PriceLabel.Text = $"Цена: {(tikets.Price == -1 ? "не определена" : tikets.Price)}";

        RatingStarCheked.Value = tikets.Score;

        CheckedLabel.Visible = tikets.IsVisible;

        FireButton.Visible = tikets.IsFire;

        if (CurrentUser.Position is "админ")
        {
            CheckButton.Visible = false;
            WorkerComboBox.Visible = true;
            WorkerComboBox.Items.AddRange(_workers.ToArray());
            WorkerComboBox.DisplayMember = "FirstName";

            if (tikets.WorkerId > 0)
                WorkerComboBox.SelectedItem = _workers.First(x => x.WorkerId == tikets.WorkerId);

            WorkerComboBox.Enabled = tikets.Status is not "завершено";

            isChecked = true;
        }
    }

    private void InitializeComponent()
    {
        Location = new Point(3, 3);
        Size = new Size(465, 198);

        PriceLabel = new Guna2HtmlLabel();
        PriceLabel.BackColor = Color.Transparent;
        PriceLabel.Font = new Font("Segoe UI", 12F);
        PriceLabel.Location = new Point(7, 116);
        PriceLabel.Size = new Size(128, 23);
        PriceLabel.Text = "Цена: нет оценки";
 
        FireButton = new Guna2Button();
        FireButton.Anchor = AnchorStyles.Top;
        FireButton.BackColor = Color.Transparent;
        FireButton.BorderRadius = 5;
        FireButton.DisabledState.BorderColor = Color.DarkGray;
        FireButton.DisabledState.CustomBorderColor = Color.DarkGray;
        FireButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        FireButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        FireButton.FillColor = Color.Transparent;
        FireButton.Font = new Font("Segoe UI Emoji", 15F);
        FireButton.ForeColor = Color.FromArgb(67, 74, 84);
        FireButton.Location = new Point(392, 25);
        FireButton.PressedColor = Color.Transparent;
        FireButton.HoverState.FillColor = Color.Transparent;
        FireButton.Size = new Size(70, 39);
        FireButton.Text = "🔥";

        RatingStarCheked = new Guna2RatingStar();
        RatingStarCheked.Location = new Point(7, 152);
        RatingStarCheked.RatingColor = Color.FromArgb(16, 20, 27);
        RatingStarCheked.Size = new Size(172, 40);
        RatingStarCheked.ReadOnly = true;

        CheckedLabel = new Guna2HtmlLabel();
        CheckedLabel.BackColor = Color.Transparent;
        CheckedLabel.Font = new Font("Segoe UI", 10F);
        CheckedLabel.Location = new Point(375, 127);
        CheckedLabel.Size = new Size(87, 19);
        CheckedLabel.Text = "Не прочитано";

        CheckButton = new Guna2Button();
        CheckButton.Anchor = AnchorStyles.Top;
        CheckButton.BackColor = Color.Transparent;
        CheckButton.BorderRadius = 5;
        CheckButton.DisabledState.BorderColor = Color.DarkGray;
        CheckButton.DisabledState.CustomBorderColor = Color.DarkGray;
        CheckButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        CheckButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        CheckButton.FillColor = Color.FromArgb(16, 20, 27);
        CheckButton.Font = new Font("Segoe UI", 9F);
        CheckButton.ForeColor = Color.White;
        CheckButton.Location = new Point(310, 152);
        CheckButton.Size = new Size(152, 40);
        CheckButton.Text = "Просмотреть";

        WorkerComboBox = new Guna2ComboBox();
        WorkerComboBox.Anchor = AnchorStyles.Top;
        WorkerComboBox.BackColor = Color.Transparent;
        WorkerComboBox.Font = new Font("Segoe UI", 9F);
        WorkerComboBox.ForeColor = Color.White;
        WorkerComboBox.Location = new Point(310, 152);
        WorkerComboBox.Size = new Size(152, 40);
        WorkerComboBox.BorderColor = Color.Transparent;
        WorkerComboBox.BorderRadius = 5;
        WorkerComboBox.DisplayMember = "1";
        WorkerComboBox.DrawMode = DrawMode.OwnerDrawFixed;
        WorkerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        WorkerComboBox.FillColor = Color.FromArgb(16, 20, 27);
        WorkerComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
        WorkerComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
        WorkerComboBox.Font = new Font("Segoe UI", 10F);
        WorkerComboBox.ForeColor = Color.White;
        WorkerComboBox.ItemHeight = 30;
        WorkerComboBox.Location = new Point(310, 152);
        WorkerComboBox.Size = new Size(152, 40);
        WorkerComboBox.Visible = false;
        WorkerComboBox.SelectedIndexChanged += ChangeBox;

        AboutInfoLabel = new Guna2HtmlLabel();
        AboutInfoLabel.BackColor = Color.Transparent;
        AboutInfoLabel.Font = new Font("Segoe UI", 12F);
        AboutInfoLabel.Location = new Point(7, 87);
        AboutInfoLabel.Size = new Size(359, 23);
        AboutInfoLabel.TabIndex = 84;
        AboutInfoLabel.Text = "Статус: в работе; Поставлено: 2025:12:15 12:12:32";

        DescriptionLabel = new Guna2HtmlLabel();
        DescriptionLabel.BackColor = Color.Transparent;
        DescriptionLabel.Font = new Font("Segoe UI", 12F);
        DescriptionLabel.Location = new Point(7, 58);
        DescriptionLabel.Size = new Size(265, 23);
        DescriptionLabel.Text = "Описание: Что то там плохо считае...";

        ThemeLabel = new Guna2HtmlLabel();
        ThemeLabel.BackColor = Color.Transparent;
        ThemeLabel.Font = new Font("Segoe UI", 14F);
        ThemeLabel.Location = new Point(7, 25);
        ThemeLabel.Size = new Size(271, 27);
        ThemeLabel.Text = "Тема: во прикол";

        BorderPanel = new Guna2Panel();
        BorderPanel.BorderColor = Color.FromArgb(16, 20, 27);
        BorderPanel.BorderThickness = 3;
        BorderPanel.Location = new Point(10, 10);
        BorderPanel.Size = new Size(445, 5);
        BorderPanel.TabIndex = 91;

        Controls.Add(ThemeLabel);
        Controls.Add(DescriptionLabel);
        Controls.Add(AboutInfoLabel);
        Controls.Add(PriceLabel);
        Controls.Add(CheckedLabel);
        Controls.Add(RatingStarCheked);
        Controls.Add(FireButton);
        Controls.Add(CheckButton);
        Controls.Add(BorderPanel);
        Controls.Add(WorkerComboBox);
    }

    private void ChangeBox(object sender, EventArgs e)
    {
        if (sender is Guna2ComboBox guna2Combo && _workerRepository is not null && isChecked)
        {
            if (guna2Combo.SelectedItem is Worker selectedWorker)
            {
                var txt = "";

                if (tikets.WorkerId > 0)
                {
                    txt = $"Вы подтверждаете смену ответственного с {tikets.WorkerFullName} на {selectedWorker.LastName} {selectedWorker.FirstName}?";
                }
                else
                {
                    txt = $"Вы подтверждаете, что ответственным будет {selectedWorker.LastName} {selectedWorker.FirstName}?";
                }

                var results = MessageBox.Show(txt, "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (results is DialogResult.Yes)
                {
                    _workerRepository.UpdateWorkerTiketsAsync(tikets.Id, selectedWorker.WorkerId);
                    _workerRepository.UpdateStatusTiketsAsync(tikets.Id, "в работе");
                }
            }
        }
    }
}