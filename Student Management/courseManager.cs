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
    public partial class courseManager : Form
    {
        private DataSet ds = new DataSet();
        public courseManager()
        {
            InitializeComponent();
            string query = "SELECT fullname, sid from student";
            SqlDataAdapter adapter = new SqlDataAdapter(query,GlobalVars.connection);
            adapter.Fill(ds, "Students");
            stdNameDropdown.DisplayMember = "fullname";
            stdNameDropdown.DataSource = ds.Tables[0];

            query = "SELECT cid, cname from course";
            adapter = new SqlDataAdapter(query,GlobalVars.connection);
            adapter.Fill(ds, "Courses");
            courseNameDropdown.DisplayMember = "cname";
            courseNameDropdown.DataSource = ds.Tables[1];

            courseidLabel.Text = ds.Tables[1].Rows[0][0].ToString();
            stdIdLabel.Text = ds.Tables[0].Rows[0][1].ToString();
        }

        private void courseManager_Load(object sender, EventArgs e)
        {

        }

        private void courseNameDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            courseidLabel.Text = ds.Tables[1].Rows[courseNameDropdown.SelectedIndex][0].ToString();
        }

        private void stdNameDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            stdIdLabel.Text = ds.Tables[0].Rows[stdNameDropdown.SelectedIndex][1].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("add_student_to_course",GlobalVars.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@cid", SqlDbType.Int) { Value=courseidLabel.Text });
                cmd.Parameters.Add(new SqlParameter ("@sid",SqlDbType.Int) { Value=stdIdLabel.Text });
                cmd.ExecuteNonQuery();
                label3.Text = "Student added to course";
            }
            catch(Exception ex)
            { 
                label3.Text= ex.Message;
            }

        }
    }
}
