using Guna.UI2.WinForms;

namespace YouKassaAssistant.UI.FormDialog;

partial class DialogHistory
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogHistory));
        panel2 = new Panel();
        guna2ControlBox1 = new Guna2ControlBox();
        guna2ControlBox2 = new Guna2ControlBox();
        label3 = new Label();
        guna2DragControl1 = new Guna2DragControl(components);
        guna2BorderlessForm1 = new Guna2BorderlessForm(components);
        flowLayoutPanel1 = new FlowLayoutPanel();
        panel2.SuspendLayout();
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
        panel2.Size = new Size(513, 40);
        panel2.TabIndex = 27;
        // 
        // guna2ControlBox1
        // 
        guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        guna2ControlBox1.Animated = true;
        guna2ControlBox1.Cursor = Cursors.Hand;
        guna2ControlBox1.CustomizableEdges = customizableEdges1;
        guna2ControlBox1.FillColor = Color.FromArgb(16, 20, 27);
        guna2ControlBox1.IconColor = Color.White;
        guna2ControlBox1.Location = new Point(466, 6);
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
        guna2ControlBox2.Location = new Point(708, 5);
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
        label3.Size = new Size(156, 20);
        label3.TabIndex = 17;
        label3.Text = "История обращений";
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
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        flowLayoutPanel1.AutoScroll = true;
        flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
        flowLayoutPanel1.Location = new Point(10, 47);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(493, 630);
        flowLayoutPanel1.TabIndex = 74;
        flowLayoutPanel1.WrapContents = false;
        // 
        // DialogHistory
        // 
        AllowDrop = true;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(513, 700);
        Controls.Add(flowLayoutPanel1);
        Controls.Add(panel2);
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.None;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4);
        MinimizeBox = false;
        MinimumSize = new Size(513, 700);
        Name = "DialogHistory";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Регистрация";
        FormClosing += FormRegister_FormClosing;
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
    }
    private Panel panel2;
    private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    private Label label3;
    private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    private FlowLayoutPanel flowLayoutPanel1;
} 