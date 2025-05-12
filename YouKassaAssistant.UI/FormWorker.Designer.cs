using Guna.UI2.WinForms;

namespace YouKassaAssistant.UI;

partial class FormWorker
{
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWorker));
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        guna2BorderlessForm1 = new Guna2BorderlessForm(components);
        label3 = new Label();
        panel2 = new Panel();
        guna2ControlBox2 = new Guna2ControlBox();
        guna2ControlBox1 = new Guna2ControlBox();
        guna2DragControl1 = new Guna2DragControl(components);
        guna2Panel1 = new Guna2Panel();
        guna2ComboBox1 = new Guna2ComboBox();
        guna2ImageButton1 = new Guna2ImageButton();
        btnHistory = new Guna2Button();
        openFileDialog1 = new OpenFileDialog();
        flowLayoutPanel1 = new FlowLayoutPanel();
        guna2HtmlLabel3 = new Guna2HtmlLabel();
        panel2.SuspendLayout();
        guna2Panel1.SuspendLayout();
        SuspendLayout();
        // 
        // guna2BorderlessForm1
        // 
        guna2BorderlessForm1.AnimationInterval = 100;
        guna2BorderlessForm1.BorderRadius = 20;
        guna2BorderlessForm1.ContainerControl = this;
        guna2BorderlessForm1.DockIndicatorTransparencyValue = 1D;
        guna2BorderlessForm1.DragStartTransparencyValue = 1D;
        guna2BorderlessForm1.TransparentWhileDrag = true;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
        label3.ForeColor = Color.White;
        label3.Location = new Point(14, 14);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(146, 20);
        label3.TabIndex = 17;
        label3.Text = "Кассовый асситент";
        // 
        // panel2
        // 
        panel2.BackColor = Color.FromArgb(67, 74, 84);
        panel2.Controls.Add(guna2ControlBox2);
        panel2.Controls.Add(guna2ControlBox1);
        panel2.Controls.Add(label3);
        panel2.Dock = DockStyle.Top;
        panel2.Location = new Point(0, 0);
        panel2.Margin = new Padding(4);
        panel2.Name = "panel2";
        panel2.Size = new Size(500, 40);
        panel2.TabIndex = 15;
        // 
        // guna2ControlBox2
        // 
        guna2ControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        guna2ControlBox2.Animated = true;
        guna2ControlBox2.Cursor = Cursors.Hand;
        guna2ControlBox2.CustomizableEdges = customizableEdges8;
        guna2ControlBox2.FillColor = Color.FromArgb(16, 20, 27);
        guna2ControlBox2.IconColor = Color.White;
        guna2ControlBox2.Location = new Point(451, 5);
        guna2ControlBox2.Margin = new Padding(3, 2, 3, 2);
        guna2ControlBox2.Name = "guna2ControlBox2";
        guna2ControlBox2.ShadowDecoration.CustomizableEdges = customizableEdges9;
        guna2ControlBox2.Size = new Size(35, 30);
        guna2ControlBox2.TabIndex = 19;
        guna2ControlBox2.Click += guna2ControlBox2_Click;
        // 
        // guna2ControlBox1
        // 
        guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        guna2ControlBox1.Animated = true;
        guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
        guna2ControlBox1.Cursor = Cursors.Hand;
        guna2ControlBox1.CustomizableEdges = customizableEdges10;
        guna2ControlBox1.FillColor = Color.FromArgb(16, 20, 27);
        guna2ControlBox1.IconColor = Color.White;
        guna2ControlBox1.Location = new Point(412, 5);
        guna2ControlBox1.Margin = new Padding(3, 2, 3, 2);
        guna2ControlBox1.Name = "guna2ControlBox1";
        guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges11;
        guna2ControlBox1.Size = new Size(35, 30);
        guna2ControlBox1.TabIndex = 18;
        // 
        // guna2DragControl1
        // 
        guna2DragControl1.DockIndicatorTransparencyValue = 1D;
        guna2DragControl1.DragStartTransparencyValue = 1D;
        guna2DragControl1.TargetControl = panel2;
        guna2DragControl1.UseTransparentDrag = true;
        // 
        // guna2Panel1
        // 
        guna2Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        guna2Panel1.Controls.Add(guna2ComboBox1);
        guna2Panel1.Controls.Add(guna2ImageButton1);
        guna2Panel1.Controls.Add(btnHistory);
        guna2Panel1.CustomizableEdges = customizableEdges6;
        guna2Panel1.FillColor = Color.FromArgb(67, 74, 84);
        guna2Panel1.Location = new Point(0, 40);
        guna2Panel1.Name = "guna2Panel1";
        guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges7;
        guna2Panel1.Size = new Size(500, 60);
        guna2Panel1.TabIndex = 16;
        // 
        // guna2ComboBox1
        // 
        guna2ComboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        guna2ComboBox1.BackColor = Color.Transparent;
        guna2ComboBox1.BorderColor = Color.Transparent;
        guna2ComboBox1.BorderRadius = 5;
        guna2ComboBox1.CustomizableEdges = customizableEdges1;
        guna2ComboBox1.DisplayMember = "1";
        guna2ComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
        guna2ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        guna2ComboBox1.FillColor = Color.FromArgb(16, 20, 27);
        guna2ComboBox1.FocusedColor = Color.FromArgb(94, 148, 255);
        guna2ComboBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
        guna2ComboBox1.Font = new Font("Segoe UI", 10F);
        guna2ComboBox1.ForeColor = Color.White;
        guna2ComboBox1.ItemHeight = 30;
        guna2ComboBox1.Items.AddRange(new object[] { "сортировка по статусу", "сортировка важности" });
        guna2ComboBox1.Location = new Point(268, 9);
        guna2ComboBox1.Name = "guna2ComboBox1";
        guna2ComboBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
        guna2ComboBox1.Size = new Size(218, 36);
        guna2ComboBox1.TabIndex = 73;
        // 
        // guna2ImageButton1
        // 
        guna2ImageButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        guna2ImageButton1.BackColor = Color.FromArgb(67, 74, 84);
        guna2ImageButton1.CheckedState.ImageSize = new Size(64, 64);
        guna2ImageButton1.HoverState.ImageSize = new Size(64, 64);
        guna2ImageButton1.Image = (Image)resources.GetObject("guna2ImageButton1.Image");
        guna2ImageButton1.ImageOffset = new Point(0, 0);
        guna2ImageButton1.ImageRotate = 0F;
        guna2ImageButton1.Location = new Point(3, 3);
        guna2ImageButton1.Name = "guna2ImageButton1";
        guna2ImageButton1.PressedState.ImageSize = new Size(64, 64);
        guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges3;
        guna2ImageButton1.Size = new Size(73, 54);
        guna2ImageButton1.TabIndex = 17;
        // 
        // btnHistory
        // 
        btnHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        btnHistory.BackColor = Color.Transparent;
        btnHistory.BorderRadius = 5;
        btnHistory.CustomizableEdges = customizableEdges4;
        btnHistory.DisabledState.BorderColor = Color.DarkGray;
        btnHistory.DisabledState.CustomBorderColor = Color.DarkGray;
        btnHistory.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        btnHistory.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        btnHistory.FillColor = Color.FromArgb(16, 20, 27);
        btnHistory.Font = new Font("Segoe UI", 9F);
        btnHistory.ForeColor = Color.White;
        btnHistory.Location = new Point(110, 7);
        btnHistory.Name = "btnHistory";
        btnHistory.ShadowDecoration.CustomizableEdges = customizableEdges5;
        btnHistory.Size = new Size(152, 40);
        btnHistory.TabIndex = 70;
        btnHistory.Text = "История моих заявок";
        btnHistory.Click += btnHistory_Click;
        // 
        // openFileDialog1
        // 
        openFileDialog1.FileName = "openFileDialog1";
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        flowLayoutPanel1.AutoScroll = true;
        flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
        flowLayoutPanel1.Location = new Point(3, 139);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(493, 630);
        flowLayoutPanel1.TabIndex = 73;
        flowLayoutPanel1.WrapContents = false;
        // 
        // guna2HtmlLabel3
        // 
        guna2HtmlLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        guna2HtmlLabel3.BackColor = Color.Transparent;
        guna2HtmlLabel3.Font = new Font("Segoe UI", 14F);
        guna2HtmlLabel3.Location = new Point(3, 106);
        guna2HtmlLabel3.Name = "guna2HtmlLabel3";
        guna2HtmlLabel3.Size = new Size(154, 27);
        guna2HtmlLabel3.TabIndex = 81;
        guna2HtmlLabel3.Text = "Активные заявки:";
        // 
        // FormWorker
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(500, 781);
        Controls.Add(guna2HtmlLabel3);
        Controls.Add(flowLayoutPanel1);
        Controls.Add(guna2Panel1);
        Controls.Add(panel2);
        FormBorderStyle = FormBorderStyle.None;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4);
        MinimumSize = new Size(100, 100);
        Name = "FormWorker";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Ит заказы";
        Load += FormMain_Load;
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        guna2Panel1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label3;
    private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    private Guna.UI2.WinForms.Guna2Button btnHistory;
    private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
    private OpenFileDialog openFileDialog1;
    private FlowLayoutPanel flowLayoutPanel1;
    private Guna2HtmlLabel guna2HtmlLabel3;
}

