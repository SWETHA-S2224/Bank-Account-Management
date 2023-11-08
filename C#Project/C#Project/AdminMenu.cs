using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project
{
    internal class AdminMenu
    {
        public static void AdminMenuPage()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Choose \n 1.View all account details \n 2.Modify user details \n 3.Add new user details \n 4.Delete the user \n 5.Exit \n 6.Login again");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ViewAll.ViewAlls();
                    break;
                case 2:
                    AdminModify.Modify();
                    Console.WriteLine("************************************");
                    break;
                case 3:
                    Admininsert.AddUser();
                    break;
                case 4:
                    DeleteUser.Deleteuser();
                    break;
                case 5:
                    ExitAdmin.Exit();
                    break;
                case 6:
                    Views.View();
                    break;
                default:
                    Console.WriteLine("Please choose the valid option");
                    AdminMenuPage();
                    break;
            }
        }
        public static void ShowMenu()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Would you like to continue (Y / N)");
            char choice = Convert.ToChar(Console.ReadLine());
            if (choice == 'Y' || choice =='y')
            {
                AdminMenu.AdminMenuPage();
            }
            else if (choice == 'N' || choice == 'n')
            {
                Console.WriteLine("Thank You! Have a Good Day");
            }
            else
            {
                Console.WriteLine("Please click the correct option");
                ShowMenu();
            }
        }
    }
}
