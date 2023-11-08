using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project
{
    internal class AdminModify
    {
        public static string connectionstring = "Data Source=ICPU0076\\SQLEXPRESS;Initial Catalog=WebApi;Persist Security Info=True;User ID=sa;Password=sql@123";
        public static void GetUserByAcc()
        {
            using (var con = new SqlConnection(connectionstring))
            {
                using (var cmd = new SqlCommand("showDetailsUser", con))
                {
                    Console.WriteLine("Enter the account number that you would like to make changes : ");
                    int acc = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("The account details is :");

                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@acc_num", acc);

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
                            ModifyName(acc);
                        }
                    }
                }
            }

        }
        public static void Modify()
        {
            Console.WriteLine("Only the username and bank branch can be able to change by the admin!");
            Console.WriteLine("If you want to change the username choose 0 or else choose 1");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 0:
                    GetUserByAcc();
                    break;
                case 1:
                    GetUserByAccnew();
                    break;
            }
        }
        public static void ModifyName(int acc)
        {
            using (var con = new SqlConnection(connectionstring))
            {
                using (var cmd = new SqlCommand("UpdateUserName", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    Console.WriteLine("Enter the new user name : ");
                    string name = Console.ReadLine();
                    cmd.Parameters.AddWithValue("@acc_num", acc);
                    cmd.Parameters.AddWithValue("@user_name", name);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("User name is updated successfully!!!");
                }
            }
            AdminMenu.ShowMenu();

        }
        public static void ModifyBranch(int acc)
        {

            using (var con = new SqlConnection(connectionstring))
            {
                using (var cmd = new SqlCommand("Updatebranch", con))
                {
                    string name;

                    Console.WriteLine("Enter the new branch name : ");
                    name=Console.ReadLine();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@acc_num", acc);
                    cmd.Parameters.AddWithValue("@bank_branch", name);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("User branch name is updated successfully!!!");
                }
            }
            AdminMenu.ShowMenu();
        }
        public static void GetUserByAccnew()
        {
            using (var con = new SqlConnection(connectionstring))
            {
                using (var cmd = new SqlCommand("showDetailsUser", con))
                {
                    Console.WriteLine("Enter the account number that you would like to make changes : ");
                    int acc = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("The account details is :");

                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@acc_num", acc);

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
                            ModifyBranch(acc);
                        }
                    }
                }
            }
        }
    }
}
