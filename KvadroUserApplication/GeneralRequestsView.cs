using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KvadroUserApplication
{
    public partial class GeneralRequestsView : Form
    {
        public GeneralRequestsView(Button obj)
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Excel |*.xlsx";
            saveFileDialog1.DefaultExt = ".xlsx";
            saveFileDialog1.FileName = obj.Name.Replace("Button","");
            this.Text = $"Запрос: \"{obj.Text}\"";
            switch (obj.Name)
            {
                case "CurrentProjCostButton": // Текущие проекты по стоимости
                    {
                        FillDataGrid("SELECT projectId as 'ID', projectName as 'Название', projectStart as 'Начало', projectStop as 'Завершение', " +
                            "chief as 'Руководитель', customer as 'Заказчик',cost as 'Стоимость', fioWorker as 'Ответственный'," +
                            "phoneWorker as 'т. Ответственного', bonusAll as 'Премия' FROM Projects WHERE projectStop > GETDATE() " +
                            "ORDER BY cost, bonusAll");
                        break;
                    }
                case "ProjectsDetailButton": // Подробно о проектах
                    {
                        FillDataGrid("SELECT c.customerId as 'ID закачика', c.customerName as 'Название заказчика', c.phone as 'т. Заказчика', " +
                            "p.projectId as 'ID проекта', p.projectName as 'Название', p.projectStart as 'Начало', p.projectStop as 'Завершение', " +
                            "p.chief as 'Руководитель', p.fioWorker as 'Ответственный', p.phoneWorker as 'т. Ответственного', p.cost as 'Стоимость'" +
                            "FROM Customers as c, Projects as p " +
                            "WHERE c.customerId = p.customer " +
                            "ORDER BY p.projectStop DESC");
                        break;
                    }
                case "SumCustomerOrdersButton": // Заказчики по суммарной  стоимости проектов 11
                    {
                        FillDataGrid("SELECT employeeName as 'ФИО', district + ', ' + address as 'Адрес', " +
                            "Year(GETDATE()) - year as  'Возраст', experience as 'Опыт', CAST(CAST(grossSalary as int) as nvarchar) + ' руб.' as 'Полная ЗП'" +
                            ", CAST(CAST(ROUND(bonus * 100 / (salary + bonus), 0) as int) as nvarchar) + '%' as 'Доля премии в ЗП' " +
                            "FROM Employees ORDER BY employeeName");
                        break;
                    }
                case "ProjectsByTheDayButton": // Проекты по дням до завершения
                    {
                        this.Text = $"Представление: \"{obj.Text}\"";
                        FillDataGrid("SELECT p.projectId as 'ID', p.projectName as 'Название', p.fioWorker as 'Ответственный', " +
                            "p.bonusAll as 'Бонус за досрочное завершение' ,daysToEnd as 'Дней до завершения' FROM projectsDedlines as p ");
                        break;
                    }
                case "SumProjectsAtLastYearButton": // 	Выборка размера бонуса за досрочное завершение проекта и количества дней до его завершения
                    {
                        FillDataGrid("SELECT projectName as 'Название', chief as 'Руководитель', CAST(cost*(CAST(bonusAll as decimal)/100) as int) as 'Премия', DATEDIFF(DAY,GETDATE(),projectStop) 	as 'Дней до завершения' " +
                            "FROM Projects " +
                            "WHERE projectStop > GETDATE() and bonusAll > 0 " +
                            "ORDER BY 'Дней до завершения'");
                        break;
                    }
                case "AvgSalaryButton": // Средняя ЗП от Языка программирования
                    {
                        FillDataGrid("SELECT language as 'Язык программирования', CAST(avg(grossSalary) as int) as 'Средняя зар. пплата' " +
                            "FROM Employees " +
                            "GROUP BY language " +
                            "ORDER BY language");
                        break;
                    }
                case "AvgOrdersCostButton": // Средняя стоимость проектов у заказчиков
                    {
                        FillDataGrid("SELECT c.customerId as 'ID заказчика', c.customerName as 'Название', c.phone as 'Телефон', count(p.projectId) as 'Количество проектов' , avg(p.cost) as 'Средняя стоимость' " +
                            "FROM Customers as c, Projects as p " +
                            "WHERE c.customerId = p.customer " +
                            "GROUP BY c.customerId, c.customerName, c.phone " +
                            "ORDER BY c.customerId");
                        break;
                    }
            }
        }
        public GeneralRequestsView(Button obj, string param)
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Excel |*.xlsx";
            saveFileDialog1.DefaultExt = ".xlsx";
            saveFileDialog1.FileName = obj.Name.Replace("Button", "");
            this.Text = $"Запрос: \"{obj.Text}\"";
            if (obj.Name == "SearchEmployeeButton") // Поиск сотрудников
            {
                FillDataGrid($"SELECT e.employeeId as 'ID сотрудника', e.employeeName as 'ФИО', e.experience as 'Опыт работы', e.language as 'Язык программирования'" +
                    $"FROM Employees as e, ProjectsEmployees as p " +
                    $"WHERE e.employeeId = p.employeeId and p.projectId = {param}");
            }
            else // Проекты сотрудника (EmployeesProjectsButton)
            {
                FillDataGrid($"SELECT p.projectId as 'ID', p.projectName as 'Название', p.projectStart as 'Начало'," +
                    $"p.projectStop as 'Завершение', p.chief as 'Руководитель', p.customer as 'Заказчик', p.cost as 'Стоимость'," +
                    $"p.fioWorker as 'Ответственный', p.phoneWorker as 'т. Ответственного', p.bonusAll as 'Премия' " +
                    $"FROM Projects as p, ProjectsEmployees as e " +
                    $"WHERE p.projectId in (SELECT projectId FROM ProjectsEmployees " +
                    $"WHERE employeeId = {param})" +
                    $"GROUP BY p.projectId, p.projectName, p.projectStart, p.projectStop , p.chief , p.customer, p.cost," +
                    $"p.fioWorker , p.phoneWorker , p.bonusAll");
            }
        }

        private void FillDataGrid(string SQLRequest)
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(SQLRequest, SQLRequestsData.conStr);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "Request");
                dataGridView1.DataSource = ds.Tables["Request"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExcelExportButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                ExcelSaveFile.ExcelSave(dataGridView1,saveFileDialog1.FileName);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
