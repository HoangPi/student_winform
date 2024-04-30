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
    public partial class contact : Form
    {
        private string role;
        private int userid;
        private string phone;
        private string address;
        private string email;
        public contact(string userrole, int id)
        {
            InitializeComponent();
            this.role = userrole;
            this.userid = id;
            
        }

        private void contact_Load(object sender, EventArgs e)
        {
            string db;
            string i;
            if (role == "instructor") { db = "contact_ins"; i = "iid"; }
            else if (role == "student") { db = "contact_st"; i = "sid"; }
            else { db = "contact_mg"; i = "mid"; }
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter($"select * from {db} where {i}={this.userid}", GlobalVars.connection);
            adapter.Fill(ds);
            this.phone = ds.Tables[0].Rows[0][1].ToString();
            this.email = ds.Tables[0].Rows[0][2].ToString();
            this.address = ds.Tables[0].Rows[0][3].ToString();
            phoneInput.Text = this.phone;
            emailInput.Text = this.email;
            addressInput.Text = this.address;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("update_contact", GlobalVars.connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(new SqlParameter("@role",SqlDbType.VarChar) { Value=this.role });
            sqlCommand.Parameters.Add(new SqlParameter("@userid", SqlDbType.Int) { Value=this.userid});
            sqlCommand.Parameters.Add(new SqlParameter("@phone", SqlDbType.VarChar) { Value = phoneInput.Text });
            sqlCommand.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar) { Value = emailInput.Text });
            sqlCommand.Parameters.Add(new SqlParameter("@address", SqlDbType.VarChar) { Value = addressInput.Text });
            try
            {
                sqlCommand.ExecuteNonQuery();
                this.Refresh();
                label4.Text = "Status: Success";
            }
            catch (Exception ex)
            {
                label4.Text= ex.Message;
            }
        }
    }
}
