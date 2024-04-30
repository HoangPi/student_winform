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
    public partial class instructorHomepage : Form
    {
        private int iid;
        private string iname;
        private DataSet ds = new DataSet();
        public instructorHomepage(int instructorId, string instructorName)
        {
            InitializeComponent();
            this.iid = instructorId;
            this.iname = instructorName;
            
        }

        private void instructorHomepage_Load(object sender, EventArgs e)
        {
            label1.Text = iname + " - " + iid;

            string query = $"select cid as course_id, cname as course_name, credit from course where iid={this.iid}";
            SqlDataAdapter adapter = new SqlDataAdapter(query, GlobalVars.connection);
            adapter.Fill(ds);
            courseGridView.DataSource = ds.Tables[0];
            courseGridView.Refresh();
        }


        private void courseGridView_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow row = courseGridView.CurrentRow;
            Console.WriteLine(row.Cells[0].Value);
            courseView cForm = new courseView(ds.Tables[0].Rows[row.Index][0].ToString());
            this.Hide();
            cForm.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contact cForm = new contact("instructor", this.iid);
            this.Hide();
            cForm.ShowDialog();
            this.Show();
        }
    }
}
