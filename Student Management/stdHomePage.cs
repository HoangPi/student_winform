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
    public partial class stdHomePage : Form
    {
        private string userName;
        private string userID;
        private string role;
        DataSet ds = new DataSet();
        public stdHomePage(string userName, string userID, string role)
        {
            InitializeComponent();
            this.userName = userName;
            this.userID = userID;
            this.role = role;
            userinfo.Text = $"{this.role} {this.userName}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "select semester, score1, score2, (score1+score2)/2 as avg_score, pass as status" +
                ", course.cname, credit, fullnameins " +
                "from result " +
                "join course on result.cid = course.cid " +
                "join instructor on instructor.iid = course.iid " +
                $"where sid = {userID} ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, GlobalVars.connection);
            adapter.Fill(ds,"all_result");
            dataGridView1.DataSource = ds.Tables[0];

            query = $"select semester, average_score, credits from passed_courses where sid={userID}";
            adapter = new SqlDataAdapter(query, GlobalVars.connection);
            adapter.Fill(ds, "passed_courses");
            dataGridView2.DataSource= ds.Tables[1];

            query = $"select semester, avg_score, credits from all_courses where sid={userID}";
            adapter = new SqlDataAdapter(query, GlobalVars.connection);
            adapter.Fill(ds, "all_courses");
            dataGridView3.DataSource = ds.Tables[2];

            query = $"select wid, severity, name from warning where sid={userID}";
            adapter = new SqlDataAdapter(query, GlobalVars.connection);
            adapter.Fill(ds, "warnings");
            dataGridView4.DataSource = ds.Tables[3];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            contact cForm = new contact("student", Int32.Parse(this.userID));
            this.Hide();
            cForm.ShowDialog();
            this.Show();
        }
    }
}
