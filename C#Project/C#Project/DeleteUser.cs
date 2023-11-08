using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project
{
    internal class DeleteUser 
    {
        public static string connectionstring = "Data Source=ICPU0076\\SQLEXPRESS;Initial Catalog=WebApi;Persist Security Info=True;User ID=sa;Password=sql@123";
        public static int acc_num;
        public static void Deleteuser()
        {
            Console.WriteLine("Enter the account number that you want to delete : ");
            acc_num=Convert.ToInt32(Console.ReadLine());
                using (var con = new SqlConnection(connectionstring))
                {
                    using (var cmd = new SqlCommand("Admindelete", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@acc_num", acc_num);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("User detail is removed successfully!!!");
                    }
                }
            AdminMenu.ShowMenu();
            }
    }
}
