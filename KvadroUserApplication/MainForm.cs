using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KvadroUserApplication
{
    public partial class MainForm : Form
    {
        List<int> accesses;
        string login;
        public MainForm(List<int> accesses, string fullName, string login)
        {
            InitializeComponent();
            this.accesses = accesses;
            AccessLimitation();
            this.accesses = accesses;
            this.login = login;
            this.Text += fullName;
        }

        private void AccessLimitation()
        {
            if (!accesses.Contains(1) && !accesses.Contains(2) && !accesses.Contains(3)) // Управление приложением
                AdminPage.Dispose();
            else
            {
                AddNewUserButton.Enabled = accesses.Contains(1);
                DeleteUserButton.Enabled = accesses.Contains(2);
                ChangeUserAccessButton.Enabled = accesses.Contains(3);
            }
            CustomersButton.Enabled = accesses.Contains(4);
            ProjectsButton.Enabled = accesses.Contains(7);
            EmployeesButton.Enabled = accesses.Contains(10);
            ProjectsEmployeesButton.Enabled = accesses.Contains(13);
            CurrentProjCostButton.Enabled = accesses.Contains(16);
            ProjectsDetailButton.Enabled = accesses.Contains(17);
            SumCustomerOrdersButton.Enabled = accesses.Contains(18);
            ProjectsByTheDayButton.Enabled = accesses.Contains(19);
            SumProjectsAtLastYearButton.Enabled = accesses.Contains(20);
            AvgSalaryButton.Enabled = accesses.Contains(21);
            AvgOrdersCostButton.Enabled = accesses.Contains(22);
            if(!accesses.Contains(23)) // Поиск сотрудниов проекта
            {
                SearchEmployeeButton.Enabled = false;
                SearchEmployeeTextBox.ReadOnly = true;
            }
            if(!accesses.Contains(24)) // Поиск проектов сотрудника
            {
                EmployeesProjectsButton.Enabled = false;
                EmployeesProjectsTextBox.ReadOnly = true;
            }
            if(!accesses.Contains(14)) // Добавление сотрудника в проект
            {
                AddEmployeeToProjectButton.Enabled = false;
                AddEmpToProjTextBox.ReadOnly = true;
                EmployeeIdTextBox.ReadOnly = true;
            }
            if(!accesses.Contains(9)) // Досрочное завершение проекта
            {
                EndTheProjectButton.Enabled = false;
                ProjectIdTextBox.ReadOnly = true;
            }
        }

        private void RequestsButton_Click(object sender, EventArgs e)
        {
            GeneralRequestsView obj;
            if ((sender as Button).Name == "EmployeesProjectsButton")
            {
                if (EmployeesProjectsTextBox.Text.Length == 0)
                {
                    MessageBox.Show("Введите необходимые данные!", "Выполнение запроса");
                    return;
                }
                (obj = new GeneralRequestsView(sender as Button, EmployeesProjectsTextBox.Text)).ShowDialog();
            }
            else if ((sender as Button).Name == "SearchEmployeeButton")
            {
                if (SearchEmployeeTextBox.Text.Length == 0)
                {
                    MessageBox.Show("Введите необходимые данные!", "Выполнение запроса");
                    return;
                }
                (obj = new GeneralRequestsView(sender as Button, SearchEmployeeTextBox.Text)).ShowDialog();
            }
            else
                try
                {
                    (obj = new GeneralRequestsView(sender as Button)).ShowDialog();
                }
                catch (ObjectDisposedException)
                {
                    // Пустое т. к. форма закрывается в контрукторе при данном запросе
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            SearchEmployeeTextBox.Clear();
            EmployeesProjectsTextBox.Clear();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowTableButton_Click(object sender, EventArgs e)
        {
            AllTables obj = new AllTables(sender as Button, accesses);
            obj.ShowDialog();
        }
        
        private void ProcedureExecution(string SQLcommand)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = SQLRequestsData.conStr;
                    try
                    {
                        cn.Open();
                        SqlCommand myCommand = new SqlCommand(SQLcommand, cn);
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show("Действие успешно выполнено!");
                        AddEmpToProjTextBox.Clear();
                        ProjectIdTextBox.Clear();
                        EmployeeIdTextBox.Clear();
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
            catch (Exception ex)
            {
                MessageBox.Show($"Неверный ввод!\nТекст ошибки:\n{ex.Message}", "Ошибка чтения данных");
            }
        }

        private void EndTheProjectButton_Click(object sender, EventArgs e)
        {
            if (ProjectIdTextBox.Text.Length == 0)
            {
                MessageBox.Show("Укажите id проекта!","Досрочное завершение проекта");
                return;
            }
            ProcedureExecution($"EXEC  EndProject @project = {ProjectIdTextBox.Text}");
        }

        private void AddEmployeeToProjectButton_Click(object sender, EventArgs e)
        {
            if (AddEmpToProjTextBox.Text.Length == 0 || EmployeeIdTextBox.Text.Length == 0)
            {
                MessageBox.Show("Заполнены не все поля!", "Добавление сотрудника в проект");
                return;
            }
            ProcedureExecution($"EXEC AddEmployeeToProject @employee = {EmployeeIdTextBox.Text}, @project = {AddEmpToProjTextBox.Text}");
        }

        private void ShowPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = RepeatPasswordTextBox.UseSystemPasswordChar = !ShowPassCheckBox.Checked;
        }

        private void AddNewUserButton_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text.Length == 0 || PasswordTextBox.Text.Length == 0 || RepeatPasswordTextBox.Text.Length==0 || FullNameTextBox.Text.Length == 0)
            { 
                MessageBox.Show("Заполните все необходимые поля!","Добавление нового пользователя");
                return;
            }
            if (!PasswordTextBox.Text.Equals(RepeatPasswordTextBox.Text))
            {
                MessageBox.Show("Введённые пароли не совпадают!", "Добавление нового пользователя");
                return;
            }
            using (SqlConnection cn = new SqlConnection(SQLRequestsData.conStr))
            {
                try
                {
                    cn.Open();
                    SqlCommand myCommand = new SqlCommand($"SELECT login FROM AuthorizationData WHERE login = '{LoginTextBox.Text}'", cn);
                    SqlDataReader dr = myCommand.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Пользователь с данным логином уже зарегистрирован!");
                        PasswordTextBox.Clear();
                        RepeatPasswordTextBox.Clear();
                        return;
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
            using (SqlConnection cn = new SqlConnection(SQLRequestsData.conStr))
            {
                try
                {
                    cn.Open();
                    string strSQL = $"INSERT INTO AuthorizationData VALUES('{LoginTextBox.Text}','{PasswordTextBox.Text}','{FullNameTextBox.Text}')";
                    (new SqlCommand(strSQL, cn)).ExecuteNonQuery();
                    UsersListbox.Items.Add(LoginTextBox.Text);
                    MessageBox.Show($"Пользователь с именем {LoginTextBox.Text} успешно зарегистрирован!");
                    LoginTextBox.Clear();
                    PasswordTextBox.Clear();
                    RepeatPasswordTextBox.Clear();
                    FullNameTextBox.Clear();
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

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            string checkUser = UsersListbox.SelectedItem.ToString().Replace(" ", "");
            if (checkUser == "admin" || checkUser == login)
            {
                MessageBox.Show("Вы не можете удалить этого пользователя!", "Удаление пользователя");
                return;
            }
            if (MessageBox.Show($"Удалить пользователя {checkUser}?", "Удаление пользователя", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.No)
                return;
            using (SqlConnection cn = new SqlConnection(SQLRequestsData.conStr))
            {
                try
                {
                    cn.Open();
                    string strSQL = "DELETE FROM AuthorizationData WHERE login = '" + UsersListbox.SelectedItem.ToString() + "'";
                    SqlCommand myCommand = new SqlCommand(strSQL, cn);
                    myCommand.ExecuteNonQuery();
                    UsersListbox.Items.RemoveAt(UsersListbox.SelectedIndex);
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

        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedTab == AdminPage)
            {
                UsersListbox.Items.Clear();
                using (SqlConnection cn = new SqlConnection(SQLRequestsData.conStr))
                {
                    try
                    {
                        cn.Open();
                        string strSQL = "SELECT login FROM AuthorizationData";
                        SqlCommand myCommand = new SqlCommand(strSQL, cn);
                        SqlDataReader dr = myCommand.ExecuteReader();
                        while (dr.Read())
                            UsersListbox.Items.Add(dr["login"].ToString());
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

        private void AboutProgramButton_Click(object sender, EventArgs e)
        {
            AboutProgram obj = new AboutProgram();
            obj.ShowDialog();
        }

        private void ChangeUserAccessButton_Click(object sender, EventArgs e)
        {
            if(UsersListbox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите пользователя!","Изменение прав доступа");
                return;
            }
            if (UsersListbox.SelectedItem.ToString() == "admin" || UsersListbox.SelectedItem.ToString() == login)
            {
                MessageBox.Show("Вы не можете изменить права этого пользователя!", "Изменение прав доступа");
                return;
            }
            UserRightsManagement obj = new UserRightsManagement(UsersListbox.SelectedItem.ToString());
            obj.ShowDialog();
        }
    }
}
