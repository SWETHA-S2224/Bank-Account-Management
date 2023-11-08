using C_Project;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Menu()
        {
            Console.WriteLine("Choose \n 1.View account details \n 2.Cash Withdrawal \n 3.Delete Account \n 4.Exit");
            Console.WriteLine("What do you Need ????");
            int options = Convert.ToInt32(Console.ReadLine());

            switch (options)
            {

                case 1:
                    ShowDetails.GetUserByName();
                    break;
                case 2:
                    Withdraw.Withdrawal();
                    break;
                case 3:
                    Delete.DeleteUser(LoginCheck.username);
                    break;
                case 4:
                    ExitUser.Exit();
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;

            }
        }
   
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the digital world!!!");
        Views.View();
        Console.WriteLine("**********************************");
    }
    }
