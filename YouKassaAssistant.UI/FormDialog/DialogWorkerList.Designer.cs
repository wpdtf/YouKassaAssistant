using Guna.UI2.WinForms;

namespace YouKassaAssistant.UI.FormDialog;

partial class DialogWorkerList
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogWorkerList));
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        panel2 = new Panel();
        guna2ControlBox1 = new Guna2ControlBox();
        guna2ControlBox2 = new Guna2ControlBox();
        label3 = new Label();
        guna2DragControl1 = new Guna2DragControl(components);
        guna2BorderlessForm1 = new Guna2BorderlessForm(components);
        guna2ImageButton1 = new Guna2ImageButton();
        guna2Button3 = new Guna2Button();
        guna2Button4 = new Guna2Button();
        guna2DataGridView1 = new Guna2DataGridView();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
        SuspendLayout();
        // 
        // panel2
        // 
        panel2.BackColor = Color.FromArgb(67, 74, 84);
        panel2.Controls.Add(guna2ControlBox1);
        panel2.Controls.Add(guna2ControlBox2);
        panel2.Controls.Add(label3);
        panel2.Dock = DockStyle.Top;
        panel2.ForeColor = SystemColors.ActiveCaption;
        panel2.Location = new Point(0, 0);
        panel2.Margin = new Padding(4);
        panel2.Name = "panel2";
        panel2.Size = new Size(910, 40);
        panel2.TabIndex = 27;
        // 
        // guna2ControlBox1
        // 
        guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        guna2ControlBox1.Animated = true;
        guna2ControlBox1.Cursor = Cursors.Hand;
        guna2ControlBox1.CustomizableEdges = customizableEdges1;
        guna2ControlBox1.FillColor = Color.FromArgb(67, 74, 84);
        guna2ControlBox1.IconColor = Color.White;
        guna2ControlBox1.Location = new Point(863, 6);
        guna2ControlBox1.Margin = new Padding(3, 2, 3, 2);
        guna2ControlBox1.Name = "guna2ControlBox1";
        guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
        guna2ControlBox1.Size = new Size(35, 30);
        guna2ControlBox1.TabIndex = 21;
        guna2ControlBox1.Click += _btnCancel_Click;
        // 
        // guna2ControlBox2
        // 
        guna2ControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        guna2ControlBox2.Animated = true;
        guna2ControlBox2.Cursor = Cursors.Hand;
        guna2ControlBox2.CustomizableEdges = customizableEdges3;
        guna2ControlBox2.FillColor = Color.FromArgb(0, 0, 64);
        guna2ControlBox2.IconColor = Color.White;
        guna2ControlBox2.Location = new Point(1105, 5);
        guna2ControlBox2.Margin = new Padding(3, 2, 3, 2);
        guna2ControlBox2.Name = "guna2ControlBox2";
        guna2ControlBox2.ShadowDecoration.CustomizableEdges = customizableEdges4;
        guna2ControlBox2.Size = new Size(35, 30);
        guna2ControlBox2.TabIndex = 20;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
        label3.ForeColor = Color.White;
        label3.Location = new Point(10, 11);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(154, 20);
        label3.TabIndex = 17;
        label3.Text = "Список сотрудников";
        // 
        // guna2DragControl1
        // 
        guna2DragControl1.DockIndicatorTransparencyValue = 1D;
        guna2DragControl1.DragStartTransparencyValue = 1D;
        guna2DragControl1.TargetControl = panel2;
        guna2DragControl1.UseTransparentDrag = true;
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
        // guna2ImageButton1
        // 
        guna2ImageButton1.BackColor = Color.Transparent;
        guna2ImageButton1.CheckedState.ImageSize = new Size(64, 64);
        guna2ImageButton1.HoverState.ImageSize = new Size(64, 64);
        guna2ImageButton1.Image = (Image)resources.GetObject("guna2ImageButton1.Image");
        guna2ImageButton1.ImageOffset = new Point(0, 0);
        guna2ImageButton1.ImageRotate = 0F;
        guna2ImageButton1.Location = new Point(10, 46);
        guna2ImageButton1.Name = "guna2ImageButton1";
        guna2ImageButton1.PressedState.ImageSize = new Size(64, 64);
        guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges9;
        guna2ImageButton1.Size = new Size(73, 71);
        guna2ImageButton1.TabIndex = 96;
        // 
        // guna2Button3
        // 
        guna2Button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        guna2Button3.BackColor = Color.Transparent;
        guna2Button3.BorderRadius = 5;
        guna2Button3.CustomizableEdges = customizableEdges7;
        guna2Button3.DisabledState.BorderColor = Color.DarkGray;
        guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button3.FillColor = Color.FromArgb(16, 20, 27);
        guna2Button3.Font = new Font("Segoe UI", 9F);
        guna2Button3.ForeColor = Color.White;
        guna2Button3.Location = new Point(534, 77);
        guna2Button3.Name = "guna2Button3";
        guna2Button3.ShadowDecoration.CustomizableEdges = customizableEdges8;
        guna2Button3.Size = new Size(179, 40);
        guna2Button3.TabIndex = 114;
        guna2Button3.TabStop = false;
        guna2Button3.Text = "Добавить";
        guna2Button3.Click += guna2Button3_Click;
        // 
        // guna2Button4
        // 
        guna2Button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        guna2Button4.BackColor = Color.Transparent;
        guna2Button4.BorderRadius = 5;
        guna2Button4.CustomizableEdges = customizableEdges5;
        guna2Button4.DisabledState.BorderColor = Color.DarkGray;
        guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button4.FillColor = Color.FromArgb(16, 20, 27);
        guna2Button4.Font = new Font("Segoe UI", 9F);
        guna2Button4.ForeColor = Color.White;
        guna2Button4.Location = new Point(719, 77);
        guna2Button4.Name = "guna2Button4";
        guna2Button4.ShadowDecoration.CustomizableEdges = customizableEdges6;
        guna2Button4.Size = new Size(179, 40);
        guna2Button4.TabIndex = 115;
        guna2Button4.TabStop = false;
        guna2Button4.Text = "Обновить";
        guna2Button4.Click += guna2Button4_Click;
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
        guna2DataGridView1.Location = new Point(10, 124);
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
        guna2DataGridView1.Size = new Size(890, 663);
        guna2DataGridView1.TabIndex = 117;
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
        // DialogWorkerList
        // 
        AllowDrop = true;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(910, 800);
        Controls.Add(guna2DataGridView1);
        Controls.Add(guna2Button4);
        Controls.Add(guna2Button3);
        Controls.Add(guna2ImageButton1);
        Controls.Add(panel2);
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.None;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4);
        MinimizeBox = false;
        MinimumSize = new Size(910, 700);
        Name = "DialogWorkerList";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Регистрация";
        FormClosing += FormRegister_FormClosing;
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
        ResumeLayout(false);
    }
    private Panel panel2;
    private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    private Label label3;
    private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    private Guna2ImageButton guna2ImageButton1;
    private Guna2Button guna2Button4;
    private Guna2Button guna2Button3;
    private Guna2DataGridView guna2DataGridView1;
} 