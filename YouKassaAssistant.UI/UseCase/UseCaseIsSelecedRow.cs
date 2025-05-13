using Guna.UI2.WinForms;

namespace YouKassaAssistant.UI.UseCase;

class UseCaseIsSelecedRow
{
    public static bool IsSelecedRow(Guna2DataGridView guna2DataGridView1)
    {
        if (guna2DataGridView1.SelectedRows.Count <= 0)
        {
            MessageBox.Show("Выберите запись для данного действия.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }
        return true;
    }
}
