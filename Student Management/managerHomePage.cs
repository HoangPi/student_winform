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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (addNewStd newstd = new addNewStd())
            {
                newstd.ShowDialog();
            }
            this.managerHomePage_Load(sender, e);
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (addInstructor newIns = new addInstructor())
            {
                newIns.ShowDialog();
            }
            this.managerHomePage_Load(sender, e);
            this.Show();
        }

        private void managerHomePage_Load(object sender, EventArgs e)
        {
            string query = "select * from student_detail";
            SqlDataAdapter adapter = new SqlDataAdapter(query, GlobalVars.connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            studentSheet.DataSource = ds.Tables[0];
            studentSheet.Refresh();
            //Get all instructor
            query = "SELECT INSTRUCTOR.Iid, Fullnameins, Username " +
                ", Phone, Email, Address " +
                "FROM INSTRUCTOR " +
                "LEFT JOIN CONTACT_INS ON INSTRUCTOR.Iid = CONTACT_INS.Iid";
            adapter = new SqlDataAdapter(query, GlobalVars.connection);
            ds = new DataSet();
            adapter.Fill(ds);
            instructorSheet.DataSource = ds.Tables[0];
            instructorSheet.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using(resetPassword resetForm = new resetPassword())
            {
                this.Hide();
                resetForm.ShowDialog();
                this.managerHomePage_Load(sender, e);
                this.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (addCourse addCourseForm = new addCourse())
            {
                this.Hide();
                addCourseForm.ShowDialog();
                this.managerHomePage_Load(sender, e);
                this.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (courseManager courseManager = new courseManager())
            {
                this.Hide();
                courseManager.ShowDialog();
                this.managerHomePage_Load(sender, e);
                this.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (removeStdFromCourse removeStdFrom = new removeStdFromCourse())
            {
                this.Hide();
                removeStdFrom.ShowDialog();
                this.managerHomePage_Load(sender, e);
                this.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            contact cForm = new contact("manager", Int32.Parse(this.userID));
            this.Hide();
            cForm.ShowDialog();
            this.managerHomePage_Load(sender, e);
            this.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            warningForm wForm = new warningForm();
            this.Hide();
            wForm.ShowDialog();
            this.managerHomePage_Load(sender, e);
            this.Show();
        }
    }
}
