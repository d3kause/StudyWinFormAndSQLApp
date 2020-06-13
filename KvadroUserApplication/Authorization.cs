using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KvadroUserApplication
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void ShowPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = !ShowPassCheckBox.Checked;
        }

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            if(LoginTextBox.Text.Length == 0 || PasswordTextBox.Text.Length == 0)
            {
                MessageBox.Show("Не заполнено поле логига или пароля!", "Авторизация");
                return;
            }
            string fullName = "";
            List<int> accessesId = new List<int>();
            using (SqlConnection cn = new SqlConnection(SQLRequestsData.conStr))
            {
                try
                {
                    cn.Open();
                    string strSQL = "SELECT * FROM AuthorizationData WHERE login = '" + LoginTextBox.Text + "' and password = '" + PasswordTextBox.Text + "'";
                    SqlCommand myCommand = new SqlCommand(strSQL, cn);
                    SqlDataReader dr = myCommand.ExecuteReader();
                    if (dr.Read())
                        fullName = (dr["name"]).ToString();
                    else
                    {
                        MessageBox.Show("Неправильно введён логин или пароль!","Авторизация");
                        PasswordTextBox.Clear();
                        return;
                    }
                    dr.Close();
                    strSQL = "SELECT accessId FROM UserAccess WHERE login = '" + LoginTextBox.Text + "'";
                    myCommand = new SqlCommand(strSQL, cn);
                    dr = myCommand.ExecuteReader();
                    while (dr.Read())
                        accessesId.Add(Convert.ToInt32(dr[0].ToString()));
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
            MainForm obj = new MainForm(accessesId, fullName, LoginTextBox.Text);
            this.Hide();
            obj.ShowDialog();
            this.Close();
        }
    }
}
