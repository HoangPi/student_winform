using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management
{
    public partial class addCourse : Form
    {
        private DataSet ds = new DataSet();
        public addCourse()
        {

            InitializeComponent();
            try
            {
                string query = "select fullnameins, iid from instructor";
                SqlDataAdapter adapter = new SqlDataAdapter(query,GlobalVars.connection);
                adapter.Fill(ds,"instructor");
                instructorDropDown.DisplayMember = "fullnameins";
                instructorDropDown.ValueMember = "iid";
                instructorDropDown.DataSource = ds.Tables["instructor"];
                instructorLabel.Text = ds.Tables["instructor"].Rows[instructorDropDown.SelectedIndex][1].ToString();
                creditDropDown.SelectedIndex = 0;
            }
            catch(Exception e) {
                Console.WriteLine(e.ToString());
            }
        }

        private void addCourse_Load(object sender, EventArgs e)
        {

        }

        private void instructorDropDown_TabIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(instructorDropDown.SelectedIndex);
            instructorLabel.Text = this.ds.Tables["instructor"].Rows[1][instructorDropDown.SelectedIndex].ToString();
        }

        private void instructorDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            instructorLabel.Text = this.ds.Tables["instructor"].Rows[instructorDropDown.SelectedIndex][1].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("add_course", GlobalVars.connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@cname", SqlDbType.NVarChar) { Value = courseNameInput.Text });
            command.Parameters.Add(new SqlParameter("@iid", SqlDbType.Int) { Value = Int32.Parse(instructorLabel.Text) });
            command.Parameters .Add(new SqlParameter("@credit", SqlDbType.Int) { Value=Int32.Parse(creditDropDown.Text) });
            try
            {
                command.ExecuteNonQuery();
                label2.Text = "New course added to the database" + " " + courseNameInput.Text;
            }
            catch (Exception ex)
            {
                label2.Text= ex.Message + "" + courseNameInput.Text;
            }
        }
    }
}
