namespace YouKassaAssistant.UI.FormDialog;

public partial class DialogStatisctics : Form
{
    private readonly CreateConnectionToBack _sendToBack;

    public DialogStatisctics(CreateConnectionToBack sendToBack)
    {
        InitializeComponent();
        _sendToBack = sendToBack;
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

    private void btnSave_Click(object sender, EventArgs e)
    {
    }
}