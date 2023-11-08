using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Xml.Linq;


namespace C_Project
{
    internal class Login 
    {
        public static string connectionstring = "Data Source=ICPU0076\\SQLEXPRESS;Initial Catalog=WebApi;Persist Security Info=True;User ID=sa;Password=sql@123";
        public static void ShowMenu()
        {
            //Program.Menu();
            Console.WriteLine("Would you like to continue (Y / N)");
            char choice = Convert.ToChar(Console.ReadLine());
            if(choice == 'Y' || choice =='y')
            {
                Program.Menu();
            }
            else if(choice == 'N' || choice == 'n')
            {
                Console.WriteLine("Thank You! Have a Good Day");
            }
        }
        //MENU OPTION : 2 --> user registeration
        //public static void RegisterationDetail()
        //{
        //    Console.WriteLine("************************************************");
        //    Console.WriteLine("For registration purpose, please give answer for the below questions!");
        //    Console.WriteLine("Enter the username : ");
        //    string username=Console.ReadLine();
        //    Console.WriteLine("Enter the password : ");
        //    string password = Console.ReadLine();
        //    Console.WriteLine("Enter the account number : ");
        //    int anum =  Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter the amount going to deposit : ");
        //    int balance = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter the bank name : ");
        //    string bname =Console.ReadLine();
        //    Console.WriteLine("Enter the bank branch name : ");
        //    string bbranch = Console.ReadLine();

        //    using (var con = new SqlConnection(connectionstring))
        //    {
        //        using (var cmd = new SqlCommand("insertuserdetail", con))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@acc_num ", anum);
        //            cmd.Parameters.AddWithValue("@user_name", username);
        //            cmd.Parameters.AddWithValue("@password", password);
        //            cmd.Parameters.AddWithValue("@Balance", balance);
        //            cmd.Parameters.AddWithValue("@bank_name", bname);
        //            cmd.Parameters.AddWithValue("@bank_branch", bbranch);
        //            con.Open();
        //            cmd.ExecuteNonQuery();
        //            Console.WriteLine("User registeration is successfully completed");
        //            Console.WriteLine("***************************************************************");
        //            ShowMenu();
        //        }
        //    }
        //}

    }
}
