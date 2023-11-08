using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project
{
    internal class ViewAll
    {
        public static string connectionstring = "Data Source=ICPU0076\\SQLEXPRESS;Initial Catalog=WebApi;Persist Security Info=True;User ID=sa;Password=sql@123";

        public static void ViewAlls()
        {
            using (var con = new SqlConnection(connectionstring))
            {
                using (var cmd = new SqlCommand("viewall", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"Account Number :{reader["acc_num"]}," + "\n" +
                                $"User Name :{reader["user_name"]}," + "\n" +
                                $"Password :{reader["password"]}," + "\n" +
                                $"Account Balance:{reader["Balance"]}," + "\n" +
                                $"Bank Name :{reader["bank_name"]}," + "\n" +
                                $"Bank Branch :{reader["bank_branch"]}");
                            Console.WriteLine("---------------------------------------------");
                        }
                    }
                }
            }
            AdminMenu.ShowMenu();
        }
    }
}
