using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KvadroUserApplication
{
    public partial class UserRightsManagement : Form
    {
        string login;
        public UserRightsManagement(string login)
        {
            InitializeComponent();
            this.login = login;
            this.Text += login;
            HeaderLabel.Text += login;
            List<int> accessId = new List<int>();
            using (SqlConnection cn = new SqlConnection(SQLRequestsData.conStr))
            {
                try
                {
                    cn.Open();
                    SqlCommand myCommand = new SqlCommand($"SELECT accessId FROM UserAccess WHERE login = '{login}'", cn);
                    SqlDataReader dr = myCommand.ExecuteReader();
                    while (dr.Read())
                        accessId.Add(Convert.ToInt32(dr["accessId"]));
                    dr.Close();
                    myCommand = new SqlCommand("SELECT * FROM AccessLevels", cn);
                    dr = myCommand.ExecuteReader();
                    while (dr.Read())
                    {
                        if (accessId.Contains(Convert.ToInt32(dr["accessId"])))
                            UserAccessListBox.Items.Add(dr["description"]);
                        else
                            AddAccessListBox.Items.Add(dr["description"]);
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

        private void AccessListBoxes_DoubleClick(object sender, EventArgs e)
        {
            ListBox obj = sender as ListBox;
            string SQLcommand = "";
            if (obj.Name == "UserAccessListBox") // Удаление прав
                SQLcommand = $"SELECT accessId FROM AccessLevels WHERE description = '{UserAccessListBox.SelectedItem.ToString()}'";
            else
                SQLcommand = $"SELECT accessId FROM AccessLevels WHERE description = '{AddAccessListBox.SelectedItem.ToString()}'";
            using (SqlConnection cn = new SqlConnection(SQLRequestsData.conStr))
            {
                try
                {
                    cn.Open();
                    SqlCommand myCommand = new SqlCommand(SQLcommand, cn);
                    SqlDataReader dr = myCommand.ExecuteReader();
                    int accessNum = 0;
                    while (dr.Read())
                        accessNum = Convert.ToInt32(dr["accessId"]);
                    dr.Close();
                    if (obj.Name == "UserAccessListBox") // Удаление прав
                    {
                        myCommand = new SqlCommand($"DELETE FROM UserAccess WHERE login = '{login}' and accessId = {accessNum}" ,cn);
                        myCommand.ExecuteNonQuery();
                        AddAccessListBox.Items.Add(UserAccessListBox.SelectedItem.ToString());
                        UserAccessListBox.Items.RemoveAt(UserAccessListBox.SelectedIndex);
                    }
                    else
                    {
                        myCommand = new SqlCommand($"INSERT INTO UserAccess VALUES('{login}',{accessNum})", cn);
                        myCommand.ExecuteNonQuery();
                        UserAccessListBox.Items.Add(AddAccessListBox.SelectedItem.ToString());
                        AddAccessListBox.Items.RemoveAt(AddAccessListBox.SelectedIndex);
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

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
