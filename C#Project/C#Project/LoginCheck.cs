using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project
{
    internal class LoginCheck
    {
        public static string connectionstring = "Data Source=ICPU0076\\SQLEXPRESS;Initial Catalog=WebApi;Persist Security Info=True;User ID=sa;Password=sql@123";
        public static string username;
        public static string password;
        public static void UserInput()
        {
            Console.WriteLine("Enter the username : ");
            username = Console.ReadLine();
            Console.WriteLine("Enter the password : ");
            password = Console.ReadLine();
        }
        public static void logincheck()
        {

            using (var con = new SqlConnection(connectionstring))
            {
                using (var cmd = new SqlCommand("select dbo.loginCheck(@username,@pwd)", con))
                {
                    cmd.Parameters.AddWithValue("@username", LoginCheck.username);
                    cmd.Parameters.AddWithValue("@pwd", LoginCheck.password);
                    con.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count == 1)
                    {
                        Console.WriteLine("welcome "+ username +"!!!");
                        Login.ShowMenu();
                    }
                    else
                    {
                        Console.WriteLine("User profile is not available,Register Yourself");
                        Console.WriteLine("Choose \n 1.Register Yourself \n 2.Exit");
                        int options = Convert.ToInt32(Console.ReadLine());
                        switch (options)
                        {
                            case 1:
                                Register.RegisterationDetail();
                                break;

                            case 2:
                                Console.WriteLine("COME AGAIN!!!");
                                Console.WriteLine("***********************************");
                                Environment.Exit(0);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }
        //public static void Delete(string username)
        //{
        //    using(var con = new SqlConnection(connectionstring)) 
        //    {
        //        using(var cmd=new SqlCommand("deleteUser",con))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@username",username);
        //            con.Open();
        //            cmd.ExecuteNonQuery();
        //            Console.WriteLine("User detail is removed successfully!!!");
        //        }
        //    }
        //    Login.ShowMenu();

        //}
    }
}
