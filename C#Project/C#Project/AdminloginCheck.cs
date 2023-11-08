using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project
{
    internal class AdminloginCheck
    {
        public static string connectionstring = "Data Source=ICPU0076\\SQLEXPRESS;Initial Catalog=WebApi;Persist Security Info=True;User ID=sa;Password=sql@123";

        public static void AdminCheck()
        {
            Console.WriteLine("Enter the Admin name : ");
            String admin = Console.ReadLine();
            Console.WriteLine("Enter the password : ");
            String password = Console.ReadLine();
            using (var con = new SqlConnection(connectionstring))
            {
                using (var cmd = new SqlCommand("select dbo.AdminCheck(@ad_name,@password)", con))
                {
                    cmd.Parameters.AddWithValue("@ad_name", admin);
                    cmd.Parameters.AddWithValue("@password", password);
                    con.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count == 1)
                    {
                        Console.WriteLine("Welcome "+ admin +"!!!");
                        AdminMenu.ShowMenu();
                    }
                    else
                    {
                        Console.WriteLine("Admin profile was not found!");
                        Console.WriteLine("Please check whether the admin name and password were entered correctly");
                        AdminCheck();
                    }
                }
            }

        }
    }
}
