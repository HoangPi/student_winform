using System;
using System.Collections;
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
    public partial class managerHomePage : Form
    {
        private string userName;
        private string userID;
        private string role;
        private ArrayList studentList;
        private ArrayList instructorList;
        public managerHomePage(string username, string userid, string ro)
        {
            InitializeComponent();
            this.userID = userid;
            this.userName = username;
            this.role = ro;
            //Get all students
            string query = "SELECT Student.Sid, Fullname, Dob, Gender, Cccd, Year_start, Username, " +
                "Phone, Email, Address " +
                "FROM STUDENT " +
                "left JOIN CONTACT_ST ON STUDENT.Sid = CONTACT_ST.Sid";
            SqlCommand cmd = new SqlCommand(query,GlobalVars.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            studentSheet.DataSource = ds.Tables[0];
            studentSheet.Refresh();
            //Get all instructor
            query = "SELECT INSTRUCTOR.Iid, Fullnameins, Username " +
                ", Phone, Email, Address " +
                "FROM INSTRUCTOR " +
                "LEFT JOIN CONTACT_INS ON INSTRUCTOR.Iid = CONTACT_INS.Iid";
            cmd = new SqlCommand(query, GlobalVars.connection);
            adapter = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds);
            instructorSheet.DataSource = ds.Tables[0];
            instructorSheet.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (addNewStd newstd = new addNewStd())
            {
                newstd.ShowDialog();
            }
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (addInstructor newIns = new addInstructor())
            {
                newIns.ShowDialog();
            }
            this.Show();
        }

        private void managerHomePage_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using(resetPassword resetForm = new resetPassword())
            {
                this.Hide();
                resetForm.ShowDialog();
                this.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (addCourse addCourseForm = new addCourse())
            {
                this.Hide();
                addCourseForm.ShowDialog();
                this.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (courseManager courseManager = new courseManager())
            {
                this.Hide();
                courseManager.ShowDialog();
                this.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (removeStdFromCourse removeStdFrom = new removeStdFromCourse())
            {
                this.Hide();
                removeStdFrom.ShowDialog();
                this.Show();
            }
        }
    }
}
