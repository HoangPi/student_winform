using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management
{
    public partial class resetPassword : Form
    {
        public resetPassword()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newPassword = passwordInput.Text.Trim() == "" ? "a" : passwordInput.Text;
            SqlCommand cmd = new SqlCommand($"UPDATE ACCOUNT SET password = '{newPassword}' WHERE username='{usernameInput.Text}'",GlobalVars.connection);
            try
            {
                cmd.ExecuteNonQuery();
                label1.Text = "Account reset";
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }
    }
}
