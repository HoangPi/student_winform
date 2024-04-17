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
    public partial class removeStdFromCourse : Form
    {
        private DataSet ds = new DataSet();
        public removeStdFromCourse()
        {
            InitializeComponent();
            string query = "SELECT fullname, sid from student";
            SqlDataAdapter adapter = new SqlDataAdapter(query, GlobalVars.connection);
            adapter.Fill(ds, "Students");
            stdNameDropdown.DisplayMember = "fullname";
            stdNameDropdown.DataSource = ds.Tables[0];

            query = "SELECT cid, cname from course";
            adapter = new SqlDataAdapter(query, GlobalVars.connection);
            adapter.Fill(ds, "Courses");
            courseNameDropdown.DisplayMember = "cname";
            courseNameDropdown.DataSource = ds.Tables[1];

            courseidLabel.Text = ds.Tables[1].Rows[0][0].ToString();
            stdIdLabel.Text = ds.Tables[0].Rows[0][1].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("remove_student_from_course", GlobalVars.connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@cid", SqlDbType.Int) { Value=Int32.Parse(courseidLabel.Text)});
                sqlCommand.Parameters.Add(new SqlParameter("@sid", SqlDbType.Int) { Value= Int32.Parse(stdIdLabel.Text)});
                sqlCommand.ExecuteNonQuery();
                label3.Text = $"Student {Int32.Parse(stdIdLabel.Text)} removed from course {Int32.Parse(courseidLabel.Text)}";
            }
            catch(Exception ex) { label3.Text=ex.Message; }
        }

        private void courseNameDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            courseidLabel.Text = ds.Tables[1].Rows[courseNameDropdown.SelectedIndex][0].ToString();
        }

        private void stdIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void courseidLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void stdNameDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            stdIdLabel.Text = ds.Tables[0].Rows[stdNameDropdown.SelectedIndex][1].ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
