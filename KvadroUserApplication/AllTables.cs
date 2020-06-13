using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KvadroUserApplication
{
    public partial class AllTables : Form
    {
        string tableName;
        public AllTables(Button obj, List<int> accesses)
        {
            InitializeComponent();
            tableName = obj.Name.Replace("Button", "");
            AccessLimitation(accesses);
            saveFileDialog1.Filter = "Excel |*.xlsx";
            saveFileDialog1.DefaultExt = ".xlsx";
            saveFileDialog1.FileName = tableName;
            FillTable();
        }

        private void AccessLimitation(List<int> accesses)
        {
            if(tableName == "Projects")
            {
                AddRecordButton.Enabled = accesses.Contains(8);
                EditRecordButton.Enabled = DeleteRecordButton.Enabled = accesses.Contains(9);
            }
            else if(tableName == "Customers")
            {
                AddRecordButton.Enabled = accesses.Contains(5);
                EditRecordButton.Enabled = DeleteRecordButton.Enabled = accesses.Contains(6);
            }
            else if(tableName == "ProjectsEmployees")
            {
                AddRecordButton.Enabled = accesses.Contains(14);
                EditRecordButton.Enabled = DeleteRecordButton.Enabled = accesses.Contains(15);
            }
            else
            {
                AddRecordButton.Enabled = accesses.Contains(11);
                EditRecordButton.Enabled = DeleteRecordButton.Enabled = accesses.Contains(12);
            }
        }

        private void FillTable()
        {
            string SQLcom = "";
            switch (tableName)
            {
                case "Projects":
                    {
                        SQLcom = $"SELECT projectId as 'ID', projectName as 'Название', projectStart as 'Начало', projectStop as 'Завершение', " +
                            $"chief as 'Руководитель', customer as 'Заказчик',cost as 'Стоимость', fioWorker as 'Ответственный'," +
                            $"phoneWorker as 'т. Ответственного', bonusAll as 'Премия' FROM Projects";
                        this.Text = "Просмотр таблицы \"Информация о проектах\"";
                        break;
                    }
                case "Customers":
                    {
                        SQLcom = "SELECT customerId as 'ID', customerName as 'Название', phone as 'Телефон', bank as 'Банк', account as 'Номер счета', inn as 'ИНН', adressCust as 'Адрес' FROM Customers";
                        this.Text = "Просмотр таблицы \"Информация о заказчиках\"";
                        break;
                    }
                case "ProjectsEmployees":
                    {
                        SQLcom = "SELECT projectId as 'ID проекта', employeeId as 'ID работника', employeeStart as 'Начало работы',employeeStop as 'Завершение работы' FROM ProjectsEmployees";
                        this.Text = "Просмотр таблицы \"Работники в проектах\"";
                        break;
                    }
                case "Employees":
                    {
                        SQLcom = "SELECT employeeId as 'ID', employeeName as 'ФИО', address as 'Адрес', district as 'Район', experience as 'Опыт работы'," +
                            "year as 'Год рождения',language as 'ЯП', base as 'ВУЗ', comment as 'Примечания', salary as 'ЗП', bonus as 'Премия', grossSalary as 'Полная ЗП', " +
                            "exempt as 'Льготы' FROM Employees";
                        this.Text = "Просмотр таблицы \"Информация о работниках\"";
                        break;
                    }
            }
            SqlDataAdapter dataAdapter = new SqlDataAdapter(SQLcom, SQLRequestsData.conStr);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "Tables");
            dataGridView1.DataSource = ds.Tables["Tables"].DefaultView;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddRecordButton_Click(object sender, EventArgs e)
        {
            List<string> columnNames = new List<string>();
            for(int i =0; i< dataGridView1.Columns.Count;i++)
                columnNames.Add(dataGridView1.Columns[i].HeaderText);
            InsertUpdateForAllTables obj = new InsertUpdateForAllTables(columnNames, this.Text.Remove(0,17));
            obj.ShowDialog();
            FillTable();
        }

        private void EditRecordButton_Click(object sender, EventArgs e)
        {
            List<string> columnNames = new List<string>();
            List<string> dataList = new List<string>();
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                columnNames.Add(dataGridView1.Columns[i].HeaderText);
                dataList.Add(dataGridView1.CurrentRow.Cells[i].Value.ToString());
            }
            InsertUpdateForAllTables obj = new InsertUpdateForAllTables(columnNames, dataList, this.Text.Remove(0, 17));
            obj.ShowDialog();
            FillTable();
        }

        private void DeleteRecordButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить текущую запись?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.No)
                return;
            string SQLcommand = "";
            switch(tableName)
            {
                case "Projects":
                    {
                        SQLcommand = $"DELETE FROM Projects WHERE projectId = {dataGridView1.CurrentRow.Cells[0].Value.ToString()}";
                        break;
                    }
                case "Customers":
                    {
                        SQLcommand = $"DELETE FROM Customers WHERE customerId = {dataGridView1.CurrentRow.Cells[0].Value.ToString()}";

                        break;
                    }
                case "ProjectsEmployees":
                    {
                        SQLcommand = $"DELETE FROM ProjectsEmployees WHERE projectId = {dataGridView1.CurrentRow.Cells[0].Value.ToString()} and employeeId = {dataGridView1.CurrentRow.Cells[1].Value.ToString()}";
                        break;
                    }
                case "Employees":
                    {
                        SQLcommand = $"DELETE FROM Employees WHERE employeeId = {dataGridView1.CurrentRow.Cells[0].Value.ToString()}";
                        break;
                    }
            }
            using (SqlConnection cn = new SqlConnection(SQLRequestsData.conStr))
            {
                try
                {
                    cn.Open();
                    SqlCommand myCommand = new SqlCommand(SQLcommand, cn);
                    myCommand.ExecuteNonQuery();
                    FillTable();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cn.Close();
                }
            }

        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                ExcelSaveFile.ExcelSave(dataGridView1, saveFileDialog1.FileName);
        }
    }
}
