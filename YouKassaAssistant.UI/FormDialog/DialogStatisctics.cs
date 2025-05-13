using OfficeOpenXml;
using System.ComponentModel;
using YouKassaAssistant.UI.Domain;
using YouKassaAssistant.UI.Infrastructure.Repositories;

namespace YouKassaAssistant.UI.FormDialog;

public partial class DialogStatisctics : Form
{
    private readonly CreateConnectionToBack _sendToBack;
    private WorkerRepository _workerRepository;

    public DialogStatisctics(CreateConnectionToBack sendToBack, WorkerRepository workerRepository)
    {
        InitializeComponent();
        _sendToBack = sendToBack;
        _workerRepository = workerRepository;
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

    private async void guna2Button1_Click(object sender, EventArgs e)
    {
        guna2DataGridView1.DataSource = await _workerRepository.GetScoreSoftAsync();
    }

    private async void guna2Button4_Click(object sender, EventArgs e)
    {
        guna2DataGridView1.DataSource = await _workerRepository.GetStatisticsAsync();
    }

    private async void guna2Button3_Click(object sender, EventArgs e)
    {
        guna2DataGridView1.DataSource = await _workerRepository.GetScoreTiketsAsync();
    }

    private void guna2Button5_Click(object sender, EventArgs e)
    {
        var data = guna2DataGridView1.DataSource;

        if (data is null)
        {
            MessageBox.Show("Никакой из отчетов не выгружен!", "Выгрузка отчета", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (data is List<ReportResultTikets> or List<ReportScoreSoft>)
        {
            using var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Сохранить файл Excel";
            saveFileDialog.FileName = "Отчет.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                if (data is List<ReportResultTikets> salesReports)
                {
                    WriteToExcel(salesReports, filePath);
                }
                else if (data is List<ReportScoreSoft> popularityReports)
                {
                    WriteToExcel(popularityReports, filePath);
                }

                MessageBox.Show($"Данные успешно записаны в файл: {filePath}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    public void WriteToExcel<T>(IEnumerable<T> data, string filePath)
    {
        ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

        using var package = new ExcelPackage();
        var worksheet = package.Workbook.Worksheets.Add("Data");

        var properties = typeof(T).GetProperties();

        for (int i = 0; i < properties.Length; i++)
        {
            var displayNameAttribute = properties[i].GetCustomAttributes(typeof(DisplayNameAttribute), true)
                                        .FirstOrDefault() as DisplayNameAttribute;

            worksheet.Cells[1, i + 1].Value = displayNameAttribute?.DisplayName ?? properties[i].Name;
        }

        int row = 2;
        foreach (var item in data)
        {
            for (int col = 0; col < properties.Length; col++)
            {
                var value = properties[col].GetValue(item)?.ToString() ?? string.Empty;
                worksheet.Cells[row, col + 1].Value = value;
            }
            row++;
        }

        worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

        var fileInfo = new FileInfo(filePath);
        package.SaveAs(fileInfo);
    }
}