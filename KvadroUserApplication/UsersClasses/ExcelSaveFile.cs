using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace KvadroUserApplication
{
    static class ExcelSaveFile
    {
        public static void ExcelSave(DataGridView dataGridView, string way)
        {
            Excel.Application excelapp = new Excel.Application();
            Excel.Workbook workbook = excelapp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;

            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                worksheet.Rows[1].Columns[i + 1] = dataGridView.Columns[i].HeaderText;
            }
            for (int i = 1; i < dataGridView.RowCount + 1; i++)
            {
                for (int j = 1; j < dataGridView.ColumnCount + 1; j++)
                {
                    worksheet.Rows[i + 1].Columns[j] = dataGridView.Rows[i - 1].Cells[j - 1].Value;
                }
            }
            excelapp.AlertBeforeOverwriting = false;
            workbook.SaveAs(@way);
            excelapp.Quit();
        }
    }
}
