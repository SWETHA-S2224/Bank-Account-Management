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
    }
}
