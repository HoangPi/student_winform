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
    public partial class courseView : Form
    {
        private DataSet ds = new DataSet();
        private string cid;
        public courseView(string courseid)
        {
            InitializeComponent();
            this.cid= courseid;
            
        }

        private void courseView_Load(object sender, EventArgs e)
        {
            ds.Clear();
            string query = $"select * from courseDetail where cid={this.cid}";
            SqlDataAdapter adapter = new SqlDataAdapter(query,GlobalVars.connection);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
            if (ds.Tables[0].Rows.Count <= 0) updateScoreBtn.Enabled = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                stdNameInput.Text = row.Cells[8].Value.ToString();
                if (row.Cells[3].Value.ToString() != "")
                {
                    score1Input.ReadOnly= true;
                    score2Input.ReadOnly= true;
                    updateScoreBtn.Enabled = false;
                    score1Input.Text = row.Cells[3].Value.ToString();
                    score2Input.Text = row.Cells[4].Value.ToString();
                }
                else
                {
                    score1Input.ReadOnly= false;
                    score2Input.ReadOnly= false;
                    updateScoreBtn.Enabled = true;
                    if (ds.Tables[0].Rows.Count <= 0) updateScoreBtn.Enabled = false;
                }
            }
            catch { }
        }

        private void updateScoreBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            SqlCommand cmd = new SqlCommand("add_score",GlobalVars.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@score1",SqlDbType.Int) { Value = score1Input.Text});
            cmd.Parameters.Add(new SqlParameter("@score2", SqlDbType.Int) { Value=score2Input.Text});
            cmd.Parameters.Add(new SqlParameter("@sid", SqlDbType.Int) { Value = row.Cells[7].Value.ToString() });
            cmd.Parameters.Add(new SqlParameter("@cid", SqlDbType.Int) { Value = this.cid });
            try
            {
                cmd.ExecuteNonQuery();
                this.courseView_Load(sender, e);
                /*ds.Clear();
                string query = $"select * from courseDetail where cid={this.cid}";
                SqlDataAdapter adapter = new SqlDataAdapter(query, GlobalVars.connection);
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Refresh();*/
            }
            catch(Exception ex)
            {
                label3.Text = ex.Message;
            }
        }
    }
}
