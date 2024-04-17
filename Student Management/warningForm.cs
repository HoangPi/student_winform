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
    public partial class warningForm : Form
    {
        private DataSet ds = new DataSet();
        public warningForm()
        {
            InitializeComponent();
        }

        private void warningForm_Load(object sender, EventArgs e)
        {
            ds.Clear();
            string query = "select wid, Severity, name, student.sid, Fullname from warning join student on warning.sid = student.sid";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query,GlobalVars.connection);
            sqlDataAdapter.Fill(ds,"warnings");
            sqlDataAdapter = new SqlDataAdapter("select sid, fullname from student", GlobalVars.connection);
            sqlDataAdapter.Fill(ds,"sid");
            studentList.DisplayMember = "sid";
            studentList.DataSource = ds.Tables[1];
            stdNameLabel.Text = ds.Tables[1].Rows[0][1].ToString();
            levelDropdown.SelectedIndex = 0;
            dataGridView1.DataSource= ds.Tables[0];
            dataGridView1.Refresh();
        }

        private void studentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (studentList.SelectedIndex < 0) return;
            stdNameLabel.Text = ds.Tables[1].Rows[studentList.SelectedIndex][1].ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (warningInput.Text.Trim() == "") { 
                statusLabel.Text = "Warning field must be filled";
                return;
            }
            SqlCommand sqlCommand = new SqlCommand("add_warning", GlobalVars.connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(new SqlParameter("@sid", Int32.Parse(ds.Tables[1].Rows[studentList.SelectedIndex][0].ToString())));
            sqlCommand.Parameters.Add(new SqlParameter("@level",levelDropdown.Text));
            sqlCommand.Parameters.Add(new SqlParameter("@value",warningInput.Text));
            try
            {
                
                sqlCommand.ExecuteNonQuery();
                this.warningForm_Load(sender, e);
                statusLabel.Text = "success";
            }
            catch(Exception ex) { statusLabel.Text = ex.Message; }
        }
    }
}
