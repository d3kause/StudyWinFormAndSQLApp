namespace KvadroUserApplication
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.TablesPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.ProjectsEmployeesButton = new System.Windows.Forms.Button();
            this.EmployeesButton = new System.Windows.Forms.Button();
            this.ProjectsButton = new System.Windows.Forms.Button();
            this.CustomersButton = new System.Windows.Forms.Button();
            this.RequestsPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.EmployeesProjectsTextBox = new System.Windows.Forms.TextBox();
            this.EmployeesProjectsButton = new System.Windows.Forms.Button();
            this.SearchEmployeeButton = new System.Windows.Forms.Button();
            this.SearchEmployeeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AvgOrdersCostButton = new System.Windows.Forms.Button();
            this.AvgSalaryButton = new System.Windows.Forms.Button();
            this.ProjectsByTheDayButton = new System.Windows.Forms.Button();
            this.SumProjectsAtLastYearButton = new System.Windows.Forms.Button();
            this.SumCustomerOrdersButton = new System.Windows.Forms.Button();
            this.ProjectsDetailButton = new System.Windows.Forms.Button();
            this.CurrentProjCostButton = new System.Windows.Forms.Button();
            this.ProjectControlPage = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.EndTheProjectButton = new System.Windows.Forms.Button();
            this.ProjectIdTextBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.AddEmpToProjTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeIdTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AddEmployeeToProjectButton = new System.Windows.Forms.Button();
            this.AdminPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddNewUserButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ShowPassCheckBox = new System.Windows.Forms.CheckBox();
            this.RepeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.UsersListbox = new System.Windows.Forms.ListBox();
            this.ChangeUserAccessButton = new System.Windows.Forms.Button();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AboutProgramButton = new System.Windows.Forms.Button();
            this.MainTabControl.SuspendLayout();
            this.TablesPage.SuspendLayout();
            this.RequestsPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.ProjectControlPage.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.AdminPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.TablesPage);
            this.MainTabControl.Controls.Add(this.RequestsPage);
            this.MainTabControl.Controls.Add(this.ProjectControlPage);
            this.MainTabControl.Controls.Add(this.AdminPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Font = new System.Drawing.Font("Calibri", 10F);
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(690, 470);
            this.MainTabControl.TabIndex = 0;
            this.MainTabControl.SelectedIndexChanged += new System.EventHandler(this.MainTabControl_SelectedIndexChanged);
            // 
            // TablesPage
            // 
            this.TablesPage.Controls.Add(this.label1);
            this.TablesPage.Controls.Add(this.ProjectsEmployeesButton);
            this.TablesPage.Controls.Add(this.EmployeesButton);
            this.TablesPage.Controls.Add(this.ProjectsButton);
            this.TablesPage.Controls.Add(this.CustomersButton);
            this.TablesPage.Location = new System.Drawing.Point(4, 24);
            this.TablesPage.Name = "TablesPage";
            this.TablesPage.Padding = new System.Windows.Forms.Padding(3);
            this.TablesPage.Size = new System.Drawing.Size(682, 442);
            this.TablesPage.TabIndex = 0;
            this.TablesPage.Text = "Основная информация";
            this.TablesPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(666, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Основные таблицы приложения:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProjectsEmployeesButton
            // 
            this.ProjectsEmployeesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.ProjectsEmployeesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProjectsEmployeesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjectsEmployeesButton.Font = new System.Drawing.Font("Calibri", 14F);
            this.ProjectsEmployeesButton.ForeColor = System.Drawing.Color.Black;
            this.ProjectsEmployeesButton.Location = new System.Drawing.Point(8, 253);
            this.ProjectsEmployeesButton.Name = "ProjectsEmployeesButton";
            this.ProjectsEmployeesButton.Size = new System.Drawing.Size(666, 45);
            this.ProjectsEmployeesButton.TabIndex = 5;
            this.ProjectsEmployeesButton.Text = "Работники в проектах";
            this.ProjectsEmployeesButton.UseVisualStyleBackColor = false;
            this.ProjectsEmployeesButton.Click += new System.EventHandler(this.ShowTableButton_Click);
            // 
            // EmployeesButton
            // 
            this.EmployeesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.EmployeesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmployeesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeesButton.Font = new System.Drawing.Font("Calibri", 14F);
            this.EmployeesButton.ForeColor = System.Drawing.Color.Black;
            this.EmployeesButton.Location = new System.Drawing.Point(8, 202);
            this.EmployeesButton.Name = "EmployeesButton";
            this.EmployeesButton.Size = new System.Drawing.Size(666, 45);
            this.EmployeesButton.TabIndex = 5;
            this.EmployeesButton.Text = "Информация о работниках";
            this.EmployeesButton.UseVisualStyleBackColor = false;
            this.EmployeesButton.Click += new System.EventHandler(this.ShowTableButton_Click);
            // 
            // ProjectsButton
            // 
            this.ProjectsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.ProjectsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProjectsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjectsButton.Font = new System.Drawing.Font("Calibri", 14F);
            this.ProjectsButton.ForeColor = System.Drawing.Color.Black;
            this.ProjectsButton.Location = new System.Drawing.Point(8, 151);
            this.ProjectsButton.Name = "ProjectsButton";
            this.ProjectsButton.Size = new System.Drawing.Size(666, 45);
            this.ProjectsButton.TabIndex = 5;
            this.ProjectsButton.Text = "Информация о проектах";
            this.ProjectsButton.UseVisualStyleBackColor = false;
            this.ProjectsButton.Click += new System.EventHandler(this.ShowTableButton_Click);
            // 
            // CustomersButton
            // 
            this.CustomersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.CustomersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomersButton.Font = new System.Drawing.Font("Calibri", 14F);
            this.CustomersButton.ForeColor = System.Drawing.Color.Black;
            this.CustomersButton.Location = new System.Drawing.Point(8, 100);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Size = new System.Drawing.Size(666, 45);
            this.CustomersButton.TabIndex = 5;
            this.CustomersButton.Text = "Информация о заказчиках";
            this.CustomersButton.UseVisualStyleBackColor = false;
            this.CustomersButton.Click += new System.EventHandler(this.ShowTableButton_Click);
            // 
            // RequestsPage
            // 
            this.RequestsPage.Controls.Add(this.groupBox3);
            this.RequestsPage.Controls.Add(this.AvgOrdersCostButton);
            this.RequestsPage.Controls.Add(this.AvgSalaryButton);
            this.RequestsPage.Controls.Add(this.ProjectsByTheDayButton);
            this.RequestsPage.Controls.Add(this.SumProjectsAtLastYearButton);
            this.RequestsPage.Controls.Add(this.SumCustomerOrdersButton);
            this.RequestsPage.Controls.Add(this.ProjectsDetailButton);
            this.RequestsPage.Controls.Add(this.CurrentProjCostButton);
            this.RequestsPage.Location = new System.Drawing.Point(4, 24);
            this.RequestsPage.Name = "RequestsPage";
            this.RequestsPage.Padding = new System.Windows.Forms.Padding(3);
            this.RequestsPage.Size = new System.Drawing.Size(682, 442);
            this.RequestsPage.TabIndex = 1;
            this.RequestsPage.Text = "Получение дополнительных данных";
            this.RequestsPage.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.EmployeesProjectsTextBox);
            this.groupBox3.Controls.Add(this.EmployeesProjectsButton);
            this.groupBox3.Controls.Add(this.SearchEmployeeButton);
            this.groupBox3.Controls.Add(this.SearchEmployeeTextBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(9, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(665, 115);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Параметризированные запросы";
            // 
            // EmployeesProjectsTextBox
            // 
            this.EmployeesProjectsTextBox.Font = new System.Drawing.Font("Calibri", 14F);
            this.EmployeesProjectsTextBox.Location = new System.Drawing.Point(197, 74);
            this.EmployeesProjectsTextBox.Name = "EmployeesProjectsTextBox";
            this.EmployeesProjectsTextBox.Size = new System.Drawing.Size(125, 30);
            this.EmployeesProjectsTextBox.TabIndex = 1;
            // 
            // EmployeesProjectsButton
            // 
            this.EmployeesProjectsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.EmployeesProjectsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmployeesProjectsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeesProjectsButton.Font = new System.Drawing.Font("Calibri", 14F);
            this.EmployeesProjectsButton.ForeColor = System.Drawing.Color.Black;
            this.EmployeesProjectsButton.Location = new System.Drawing.Point(328, 66);
            this.EmployeesProjectsButton.Name = "EmployeesProjectsButton";
            this.EmployeesProjectsButton.Size = new System.Drawing.Size(331, 45);
            this.EmployeesProjectsButton.TabIndex = 11;
            this.EmployeesProjectsButton.Text = "Проекты сотрудника";
            this.EmployeesProjectsButton.UseVisualStyleBackColor = false;
            this.EmployeesProjectsButton.Click += new System.EventHandler(this.RequestsButton_Click);
            // 
            // SearchEmployeeButton
            // 
            this.SearchEmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.SearchEmployeeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchEmployeeButton.Font = new System.Drawing.Font("Calibri", 14F);
            this.SearchEmployeeButton.ForeColor = System.Drawing.Color.Black;
            this.SearchEmployeeButton.Location = new System.Drawing.Point(328, 15);
            this.SearchEmployeeButton.Name = "SearchEmployeeButton";
            this.SearchEmployeeButton.Size = new System.Drawing.Size(331, 45);
            this.SearchEmployeeButton.TabIndex = 11;
            this.SearchEmployeeButton.Text = "Поиск сотрудников";
            this.SearchEmployeeButton.UseVisualStyleBackColor = false;
            this.SearchEmployeeButton.Click += new System.EventHandler(this.RequestsButton_Click);
            // 
            // SearchEmployeeTextBox
            // 
            this.SearchEmployeeTextBox.Font = new System.Drawing.Font("Calibri", 14F);
            this.SearchEmployeeTextBox.Location = new System.Drawing.Point(197, 22);
            this.SearchEmployeeTextBox.Name = "SearchEmployeeTextBox";
            this.SearchEmployeeTextBox.Size = new System.Drawing.Size(125, 30);
            this.SearchEmployeeTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F);
            this.label2.Location = new System.Drawing.Point(90, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID проекта:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F);
            this.label3.Location = new System.Drawing.Point(62, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID сотрудника:";
            // 
            // AvgOrdersCostButton
            // 
            this.AvgOrdersCostButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.AvgOrdersCostButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AvgOrdersCostButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AvgOrdersCostButton.Font = new System.Drawing.Font("Calibri", 14F);
            this.AvgOrdersCostButton.ForeColor = System.Drawing.Color.Black;
            this.AvgOrdersCostButton.Location = new System.Drawing.Point(343, 159);
            this.AvgOrdersCostButton.Name = "AvgOrdersCostButton";
            this.AvgOrdersCostButton.Size = new System.Drawing.Size(331, 93);
            this.AvgOrdersCostButton.TabIndex = 12;
            this.AvgOrdersCostButton.Text = "Средняя стоимость проектов у заказчиков и их количество";
            this.AvgOrdersCostButton.UseVisualStyleBackColor = false;
            this.AvgOrdersCostButton.Click += new System.EventHandler(this.RequestsButton_Click);
            // 
            // AvgSalaryButton
            // 
            this.AvgSalaryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.AvgSalaryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AvgSalaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AvgSalaryButton.Font = new System.Drawing.Font("Calibri", 14F);
            this.AvgSalaryButton.ForeColor = System.Drawing.Color.Black;
            this.AvgSalaryButton.Location = new System.Drawing.Point(343, 108);
            this.AvgSalaryButton.Name = "AvgSalaryButton";
            this.AvgSalaryButton.Size = new System.Drawing.Size(331, 45);
            this.AvgSalaryButton.TabIndex = 11;
            this.AvgSalaryButton.Text = "Средняя з\\п от языка прог.";
            this.AvgSalaryButton.UseVisualStyleBackColor = false;
            this.AvgSalaryButton.Click += new System.EventHandler(this.RequestsButton_Click);
            // 
            // ProjectsByTheDayButton
            // 
            this.ProjectsByTheDayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.ProjectsByTheDayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProjectsByTheDayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjectsByTheDayButton.Font = new System.Drawing.Font("Calibri", 14F);
            this.ProjectsByTheDayButton.ForeColor = System.Drawing.Color.Black;
            this.ProjectsByTheDayButton.Location = new System.Drawing.Point(6, 207);
            this.ProjectsByTheDayButton.Name = "ProjectsByTheDayButton";
            this.ProjectsByTheDayButton.Size = new System.Drawing.Size(331, 45);
            this.ProjectsByTheDayButton.TabIndex = 10;
            this.ProjectsByTheDayButton.Text = "Проекты по дням до завершения";
            this.ProjectsByTheDayButton.UseVisualStyleBackColor = false;
            this.ProjectsByTheDayButton.Click += new System.EventHandler(this.RequestsButton_Click);
            // 
            // SumProjectsAtLastYearButton
            // 
            this.SumProjectsAtLastYearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.SumProjectsAtLastYearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SumProjectsAtLastYearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SumProjectsAtLastYearButton.Font = new System.Drawing.Font("Calibri", 14F);
            this.SumProjectsAtLastYearButton.ForeColor = System.Drawing.Color.Black;
            this.SumProjectsAtLastYearButton.Location = new System.Drawing.Point(343, 6);
            this.SumProjectsAtLastYearButton.Name = "SumProjectsAtLastYearButton";
            this.SumProjectsAtLastYearButton.Size = new System.Drawing.Size(331, 96);
            this.SumProjectsAtLastYearButton.TabIndex = 9;
            this.SumProjectsAtLastYearButton.Text = "Премии за текущие проекты и сроки завершения";
            this.SumProjectsAtLastYearButton.UseVisualStyleBackColor = false;
            this.SumProjectsAtLastYearButton.Click += new System.EventHandler(this.RequestsButton_Click);
            // 
            // SumCustomerOrdersButton
            // 
            this.SumCustomerOrdersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.SumCustomerOrdersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SumCustomerOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SumCustomerOrdersButton.Font = new System.Drawing.Font("Calibri", 14F);
            this.SumCustomerOrdersButton.ForeColor = System.Drawing.Color.Black;
            this.SumCustomerOrdersButton.Location = new System.Drawing.Point(6, 108);
            this.SumCustomerOrdersButton.Name = "SumCustomerOrdersButton";
            this.SumCustomerOrdersButton.Size = new System.Drawing.Size(331, 96);
            this.SumCustomerOrdersButton.TabIndex = 8;
            this.SumCustomerOrdersButton.Text = "Дополнительная информация о работниках";
            this.SumCustomerOrdersButton.UseVisualStyleBackColor = false;
            this.SumCustomerOrdersButton.Click += new System.EventHandler(this.RequestsButton_Click);
            // 
            // ProjectsDetailButton
            // 
            this.ProjectsDetailButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.ProjectsDetailButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProjectsDetailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjectsDetailButton.Font = new System.Drawing.Font("Calibri", 14F);
            this.ProjectsDetailButton.ForeColor = System.Drawing.Color.Black;
            this.ProjectsDetailButton.Location = new System.Drawing.Point(6, 57);
            this.ProjectsDetailButton.Name = "ProjectsDetailButton";
            this.ProjectsDetailButton.Size = new System.Drawing.Size(331, 45);
            this.ProjectsDetailButton.TabIndex = 7;
            this.ProjectsDetailButton.Text = "Подробно о проектах";
            this.ProjectsDetailButton.UseVisualStyleBackColor = false;
            this.ProjectsDetailButton.Click += new System.EventHandler(this.RequestsButton_Click);
            // 
            // CurrentProjCostButton
            // 
            this.CurrentProjCostButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.CurrentProjCostButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CurrentProjCostButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CurrentProjCostButton.Font = new System.Drawing.Font("Calibri", 14F);
            this.CurrentProjCostButton.ForeColor = System.Drawing.Color.Black;
            this.CurrentProjCostButton.Location = new System.Drawing.Point(6, 6);
            this.CurrentProjCostButton.Name = "CurrentProjCostButton";
            this.CurrentProjCostButton.Size = new System.Drawing.Size(331, 45);
            this.CurrentProjCostButton.TabIndex = 6;
            this.CurrentProjCostButton.Text = "Текущие проекты по стоимости";
            this.CurrentProjCostButton.UseVisualStyleBackColor = false;
            this.CurrentProjCostButton.Click += new System.EventHandler(this.RequestsButton_Click);
            // 
            // ProjectControlPage
            // 
            this.ProjectControlPage.Controls.Add(this.groupBox6);
            this.ProjectControlPage.Controls.Add(this.groupBox5);
            this.ProjectControlPage.Location = new System.Drawing.Point(4, 24);
            this.ProjectControlPage.Name = "ProjectControlPage";
            this.ProjectControlPage.Size = new System.Drawing.Size(682, 442);
            this.ProjectControlPage.TabIndex = 3;
            this.ProjectControlPage.Text = "Управление проектами";
            this.ProjectControlPage.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.EndTheProjectButton);
            this.groupBox6.Controls.Add(this.ProjectIdTextBox);
            this.groupBox6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Underline);
            this.groupBox6.Location = new System.Drawing.Point(3, 185);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(666, 170);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Досрочное завершение проекта";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 14F);
            this.label13.Location = new System.Drawing.Point(453, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 23);
            this.label13.TabIndex = 15;
            this.label13.Text = "ID проекта:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10F);
            this.label9.Location = new System.Drawing.Point(6, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(308, 68);
            this.label9.TabIndex = 13;
            this.label9.Text = "Для досрочного завершения какого-либо проекта\r\nвведите его ID в соответствующее п" +
    "оле и нажмите\r\nна кнопку. Если проект был завершен ранее - дата\r\nзавершения не и" +
    "зменится.";
            // 
            // EndTheProjectButton
            // 
            this.EndTheProjectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.EndTheProjectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EndTheProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EndTheProjectButton.Font = new System.Drawing.Font("Calibri", 14F);
            this.EndTheProjectButton.ForeColor = System.Drawing.Color.Black;
            this.EndTheProjectButton.Location = new System.Drawing.Point(14, 119);
            this.EndTheProjectButton.Name = "EndTheProjectButton";
            this.EndTheProjectButton.Size = new System.Drawing.Size(646, 45);
            this.EndTheProjectButton.TabIndex = 12;
            this.EndTheProjectButton.Text = "Завершить проект";
            this.EndTheProjectButton.UseVisualStyleBackColor = false;
            this.EndTheProjectButton.Click += new System.EventHandler(this.EndTheProjectButton_Click);
            // 
            // ProjectIdTextBox
            // 
            this.ProjectIdTextBox.Font = new System.Drawing.Font("Calibri", 14F);
            this.ProjectIdTextBox.Location = new System.Drawing.Point(560, 83);
            this.ProjectIdTextBox.Name = "ProjectIdTextBox";
            this.ProjectIdTextBox.Size = new System.Drawing.Size(100, 30);
            this.ProjectIdTextBox.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.AddEmpToProjTextBox);
            this.groupBox5.Controls.Add(this.EmployeeIdTextBox);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.AddEmployeeToProjectButton);
            this.groupBox5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Underline);
            this.groupBox5.Location = new System.Drawing.Point(8, 9);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(666, 170);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Добавление работника в проект";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 14F);
            this.label12.Location = new System.Drawing.Point(166, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 23);
            this.label12.TabIndex = 15;
            this.label12.Text = "ID проекта:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14F);
            this.label11.Location = new System.Drawing.Point(420, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 23);
            this.label11.TabIndex = 15;
            this.label11.Text = "ID сотрудника:";
            // 
            // AddEmpToProjTextBox
            // 
            this.AddEmpToProjTextBox.Font = new System.Drawing.Font("Calibri", 14F);
            this.AddEmpToProjTextBox.Location = new System.Drawing.Point(273, 83);
            this.AddEmpToProjTextBox.Name = "AddEmpToProjTextBox";
            this.AddEmpToProjTextBox.Size = new System.Drawing.Size(100, 30);
            this.AddEmpToProjTextBox.TabIndex = 14;
            // 
            // EmployeeIdTextBox
            // 
            this.EmployeeIdTextBox.Font = new System.Drawing.Font("Calibri", 14F);
            this.EmployeeIdTextBox.Location = new System.Drawing.Point(561, 83);
            this.EmployeeIdTextBox.Name = "EmployeeIdTextBox";
            this.EmployeeIdTextBox.Size = new System.Drawing.Size(100, 30);
            this.EmployeeIdTextBox.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 10F);
            this.label10.Location = new System.Drawing.Point(6, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(592, 51);
            this.label10.TabIndex = 13;
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // AddEmployeeToProjectButton
            // 
            this.AddEmployeeToProjectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.AddEmployeeToProjectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddEmployeeToProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployeeToProjectButton.Font = new System.Drawing.Font("Calibri", 14F);
            this.AddEmployeeToProjectButton.ForeColor = System.Drawing.Color.Black;
            this.AddEmployeeToProjectButton.Location = new System.Drawing.Point(9, 119);
            this.AddEmployeeToProjectButton.Name = "AddEmployeeToProjectButton";
            this.AddEmployeeToProjectButton.Size = new System.Drawing.Size(652, 45);
            this.AddEmployeeToProjectButton.TabIndex = 12;
            this.AddEmployeeToProjectButton.Text = "Добавить работника";
            this.AddEmployeeToProjectButton.UseVisualStyleBackColor = false;
            this.AddEmployeeToProjectButton.Click += new System.EventHandler(this.AddEmployeeToProjectButton_Click);
            // 
            // AdminPage
            // 
            this.AdminPage.Controls.Add(this.groupBox2);
            this.AdminPage.Controls.Add(this.groupBox1);
            this.AdminPage.Location = new System.Drawing.Point(4, 24);
            this.AdminPage.Name = "AdminPage";
            this.AdminPage.Size = new System.Drawing.Size(682, 442);
            this.AdminPage.TabIndex = 2;
            this.AdminPage.Text = "Управление приложением";
            this.AdminPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.AddNewUserButton);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ShowPassCheckBox);
            this.groupBox2.Controls.Add(this.RepeatPasswordTextBox);
            this.groupBox2.Controls.Add(this.PasswordTextBox);
            this.groupBox2.Controls.Add(this.FullNameTextBox);
            this.groupBox2.Controls.Add(this.LoginTextBox);
            this.groupBox2.Location = new System.Drawing.Point(252, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 362);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавление пользователя";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F);
            this.label7.Location = new System.Drawing.Point(48, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "ФИО:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F);
            this.label6.Location = new System.Drawing.Point(26, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Пароль:";
            // 
            // AddNewUserButton
            // 
            this.AddNewUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.AddNewUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNewUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewUserButton.Font = new System.Drawing.Font("Calibri", 14F);
            this.AddNewUserButton.ForeColor = System.Drawing.Color.Black;
            this.AddNewUserButton.Location = new System.Drawing.Point(82, 250);
            this.AddNewUserButton.Name = "AddNewUserButton";
            this.AddNewUserButton.Size = new System.Drawing.Size(334, 31);
            this.AddNewUserButton.TabIndex = 8;
            this.AddNewUserButton.Text = "Добавить";
            this.AddNewUserButton.UseVisualStyleBackColor = false;
            this.AddNewUserButton.Click += new System.EventHandler(this.AddNewUserButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F);
            this.label5.Location = new System.Drawing.Point(26, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Пароль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F);
            this.label4.Location = new System.Drawing.Point(37, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Логин:";
            // 
            // ShowPassCheckBox
            // 
            this.ShowPassCheckBox.AutoSize = true;
            this.ShowPassCheckBox.Font = new System.Drawing.Font("Calibri", 12F);
            this.ShowPassCheckBox.Location = new System.Drawing.Point(82, 226);
            this.ShowPassCheckBox.Name = "ShowPassCheckBox";
            this.ShowPassCheckBox.Size = new System.Drawing.Size(142, 23);
            this.ShowPassCheckBox.TabIndex = 7;
            this.ShowPassCheckBox.Text = "Показать пароль";
            this.ShowPassCheckBox.UseVisualStyleBackColor = true;
            this.ShowPassCheckBox.CheckedChanged += new System.EventHandler(this.ShowPassCheckBox_CheckedChanged);
            // 
            // RepeatPasswordTextBox
            // 
            this.RepeatPasswordTextBox.Font = new System.Drawing.Font("Calibri", 14F);
            this.RepeatPasswordTextBox.Location = new System.Drawing.Point(110, 153);
            this.RepeatPasswordTextBox.Name = "RepeatPasswordTextBox";
            this.RepeatPasswordTextBox.Size = new System.Drawing.Size(306, 30);
            this.RepeatPasswordTextBox.TabIndex = 5;
            this.RepeatPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Calibri", 14F);
            this.PasswordTextBox.Location = new System.Drawing.Point(110, 117);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(306, 30);
            this.PasswordTextBox.TabIndex = 4;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Font = new System.Drawing.Font("Calibri", 14F);
            this.FullNameTextBox.Location = new System.Drawing.Point(110, 189);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(306, 30);
            this.FullNameTextBox.TabIndex = 6;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Font = new System.Drawing.Font("Calibri", 14F);
            this.LoginTextBox.Location = new System.Drawing.Point(110, 81);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(306, 30);
            this.LoginTextBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.UsersListbox);
            this.groupBox1.Controls.Add(this.ChangeUserAccessButton);
            this.groupBox1.Controls.Add(this.DeleteUserButton);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 362);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Удаление пользователя";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14F);
            this.label8.Location = new System.Drawing.Point(2, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 23);
            this.label8.TabIndex = 22;
            this.label8.Text = "Выберите пользователя:";
            // 
            // UsersListbox
            // 
            this.UsersListbox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersListbox.FormattingEnabled = true;
            this.UsersListbox.ItemHeight = 19;
            this.UsersListbox.Location = new System.Drawing.Point(6, 50);
            this.UsersListbox.Name = "UsersListbox";
            this.UsersListbox.Size = new System.Drawing.Size(226, 194);
            this.UsersListbox.TabIndex = 21;
            // 
            // ChangeUserAccessButton
            // 
            this.ChangeUserAccessButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.ChangeUserAccessButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeUserAccessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeUserAccessButton.Font = new System.Drawing.Font("Calibri", 14F);
            this.ChangeUserAccessButton.ForeColor = System.Drawing.Color.Black;
            this.ChangeUserAccessButton.Location = new System.Drawing.Point(6, 252);
            this.ChangeUserAccessButton.Name = "ChangeUserAccessButton";
            this.ChangeUserAccessButton.Size = new System.Drawing.Size(226, 58);
            this.ChangeUserAccessButton.TabIndex = 1;
            this.ChangeUserAccessButton.Text = "Редактировать права пользователя";
            this.ChangeUserAccessButton.UseVisualStyleBackColor = false;
            this.ChangeUserAccessButton.Click += new System.EventHandler(this.ChangeUserAccessButton_Click);
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.DeleteUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteUserButton.Font = new System.Drawing.Font("Calibri", 14F);
            this.DeleteUserButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteUserButton.Location = new System.Drawing.Point(6, 316);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(226, 31);
            this.DeleteUserButton.TabIndex = 2;
            this.DeleteUserButton.Text = "Удалить пользователя";
            this.DeleteUserButton.UseVisualStyleBackColor = false;
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(238)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.AboutProgramButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 404);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 66);
            this.panel1.TabIndex = 1;
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(457, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(221, 42);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Выход из приложения";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AboutProgramButton
            // 
            this.AboutProgramButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutProgramButton.Location = new System.Drawing.Point(12, 12);
            this.AboutProgramButton.Name = "AboutProgramButton";
            this.AboutProgramButton.Size = new System.Drawing.Size(221, 42);
            this.AboutProgramButton.TabIndex = 0;
            this.AboutProgramButton.Text = "Справка";
            this.AboutProgramButton.UseVisualStyleBackColor = true;
            this.AboutProgramButton.Click += new System.EventHandler(this.AboutProgramButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(238)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(690, 470);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainTabControl);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(706, 509);
            this.MinimumSize = new System.Drawing.Size(706, 509);
            this.Name = "MainForm";
            this.Text = "ИС предприятия \"Квадро\". Пользователь: ";
            this.MainTabControl.ResumeLayout(false);
            this.TablesPage.ResumeLayout(false);
            this.RequestsPage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ProjectControlPage.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.AdminPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage TablesPage;
        private System.Windows.Forms.TabPage RequestsPage;
        private System.Windows.Forms.TabPage AdminPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ProjectsEmployeesButton;
        private System.Windows.Forms.Button EmployeesButton;
        private System.Windows.Forms.Button ProjectsButton;
        private System.Windows.Forms.Button CustomersButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AboutProgramButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox EmployeesProjectsTextBox;
        private System.Windows.Forms.Button EmployeesProjectsButton;
        private System.Windows.Forms.Button SearchEmployeeButton;
        private System.Windows.Forms.TextBox SearchEmployeeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AvgOrdersCostButton;
        private System.Windows.Forms.Button AvgSalaryButton;
        private System.Windows.Forms.Button ProjectsByTheDayButton;
        private System.Windows.Forms.Button SumProjectsAtLastYearButton;
        private System.Windows.Forms.Button SumCustomerOrdersButton;
        private System.Windows.Forms.Button ProjectsDetailButton;
        private System.Windows.Forms.Button CurrentProjCostButton;
        private System.Windows.Forms.TabPage ProjectControlPage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddNewUserButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ShowPassCheckBox;
        private System.Windows.Forms.TextBox RepeatPasswordTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox UsersListbox;
        private System.Windows.Forms.Button DeleteUserButton;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button EndTheProjectButton;
        private System.Windows.Forms.TextBox ProjectIdTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox AddEmpToProjTextBox;
        private System.Windows.Forms.TextBox EmployeeIdTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button AddEmployeeToProjectButton;
        private System.Windows.Forms.Button ChangeUserAccessButton;
    }
}