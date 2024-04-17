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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            String username = usernameInput.Text;
            String password = passwordInput.Text;

            SqlCommand command = new SqlCommand("login", GlobalVars.connection);
            

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@username", SqlDbType.VarChar) { Value = usernameInput.Text });
            command.Parameters.Add(new SqlParameter("@password", SqlDbType.VarChar) { Value=passwordInput.Text });
            try
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader.GetInt32(0)}-{reader.GetString(1)}-{reader.GetString(2)}");
                        label1.Text = ($"{reader.GetInt32(0)}-{reader.GetString(1)}-{reader.GetString(2)}");

                        if (reader.GetString(2) == "student")
                        {
                            using (stdHomePage homePage = new stdHomePage(reader.GetString(1), reader.GetInt32(0).ToString(), reader.GetString(2)))
                            {
                                this.Hide();
                                homePage.ShowDialog();
                                this.Show();
                            }
                        }
                        else if (reader.GetString(2) == "manager") {
                            using (managerHomePage homePage = new managerHomePage(reader.GetString(1), reader.GetInt32(0).ToString(), reader.GetString(2)))
                            {
                                this.Hide();
                                homePage.ShowDialog();
                                this.Show();
                            };
                        }
                        else
                        {
                            instructorHomepage k = new instructorHomepage(reader.GetInt32(0), reader.GetString(1));
                            this.Hide();
                            k.ShowDialog();
                            this.Show();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
            

            //command = new SqlCommand("SELECT * FROM ACCOUNT", GlobalVars.connection);
            //reader = command.ExecuteReader();
            
        }
    }
}
