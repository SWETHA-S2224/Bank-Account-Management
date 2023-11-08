using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace C_Project
{
    internal class Withdraw : LoginCheck
    {
        public static int withdraw;
        public static void Withdrawal()
        {

            using (var con = new SqlConnection(connectionstring))
            {
                using (var cmd = new SqlCommand("select dbo.balance(@username)", con))
                {
                    cmd.Parameters.AddWithValue("@username",username);
                    con.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    Console.WriteLine("Your account balance is : " + count);
                    Console.WriteLine("Enter the amount you want to withdraw : ");
                    withdraw = Convert.ToInt32(Console.ReadLine());
                    if(withdraw <= count)
                    {
                        Balance(withdraw);
                        Console.WriteLine("Amount is withdrawn successfully!!!");
                    
                    }
                    else
                    {
                        Console.WriteLine("Amount should be less than or equal to balance amount!!!");
                        Withdrawal();
                    }
                }
            }
            Login.ShowMenu();
        }
        public static void Balance(int withdraw)
        {
            using (var con = new SqlConnection(connectionstring))
            {
                using (var cmd = new SqlCommand("withdrawDetail", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@user_name",LoginCheck.username);
                    cmd.Parameters.AddWithValue("@Balance",withdraw );
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
