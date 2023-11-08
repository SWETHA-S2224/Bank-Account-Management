using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project
{

    internal class Delete
    {
        public static string connectionstring = "Data Source=ICPU0076\\SQLEXPRESS;Initial Catalog=WebApi;Persist Security Info=True;User ID=sa;Password=sql@123";

        public static void DeleteUser(string username)
        {
            using (var con = new SqlConnection(connectionstring))
            {
                using (var cmd = new SqlCommand("deleteUser", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", username);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("User detail is removed successfully!!!");
                }
            }
            Login.ShowMenu();

        }
    }
}
