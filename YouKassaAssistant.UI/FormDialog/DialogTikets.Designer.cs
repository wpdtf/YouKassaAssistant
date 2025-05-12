using Guna.UI2.WinForms;

namespace YouKassaAssistant.UI.FormDialog;

partial class DialogTikets
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
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges35 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges36 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges31 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges32 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges33 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges34 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogTikets));
        panel2 = new Panel();
        guna2ControlBox1 = new Guna2ControlBox();
        guna2ControlBox2 = new Guna2ControlBox();
        label3 = new Label();
        guna2DragControl1 = new Guna2DragControl(components);
        guna2BorderlessForm1 = new Guna2BorderlessForm(components);
        _Message = new Guna2TextBox();
        flowLayoutPanel1 = new FlowLayoutPanel();
        RatingStar = new Guna2RatingStar();
        Description = new Guna2TextBox();
        Theme = new Guna2TextBox();
        Images = new Guna2PictureBox();
        guna2Button1 = new Guna2Button();
        guna2Button2 = new Guna2Button();
        guna2HtmlLabel3 = new Guna2HtmlLabel();
        price = new Guna2TextBox();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)Images).BeginInit();
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
        guna2ControlBox1.CustomizableEdges = customizableEdges19;
        guna2ControlBox1.FillColor = Color.FromArgb(16, 20, 27);
        guna2ControlBox1.IconColor = Color.White;
        guna2ControlBox1.Location = new Point(863, 6);
        guna2ControlBox1.Margin = new Padding(3, 2, 3, 2);
        guna2ControlBox1.Name = "guna2ControlBox1";
        guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges20;
        guna2ControlBox1.Size = new Size(35, 30);
        guna2ControlBox1.TabIndex = 21;
        guna2ControlBox1.Click += _btnCancel_Click;
        // 
        // guna2ControlBox2
        // 
        guna2ControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        guna2ControlBox2.Animated = true;
        guna2ControlBox2.Cursor = Cursors.Hand;
        guna2ControlBox2.CustomizableEdges = customizableEdges21;
        guna2ControlBox2.FillColor = Color.FromArgb(0, 0, 64);
        guna2ControlBox2.IconColor = Color.White;
        guna2ControlBox2.Location = new Point(1105, 5);
        guna2ControlBox2.Margin = new Padding(3, 2, 3, 2);
        guna2ControlBox2.Name = "guna2ControlBox2";
        guna2ControlBox2.ShadowDecoration.CustomizableEdges = customizableEdges22;
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
        label3.Size = new Size(101, 20);
        label3.TabIndex = 17;
        label3.Text = "Обращение: ";
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
        // _Message
        // 
        _Message.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        _Message.AutoScroll = true;
        _Message.BorderRadius = 12;
        _Message.Cursor = Cursors.IBeam;
        _Message.CustomizableEdges = customizableEdges35;
        _Message.DefaultText = "";
        _Message.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
        _Message.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
        _Message.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
        _Message.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
        _Message.FocusedState.BorderColor = Color.FromArgb(0, 64, 0);
        _Message.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        _Message.ForeColor = Color.Black;
        _Message.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
        _Message.Location = new Point(553, 568);
        _Message.Multiline = true;
        _Message.Name = "_Message";
        _Message.PlaceholderText = "Сообщение...";
        _Message.ScrollBars = ScrollBars.Vertical;
        _Message.SelectedText = "";
        _Message.ShadowDecoration.CustomizableEdges = customizableEdges36;
        _Message.Size = new Size(345, 74);
        _Message.TabIndex = 63;
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        flowLayoutPanel1.AutoScroll = true;
        flowLayoutPanel1.FlowDirection = FlowDirection.BottomUp;
        flowLayoutPanel1.Location = new Point(395, 91);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(503, 471);
        flowLayoutPanel1.TabIndex = 64;
        flowLayoutPanel1.WrapContents = false;
        // 
        // RatingStar
        // 
        RatingStar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        RatingStar.Location = new Point(201, 522);
        RatingStar.Name = "RatingStar";
        RatingStar.RatingColor = Color.FromArgb(16, 20, 27);
        RatingStar.ReadOnly = true;
        RatingStar.Size = new Size(178, 40);
        RatingStar.TabIndex = 88;
        RatingStar.Value = 2F;
        RatingStar.ValueChanged += RatingStar_ValueChanged;
        // 
        // Description
        // 
        Description.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        Description.AutoScroll = true;
        Description.BorderRadius = 12;
        Description.Cursor = Cursors.IBeam;
        Description.CustomizableEdges = customizableEdges31;
        Description.DefaultText = "";
        Description.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
        Description.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
        Description.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
        Description.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
        Description.FocusedState.BorderColor = Color.FromArgb(0, 64, 0);
        Description.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        Description.ForeColor = Color.Black;
        Description.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
        Description.Location = new Point(10, 91);
        Description.Multiline = true;
        Description.Name = "Description";
        Description.PlaceholderText = "Сообщение...";
        Description.SelectedText = "";
        Description.ShadowDecoration.CustomizableEdges = customizableEdges32;
        Description.Size = new Size(369, 412);
        Description.TabIndex = 90;
        // 
        // Theme
        // 
        Theme.AutoScroll = true;
        Theme.BorderRadius = 12;
        Theme.Cursor = Cursors.IBeam;
        Theme.CustomizableEdges = customizableEdges33;
        Theme.DefaultText = "";
        Theme.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
        Theme.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
        Theme.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
        Theme.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
        Theme.FocusedState.BorderColor = Color.FromArgb(0, 64, 0);
        Theme.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        Theme.ForeColor = Color.Black;
        Theme.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
        Theme.Location = new Point(10, 47);
        Theme.Multiline = true;
        Theme.Name = "Theme";
        Theme.PlaceholderText = "Тема...";
        Theme.SelectedText = "";
        Theme.ShadowDecoration.CustomizableEdges = customizableEdges34;
        Theme.Size = new Size(369, 38);
        Theme.TabIndex = 89;
        Theme.WordWrap = false;
        // 
        // Images
        // 
        Images.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        Images.CustomizableEdges = customizableEdges29;
        Images.ImageRotate = 0F;
        Images.Location = new Point(12, 509);
        Images.Name = "Images";
        Images.ShadowDecoration.CustomizableEdges = customizableEdges30;
        Images.Size = new Size(183, 179);
        Images.SizeMode = PictureBoxSizeMode.Zoom;
        Images.TabIndex = 91;
        Images.TabStop = false;
        Images.Click += Images_Click;
        // 
        // guna2Button1
        // 
        guna2Button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        guna2Button1.BackColor = Color.Transparent;
        guna2Button1.BorderRadius = 5;
        guna2Button1.CustomizableEdges = customizableEdges27;
        guna2Button1.DisabledState.BorderColor = Color.DarkGray;
        guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button1.FillColor = Color.FromArgb(16, 20, 27);
        guna2Button1.Font = new Font("Segoe UI", 9F);
        guna2Button1.ForeColor = Color.White;
        guna2Button1.Location = new Point(758, 648);
        guna2Button1.Name = "guna2Button1";
        guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges28;
        guna2Button1.Size = new Size(140, 40);
        guna2Button1.TabIndex = 92;
        guna2Button1.Text = "Отправить";
        guna2Button1.Click += guna2Button1_Click;
        // 
        // guna2Button2
        // 
        guna2Button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        guna2Button2.BackColor = Color.Transparent;
        guna2Button2.BorderRadius = 5;
        guna2Button2.CustomizableEdges = customizableEdges25;
        guna2Button2.DisabledState.BorderColor = Color.DarkGray;
        guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button2.FillColor = Color.FromArgb(16, 20, 27);
        guna2Button2.Font = new Font("Segoe UI", 9F);
        guna2Button2.ForeColor = Color.White;
        guna2Button2.Location = new Point(201, 648);
        guna2Button2.Name = "guna2Button2";
        guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges26;
        guna2Button2.Size = new Size(178, 40);
        guna2Button2.TabIndex = 93;
        guna2Button2.Text = "Закрыть обращение";
        guna2Button2.Click += guna2Button2_Click;
        // 
        // guna2HtmlLabel3
        // 
        guna2HtmlLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        guna2HtmlLabel3.BackColor = Color.Transparent;
        guna2HtmlLabel3.Font = new Font("Segoe UI", 14F);
        guna2HtmlLabel3.Location = new Point(395, 58);
        guna2HtmlLabel3.Name = "guna2HtmlLabel3";
        guna2HtmlLabel3.Size = new Size(176, 27);
        guna2HtmlLabel3.TabIndex = 94;
        guna2HtmlLabel3.Text = "Чат по обращению:";
        // 
        // price
        // 
        price.AutoScroll = true;
        price.BorderRadius = 12;
        price.Cursor = Cursors.IBeam;
        price.CustomizableEdges = customizableEdges23;
        price.DefaultText = "";
        price.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
        price.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
        price.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
        price.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
        price.FocusedState.BorderColor = Color.FromArgb(0, 64, 0);
        price.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        price.ForeColor = Color.Black;
        price.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
        price.Location = new Point(201, 568);
        price.Multiline = true;
        price.Name = "price";
        price.PlaceholderText = "Оплата...";
        price.SelectedText = "";
        price.ShadowDecoration.CustomizableEdges = customizableEdges24;
        price.Size = new Size(178, 38);
        price.TabIndex = 95;
        price.Visible = false;
        price.WordWrap = false;
        // 
        // DialogTikets
        // 
        AllowDrop = true;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(910, 700);
        Controls.Add(price);
        Controls.Add(guna2HtmlLabel3);
        Controls.Add(guna2Button2);
        Controls.Add(guna2Button1);
        Controls.Add(Images);
        Controls.Add(Description);
        Controls.Add(Theme);
        Controls.Add(RatingStar);
        Controls.Add(flowLayoutPanel1);
        Controls.Add(_Message);
        Controls.Add(panel2);
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.None;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4);
        MinimizeBox = false;
        MinimumSize = new Size(910, 700);
        Name = "DialogTikets";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Регистрация";
        FormClosing += FormRegister_FormClosing;
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)Images).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
    private Panel panel2;
    private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    private Label label3;
    private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    private Guna2TextBox _Message;
    private FlowLayoutPanel flowLayoutPanel1;
    private Guna2RatingStar RatingStar;
    private Guna2TextBox Description;
    private Guna2TextBox Theme;
    private Guna2PictureBox Images;
    private Guna2Button guna2Button1;
    private Guna2Button guna2Button2;
    private Guna2HtmlLabel guna2HtmlLabel3;
    private Guna2TextBox price;
} 