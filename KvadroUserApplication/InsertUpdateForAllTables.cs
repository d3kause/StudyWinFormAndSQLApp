using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KvadroUserApplication
{
    public partial class InsertUpdateForAllTables : Form
    {
        bool update = false;
        public InsertUpdateForAllTables(List<string> columnNames, string tableName)
        {
            InitializeComponent();
            this.Text = "Добавление записи";
            groupBox1.Text = $"Добавление записи в таблицу {tableName}";
            if (tableName == "\"Работники в проектах\"" || tableName == "\"Информация о проектах\"")
                DataTextBox3.Mask = DataTextBox4.Mask = "00/00/0000";
            for (int i = 0; i<columnNames.Count;i++)
                (this.groupBox1.Controls.Find($"AboutDataLabel{i+1}", false).FirstOrDefault() as Label).Text = $"{columnNames[i]}:";
            for(int i = columnNames.Count+1; ;i++)
            {
                MaskedTextBox lastMaskedTextBox = this.groupBox1.Controls.Find($"DataTextBox{i}", false).FirstOrDefault() as MaskedTextBox;
                if (lastMaskedTextBox != null)
                {
                    lastMaskedTextBox.Dispose();
                    (this.groupBox1.Controls.Find($"AboutDataLabel{i}", false).FirstOrDefault() as Label).Dispose();
                }
                else
                    break;
            }
            this.Height = 40 + 36 * (1 + columnNames.Count) + 7 + 50;
            this.MinimumSize = this.MaximumSize = new System.Drawing.Size(this.Width, this.Height);
        }

        public InsertUpdateForAllTables(List<string> columnNames, List<string> dataList, string tableName)
        {
            InitializeComponent();
            this.Text = "Изменение записи";
            groupBox1.Text = $"Изменение записи в таблице {tableName}";
            DataTextBox1.ReadOnly = true;
            if (tableName == "\"Работники в проектах\"" || tableName == "\"Информация о проектах\"")
                DataTextBox3.Mask = DataTextBox4.Mask = "00/00/0000";
            if (tableName == "\"Работники в проектах\"")
                DataTextBox2.ReadOnly = true;
            for (int i = 0; i < columnNames.Count; i++)
            {
                (this.groupBox1.Controls.Find($"AboutDataLabel{i + 1}", false).FirstOrDefault() as Label).Text = $"{columnNames[i]}:";
                (this.groupBox1.Controls.Find($"DataTextBox{i + 1}", false).FirstOrDefault() as MaskedTextBox).Text = dataList[i].Replace(",",".");
            }
            for (int i = columnNames.Count + 1; ; i++)
            {
                MaskedTextBox lastMaskedTextBox = this.groupBox1.Controls.Find($"DataTextBox{i}", false).FirstOrDefault() as MaskedTextBox;
                if (lastMaskedTextBox != null)
                {
                    lastMaskedTextBox.Dispose();
                    (this.groupBox1.Controls.Find($"AboutDataLabel{i}", false).FirstOrDefault() as Label).Dispose();
                }
                else
                    break;
            }
            this.Height = 40 + 36*(1+columnNames.Count) + 7 + 50;
            this.MinimumSize = this.MaximumSize = new System.Drawing.Size(this.Width, this.Height);
            update = true;
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            string SQLcommand = "";
            if(!update)
            {
                switch(groupBox1.Text.Substring(28))
                {
                    case "\"Работники в проектах\"":
                        {
                            SQLcommand = "INSERT INTO ProjectsEmployees VALUES(@val1,@val2,@val3,@val4)";
                            break;
                        }
                    case "\"Информация о заказчиках\"":
                        {
                            SQLcommand = "INSERT INTO Customers VALUES(@val1,@val2,@val3,@val4,@val5,@val6,@val7)";
                            break;
                        }
                    case "\"Информация о проектах\"":
                        {
                            SQLcommand = "INSERT INTO Projects VALUES(@val1,@val2,@val3,@val4,@val5,@val6,@val7,@val8,@val9,@val10)";
                            break;
                        }
                    case "\"Информация о работниках\"":
                        {
                            SQLcommand = "INSERT INTO Employees VALUES(@val1,@val2,@val3,@val4,@val5,@val6,@val7,@val8,@val9,@val10,@val11,@val12,@val13)";

                            break;
                        }
                }
            }
            else
            {
                switch (groupBox1.Text.Substring(27))
                {
                    case "\"Работники в проектах\"":
                        {
                            SQLcommand = "UPDATE ProjectsEmployees SET employeeStart = @val3, employeeStop = @val4 WHERE projectId = @val1 and employeeId = @val2";
                            break;
                        }
                    case "\"Информация о заказчиках\"":
                        {
                            SQLcommand = "UPDATE Customers SET customerName = @val2, phone = @val3, bank = @val4, account = @val5, inn = @val6, adressCust = @val7 WHERE customerId = @val1";
                            break;
                        }
                    case "\"Информация о проектах\"":
                        {
                            SQLcommand = "UPDATE Projects SET projectName = @val2, projectStart = @val3, projectStop = @val4, chief = @val5, customer = @val6, cost = @val7, fioWorker = @val8, phoneWorker = @val9, bonusAll = @val10 WHERE projectId = @val1";
                            break;
                        }
                    case "\"Информация о работниках\"":
                        {
                            SQLcommand = "UPDATE Employees SET employeeName = @val2, address = @val3, district = @val4, experience = @val5, year = @val6, language = @val7, base = @val8, comment = @val9, salary = @val10, bonus = @val11, grossSalary = @val12, exempt = @val13 WHERE employeeId = @val1";
                            break;
                        }
                }
            }
            using (SqlConnection cn = new SqlConnection(SQLRequestsData.conStr))
            {
                try
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(SQLcommand, cn))
                    {
                        for (int i = 0; ; i++)
                        {
                            MaskedTextBox obj = this.groupBox1.Controls.Find($"DataTextBox{i+1}", false).FirstOrDefault() as MaskedTextBox;
                            if (obj != null)
                                cmd.Parameters.AddWithValue($"@val{i + 1}", obj.Text);
                            else
                                break;
                        }
                        cmd.ExecuteNonQuery();
                        if (update)
                            MessageBox.Show("Запись успешно обновлена!");
                        else
                            MessageBox.Show("Запись успешно добавлена!");
                        Close();
                    }
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
    }
}
