using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project
{
    internal class ExitAdmin
    {
        public static void Exit()
        {
            Console.WriteLine("Make sure that you want to exit or want to stay in the application");
            Console.WriteLine("To continue choose 0 \n To exit choose 1");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 0:
                    Console.WriteLine("Thanks for choosing");
                    AdminMenu.AdminMenuPage();
                    break;
                case 1:
                    Console.WriteLine("Thank you!Have a good day!");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
