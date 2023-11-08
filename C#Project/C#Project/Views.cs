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
       
    

