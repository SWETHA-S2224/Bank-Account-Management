using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project
{
    internal class Views
    {
        public static string connectionstring = "Data Source=ICPU0076\\SQLEXPRESS;Initial Catalog=WebApi;Persist Security Info=True;User ID=sa;Password=sql@123";

        public static void View()
        {
            Console.WriteLine("Who is going to access now : \n Admin means please select 0 \n User means please select 1");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 0:
                    AdminloginCheck.AdminCheck();
                    break;
                case 1:
                    LoginCheck.UserInput();
                    LoginCheck.logincheck();
                    break;
                default:
                    Console.WriteLine("Please choose the valid option");
                    break;
            }
        }
    }
}
        //public static void AdminCheck()
        //{
        //    Console.WriteLine("Enter the Admin name : ");
        //    String admin = Console.ReadLine();
        //    Console.WriteLine("Enter the password : ");
        //    String password = Console.ReadLine();
        //    using (var con = new SqlConnection(connectionstring))
        //    {
        //        using (var cmd = new SqlCommand("select dbo.AdminCheck(@ad_name,@password)", con))
        //        {
        //            cmd.Parameters.AddWithValue("@ad_name", admin);
        //            cmd.Parameters.AddWithValue("@password", password);
        //            con.Open();
        //            int count = Convert.ToInt32(cmd.ExecuteScalar());
        //            if (count == 1)
        //            {
        //                Console.WriteLine("Welcome "+ admin +"!!!");
        //                AdminMenu();
        //            }
        //            else
        //            {
        //                Console.WriteLine("Admin profile was not found!");
        //                Console.WriteLine("Please check whether the admin name and password were entered correctly");
        //                AdminCheck();
        //            }
        //        }
        //    }

        //}
        //public static void AdminMenu()
        //{
        //    Console.WriteLine("What would you like to do?");
        //    Console.WriteLine("Choose \n 1.View all account details \n 2.Modify user details \n 3.Add new user details \n 4.Delete the user \n 5.Exit \n 6.Login again");
        //    int option = Convert.ToInt32(Console.ReadLine());
        //    switch (option)
        //    {
        //        case 1: ViewAll();
        //            break;
        //        case 2: Modify();
        //            Console.WriteLine("************************************");
        //            break;
        //        case 3:Admininsert.AddUser();
        //            break;
        //        case 4:DeleteUser.Deleteuser();
        //            break;
        //        case 5:ExitAdmin.Exit();
        //            break;
        //        case 6:
        //            View();
        //            break;
        //        default:
        //            Console.WriteLine("Please choose the valid option");
        //            AdminMenu();
        //            break;
        //    }
        //}
        //public static void ViewAll()
        //{
        //    using (var con = new SqlConnection(connectionstring))
        //    {
        //        using (var cmd = new SqlCommand("viewall", con))
        //        {
        //            con.Open();
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            using (var reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    Console.WriteLine($"Account Number :{reader["acc_num"]}," + "\n" +
        //                        $"User Name :{reader["user_name"]}," + "\n" +
        //                        $"Password :{reader["password"]}," + "\n" +
        //                        $"Account Balance:{reader["Balance"]}," + "\n" +
        //                        $"Bank Name :{reader["bank_name"]}," + "\n" +
        //                        $"Bank Branch :{reader["bank_branch"]}");
        //                        Console.WriteLine("---------------------------------------------");
        //                }
        //            }
        //        }
        //    }
        //   AdminMenu.ShowMenu();
        //}
        //public static void GetUserByAcc()
        //{
        //    using (var con = new SqlConnection(connectionstring))
        //    {
        //        using (var cmd = new SqlCommand("showDetailsUser", con))
        //        {
        //            Console.WriteLine("Enter the account number that you would like to make changes : ");
        //            int acc = Convert.ToInt32(Console.ReadLine());

        //            Console.WriteLine("The account details is :");

        //            con.Open();
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@acc_num",acc);

        //            using (var reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    Console.WriteLine($"Account Number :{reader["acc_num"]}," + "\n" +
        //                        $"User Name :{reader["user_name"]}," + "\n" +
        //                        $"Password :{reader["password"]}," + "\n" +
        //                        $"Account Balance:{reader["Balance"]}," + "\n" +
        //                        $"Bank Name :{reader["bank_name"]}," + "\n" +
        //                        $"Bank Branch :{reader["bank_branch"]}");
        //                    ModifyName(acc);
        //                }
        //            }
        //        }
        //    }

        //}
        //public static void Modify()
        //{
        //    Console.WriteLine("Only the username and bank branch can be able to change by the admin!");
        //    Console.WriteLine("If you want to change the username choose 0 or else choose 1");
        //    int input=Convert.ToInt32(Console.ReadLine());
        //    switch(input)
        //    {
        //        case 0:GetUserByAcc();
        //            break;
        //        case 1:
        //            GetUserByAccnew();
        //            break;
        //    }
        //}
        //public static void ReturnName(int acc)
        //{
        //    using (var con = new SqlConnection(connectionstring))
        //    {
        //        using (var cmd = new SqlCommand("select dbo.detail(@acc_num)", con))
        //        {
        //            cmd.Parameters.AddWithValue("@acc_num",acc);
        //            con.Open();
        //            var name=cmd.ExecuteScalar();
        //            Console.WriteLine("User name is "+name);
        //            string n = name.ToString();
        //            ModifyName(acc);
        //        }
        //    }
        //}
        //public static void ModifyName(int acc)
        //{
        //    //Console.WriteLine("Enter the account number that you would like to make changes : ");
        //    //int acc = Convert.ToInt32(Console.ReadLine());
        //    //Detail(acc);
        //    using (var con = new SqlConnection(connectionstring))
        //    {
        //        using (var cmd = new SqlCommand("UpdateUserName", con))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            Console.WriteLine("Enter the new user name : ");
        //            string name=Console.ReadLine();
        //            cmd.Parameters.AddWithValue("@acc_num",acc);
        //            cmd.Parameters.AddWithValue("@user_name", name);
        //            con.Open();
        //            cmd.ExecuteNonQuery();
        //            Console.WriteLine("User name is updated successfully!!!");
        //        }
        //    }
        //    AdminMenu.ShowMenu();

        //}

        //public static void Branch(int acc1)
        //{
        //    using (var con = new SqlConnection(connectionstring))
        //    {
        //        using (var cmd = new SqlCommand("select dbo.branch(@acc_num)", con))
        //        {
        //            cmd.Parameters.AddWithValue("@acc_num", acc1);
        //            con.Open();
        //            var bname = cmd.ExecuteScalar();
        //            Console.WriteLine("User bank branch is "+bname);
        //            string n = bname.ToString();
        //            ModifyBranch(acc1,n);
        //        }
        //    }
        //}

        //public static void ModifyBranch(int acc)
        //{

        //    using (var con = new SqlConnection(connectionstring))
        //    {
        //        using (var cmd = new SqlCommand("Updatebranch", con))
        //        {
        //            string name;

        //            Console.WriteLine("Enter the new branch name : ");
        //            name=Console.ReadLine();
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@acc_num", acc);
        //            cmd.Parameters.AddWithValue("@bank_branch",name);
        //            con.Open();
        //            cmd.ExecuteNonQuery();
        //            Console.WriteLine("User branch name is updated successfully!!!");
        //        }
        //    }
        //    AdminMenu.ShowMenu();
        //}
        //public static void GetUserByAccnew()
        //{
        //    using (var con = new SqlConnection(connectionstring))
        //    {
        //        using (var cmd = new SqlCommand("showDetailsUser", con))
        //        {
        //            Console.WriteLine("Enter the account number that you would like to make changes : ");
        //            int acc = Convert.ToInt32(Console.ReadLine());

        //            Console.WriteLine("The account details is :");

        //            con.Open();
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@acc_num", acc);

        //            using (var reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    Console.WriteLine($"Account Number :{reader["acc_num"]}," + "\n" +
        //                        $"User Name :{reader["user_name"]}," + "\n" +
        //                        $"Password :{reader["password"]}," + "\n" +
        //                        $"Account Balance:{reader["Balance"]}," + "\n" +
        //                        $"Bank Name :{reader["bank_name"]}," + "\n" +
        //                        $"Bank Branch :{reader["bank_branch"]}");
        //                    ModifyBranch(acc);
        //                }
        //            }
        //        }
        //    }

    

