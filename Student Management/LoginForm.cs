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
                var reader = command.ExecuteReader();
                reader.Read();
                Console.WriteLine(reader.GetInt32(0));
                int userid = reader.GetInt32(0);
                string userName = reader.GetString(1);
                string role = reader.GetString(2);
                if(role == "student")
                {
                    stdHomePage homePage = new stdHomePage(userName, userid.ToString(), role);
                    GlobalVars.connection.Close();
                    GlobalVars.connection = new SqlConnection(GlobalVars.student_connection_string);
                    GlobalVars.connection.Open();
                    this.Hide();
                    homePage.ShowDialog();
                    this.Show();
                }
                else if(role == "manager")
                {
                    managerHomePage homePage = new managerHomePage(userName, userid.ToString(), role);
                    GlobalVars.connection.Close();
                    GlobalVars.connection = new SqlConnection(GlobalVars.manager_connection_string);
                    GlobalVars.connection.Open();
                    this.Hide();
                    homePage.ShowDialog();
                    this.Show();
                }
                else if(role == "instructor")
                {
                    label1.Text = "INSTRUC";
                    instructorHomepage homepage = new instructorHomepage(userid,userName);
                    GlobalVars.connection.Close();
                    GlobalVars.connection = new SqlConnection(GlobalVars.instructor_connection_string);
                    GlobalVars.connection.Open();
                    Console.WriteLine(GlobalVars.connection.ConnectionString);
                    this.Hide();
                    homepage.ShowDialog();
                    this.Show();
                }
                else
                {

                }
                /*using (var reader = command.ExecuteReader())
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
                                GlobalVars.connection.Close();
                                GlobalVars.connection = new SqlConnection(GlobalVars.manager_connection_string);
                                GlobalVars.connection.Open();
                                Console.WriteLine(GlobalVars.connection.ConnectionString);
                                this.Hide();
                                homePage.ShowDialog();
                                this.Show();
                            };
                        }
                        else if(reader.GetString(2)=="instructor")
                        {
                            label1.Text = "HELLO";
                            using(instructorHomepage homepage = new instructorHomepage(reader.GetInt32(0), reader.GetString(1)))
                            {
                                GlobalVars.connection.Close();
                                GlobalVars.connection = new SqlConnection(GlobalVars.instructor_connection_string);
                                GlobalVars.connection.Open();
                                Console.WriteLine(GlobalVars.connection.ConnectionString);
                                this.Hide();
                                homepage.ShowDialog();
                                this.Show();
                            }
                            
                        }
                    }
                }*/
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
            finally {
                GlobalVars.connection.Close();
                GlobalVars.connection = new SqlConnection(GlobalVars.guest_connection_string);
                GlobalVars.connection.Open();
                //label1.Text = GlobalVars.connection.ConnectionString;
            }
            //label1.Text = GlobalVars.connection.ConnectionString;

            //command = new SqlCommand("SELECT * FROM ACCOUNT", GlobalVars.connection);
            //reader = command.ExecuteReader();
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            /*GlobalVars.connection.Close();
            GlobalVars.connection = new SqlConnection(GlobalVars.guest_connection_string);
            GlobalVars.connection.Open();*/
        }
    }
}
