using Guna.UI2.WinForms;

namespace YouKassaAssistant.UI;

partial class FormAdmin
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
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        guna2BorderlessForm1 = new Guna2BorderlessForm(components);
        label3 = new Label();
        panel2 = new Panel();
        guna2ControlBox2 = new Guna2ControlBox();
        guna2ControlBox1 = new Guna2ControlBox();
        guna2DragControl1 = new Guna2DragControl(components);
        guna2Panel1 = new Guna2Panel();
        guna2ComboBox1 = new Guna2ComboBox();
        guna2ImageButton1 = new Guna2ImageButton();
        btnLk = new Guna2Button();
        btnHistory = new Guna2Button();
        guna2Panel2 = new Guna2Panel();
        guna2HtmlLabel2 = new Guna2HtmlLabel();
        openFileDialog1 = new OpenFileDialog();
        flowLayoutPanel1 = new FlowLayoutPanel();
        guna2HtmlLabel3 = new Guna2HtmlLabel();
        guna2Button1 = new Guna2Button();
        guna2DataGridView1 = new Guna2DataGridView();
        panel2.SuspendLayout();
        guna2Panel1.SuspendLayout();
        guna2Panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
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
        panel2.Size = new Size(959, 40);
        panel2.TabIndex = 15;
        // 
        // guna2ControlBox2
        // 
        guna2ControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        guna2ControlBox2.Animated = true;
        guna2ControlBox2.Cursor = Cursors.Hand;
        guna2ControlBox2.CustomizableEdges = customizableEdges14;
        guna2ControlBox2.FillColor = Color.FromArgb(16, 20, 27);
        guna2ControlBox2.IconColor = Color.White;
        guna2ControlBox2.Location = new Point(910, 5);
        guna2ControlBox2.Margin = new Padding(3, 2, 3, 2);
        guna2ControlBox2.Name = "guna2ControlBox2";
        guna2ControlBox2.ShadowDecoration.CustomizableEdges = customizableEdges15;
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
        guna2ControlBox1.CustomizableEdges = customizableEdges16;
        guna2ControlBox1.FillColor = Color.FromArgb(16, 20, 27);
        guna2ControlBox1.IconColor = Color.White;
        guna2ControlBox1.Location = new Point(871, 5);
        guna2ControlBox1.Margin = new Padding(3, 2, 3, 2);
        guna2ControlBox1.Name = "guna2ControlBox1";
        guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges17;
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
        guna2Panel1.Controls.Add(guna2Button1);
        guna2Panel1.Controls.Add(guna2ComboBox1);
        guna2Panel1.Controls.Add(guna2ImageButton1);
        guna2Panel1.Controls.Add(btnLk);
        guna2Panel1.Controls.Add(btnHistory);
        guna2Panel1.CustomizableEdges = customizableEdges12;
        guna2Panel1.FillColor = Color.FromArgb(67, 74, 84);
        guna2Panel1.Location = new Point(0, 40);
        guna2Panel1.Name = "guna2Panel1";
        guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges13;
        guna2Panel1.Size = new Size(959, 60);
        guna2Panel1.TabIndex = 16;
        // 
        // guna2ComboBox1
        // 
        guna2ComboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        guna2ComboBox1.BackColor = Color.Transparent;
        guna2ComboBox1.BorderColor = Color.Transparent;
        guna2ComboBox1.BorderRadius = 5;
        guna2ComboBox1.CustomizableEdges = customizableEdges5;
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
        guna2ComboBox1.Location = new Point(727, 9);
        guna2ComboBox1.Name = "guna2ComboBox1";
        guna2ComboBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
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
        guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges7;
        guna2ImageButton1.Size = new Size(73, 54);
        guna2ImageButton1.TabIndex = 17;
        // 
        // btnLk
        // 
        btnLk.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        btnLk.BackColor = Color.Transparent;
        btnLk.BorderRadius = 5;
        btnLk.CustomizableEdges = customizableEdges8;
        btnLk.DisabledState.BorderColor = Color.DarkGray;
        btnLk.DisabledState.CustomBorderColor = Color.DarkGray;
        btnLk.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        btnLk.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        btnLk.FillColor = Color.FromArgb(16, 20, 27);
        btnLk.Font = new Font("Segoe UI", 9F);
        btnLk.ForeColor = Color.White;
        btnLk.Location = new Point(411, 7);
        btnLk.Name = "btnLk";
        btnLk.ShadowDecoration.CustomizableEdges = customizableEdges9;
        btnLk.Size = new Size(152, 40);
        btnLk.TabIndex = 71;
        btnLk.Text = "Статистика";
        btnLk.Click += btnLk_Click;
        // 
        // btnHistory
        // 
        btnHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        btnHistory.BackColor = Color.Transparent;
        btnHistory.BorderRadius = 5;
        btnHistory.CustomizableEdges = customizableEdges10;
        btnHistory.DisabledState.BorderColor = Color.DarkGray;
        btnHistory.DisabledState.CustomBorderColor = Color.DarkGray;
        btnHistory.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        btnHistory.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        btnHistory.FillColor = Color.FromArgb(16, 20, 27);
        btnHistory.Font = new Font("Segoe UI", 9F);
        btnHistory.ForeColor = Color.White;
        btnHistory.Location = new Point(253, 7);
        btnHistory.Name = "btnHistory";
        btnHistory.ShadowDecoration.CustomizableEdges = customizableEdges11;
        btnHistory.Size = new Size(152, 40);
        btnHistory.TabIndex = 70;
        btnHistory.Text = "История заявок";
        btnHistory.Click += btnHistory_Click;
        // 
        // guna2Panel2
        // 
        guna2Panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        guna2Panel2.Controls.Add(guna2DataGridView1);
        guna2Panel2.Controls.Add(guna2HtmlLabel2);
        guna2Panel2.CustomizableEdges = customizableEdges1;
        guna2Panel2.FillColor = Color.White;
        guna2Panel2.Location = new Point(3, 103);
        guna2Panel2.Name = "guna2Panel2";
        guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges2;
        guna2Panel2.Size = new Size(443, 666);
        guna2Panel2.TabIndex = 72;
        // 
        // guna2HtmlLabel2
        // 
        guna2HtmlLabel2.BackColor = Color.Transparent;
        guna2HtmlLabel2.Font = new Font("Segoe UI", 14F);
        guna2HtmlLabel2.Location = new Point(11, 3);
        guna2HtmlLabel2.Name = "guna2HtmlLabel2";
        guna2HtmlLabel2.Size = new Size(185, 27);
        guna2HtmlLabel2.TabIndex = 80;
        guna2HtmlLabel2.Text = "Список сотрудников:";
        // 
        // openFileDialog1
        // 
        openFileDialog1.FileName = "openFileDialog1";
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        flowLayoutPanel1.AutoScroll = true;
        flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
        flowLayoutPanel1.Location = new Point(452, 139);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(493, 630);
        flowLayoutPanel1.TabIndex = 73;
        flowLayoutPanel1.WrapContents = false;
        // 
        // guna2HtmlLabel3
        // 
        guna2HtmlLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        guna2HtmlLabel3.BackColor = Color.Transparent;
        guna2HtmlLabel3.Font = new Font("Segoe UI", 14F);
        guna2HtmlLabel3.Location = new Point(452, 106);
        guna2HtmlLabel3.Name = "guna2HtmlLabel3";
        guna2HtmlLabel3.Size = new Size(154, 27);
        guna2HtmlLabel3.TabIndex = 81;
        guna2HtmlLabel3.Text = "Активные заявки:";
        // 
        // guna2Button1
        // 
        guna2Button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        guna2Button1.BackColor = Color.Transparent;
        guna2Button1.BorderRadius = 5;
        guna2Button1.CustomizableEdges = customizableEdges3;
        guna2Button1.DisabledState.BorderColor = Color.DarkGray;
        guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button1.FillColor = Color.FromArgb(16, 20, 27);
        guna2Button1.Font = new Font("Segoe UI", 9F);
        guna2Button1.ForeColor = Color.White;
        guna2Button1.Location = new Point(569, 7);
        guna2Button1.Name = "guna2Button1";
        guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
        guna2Button1.Size = new Size(152, 40);
        guna2Button1.TabIndex = 74;
        guna2Button1.Text = "Сотрудники";
        guna2Button1.Click += guna2Button1_Click;
        // 
        // guna2DataGridView1
        // 
        guna2DataGridView1.AllowUserToAddRows = false;
        guna2DataGridView1.AllowUserToDeleteRows = false;
        guna2DataGridView1.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = Color.White;
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
        dataGridViewCellStyle1.ForeColor = Color.Black;
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(67, 74, 84);
        dataGridViewCellStyle1.SelectionForeColor = Color.White;
        guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        guna2DataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        guna2DataGridView1.BackgroundColor = Color.WhiteSmoke;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(67, 74, 84);
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F);
        dataGridViewCellStyle2.ForeColor = Color.White;
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(67, 74, 84);
        dataGridViewCellStyle2.SelectionForeColor = Color.White;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        guna2DataGridView1.ColumnHeadersHeight = 40;
        guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
        guna2DataGridView1.Cursor = Cursors.Hand;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.White;
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 11.25F);
        dataGridViewCellStyle3.ForeColor = Color.Black;
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(67, 74, 84);
        dataGridViewCellStyle3.SelectionForeColor = Color.White;
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
        guna2DataGridView1.GridColor = Color.FromArgb(67, 74, 84);
        guna2DataGridView1.Location = new Point(4, 37);
        guna2DataGridView1.Margin = new Padding(4);
        guna2DataGridView1.Name = "guna2DataGridView1";
        guna2DataGridView1.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = SystemColors.Control;
        dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = Color.Black;
        dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(67, 74, 84);
        dataGridViewCellStyle4.SelectionForeColor = Color.White;
        dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
        guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        guna2DataGridView1.RowHeadersVisible = false;
        guna2DataGridView1.RowHeadersWidth = 51;
        guna2DataGridView1.Size = new Size(435, 625);
        guna2DataGridView1.TabIndex = 81;
        guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
        guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
        guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Black;
        guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(67, 74, 84);
        guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.White;
        guna2DataGridView1.ThemeStyle.BackColor = Color.WhiteSmoke;
        guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(67, 74, 84);
        guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(67, 74, 84);
        guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
        guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
        guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.Black;
        guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
        guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 40;
        guna2DataGridView1.ThemeStyle.ReadOnly = true;
        guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
        guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
        guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.Black;
        guna2DataGridView1.ThemeStyle.RowsStyle.Height = 25;
        guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(67, 74, 84);
        guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
        // 
        // FormAdmin
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(959, 781);
        Controls.Add(guna2HtmlLabel3);
        Controls.Add(flowLayoutPanel1);
        Controls.Add(guna2Panel2);
        Controls.Add(guna2Panel1);
        Controls.Add(panel2);
        FormBorderStyle = FormBorderStyle.None;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4);
        MinimumSize = new Size(940, 781);
        Name = "FormAdmin";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Ит заказы";
        Load += FormMain_Load;
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        guna2Panel1.ResumeLayout(false);
        guna2Panel2.ResumeLayout(false);
        guna2Panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
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
    private Guna.UI2.WinForms.Guna2Button btnLk;
    private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
    private OpenFileDialog openFileDialog1;
    private Guna2HtmlLabel guna2HtmlLabel2;
    private FlowLayoutPanel flowLayoutPanel1;
    private Guna2HtmlLabel guna2HtmlLabel3;
    private Guna2Button guna2Button1;
    private Guna2DataGridView guna2DataGridView1;
}

