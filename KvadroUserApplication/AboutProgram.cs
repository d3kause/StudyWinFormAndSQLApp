using System;
using System.Windows.Forms;

namespace KvadroUserApplication
{
    public partial class AboutProgram : Form
    {
        public AboutProgram()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
