using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project
{
    internal class Register
    {
        public static string connectionstring = "Data Source=ICPU0076\\SQLEXPRESS;Initial Catalog=WebApi;Persist Security Info=True;User ID=sa;Password=sql@123";

        public static string username;
        public static string password;
        public static int anum;
        public static int balance;
        public static string bname;
        public static string bbranch;
        public static void RegisterationDetail()
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("For registration purpose, please give answer for the below questions!");
            Console.WriteLine("Enter the username : ");
            username = Console.ReadLine();
            Console.WriteLine("Enter the password : ");
            password = Console.ReadLine();
            Console.WriteLine("Enter the account number : ");
            anum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the amount going to deposit : ");
            balance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the bank name : ");
             bname = Console.ReadLine();
            Console.WriteLine("Enter the bank branch name : ");
            bbranch = Console.ReadLine();

            using (var con = new SqlConnection(connectionstring))
            {
                using (var cmd = new SqlCommand("insertuserdetail", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@acc_num ", anum);
                    cmd.Parameters.AddWithValue("@user_name", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@Balance", balance);
                    cmd.Parameters.AddWithValue("@bank_name", bname);
                    cmd.Parameters.AddWithValue("@bank_branch", bbranch);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("User registeration is successfully completed");
                    Console.WriteLine("***************************************************************");
                }
            }
            Login.ShowMenu();
        }
        
    }
}
