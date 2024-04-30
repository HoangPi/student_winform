using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management
{
    public static class GlobalVars
    {
        public static readonly string guest_connection_string = "Server=desktop-9nn69eq;Database=student_management;Persist Security Info=True;User ID=unauthorized_user;Password=unauthorized_user;MultipleActiveResultSets=True;";
        public static readonly string manager_connection_string = "Data Source=DESKTOP-9NN69EQ;Initial Catalog=student_management;Integrated Security=True;Encrypt=False;MultipleActiveResultSets=True;";
        public static readonly string instructor_connection_string = "Server=desktop-9nn69eq;Database=student_management;Persist Security Info=True;User ID=instructor;Password=instructor;MultipleActiveResultSets=True;";
        public static readonly string student_connection_string = "Server=desktop-9nn69eq;Database=student_management;Persist Security Info=True;User ID=student;Password=student;MultipleActiveResultSets=True;";
        public static SqlConnection connection = new SqlConnection(guest_connection_string);
    }
}
