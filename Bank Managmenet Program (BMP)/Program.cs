using System;
using System.Data.SqlClient;
using System.Linq;


namespace Bank_Managmenet_Program__BMP_
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString;
            SqlConnection connect;
            SqlCommand command;
            SqlDataReader reader;
            String sql, Output = "";
            sql = "Select x, x from table";
            connectionString = @"Data Source=ANDREAS-KRUSE-G;Initial Catalog=BankManagement;Integrated Security=True;Pooling=False";
            connect = new SqlConnection(connectionString);
            bool usercheck = false;
            bool PassCheck = false;
            int userNum = 0;
            string user = "";
            string passWord;
            string[] users = { "Andreas", "Daniel", "Emil", "admin" };
            string[] userPass = { "1234", "4321", "54321", "admin" };
            WelcomeInterface();

            SelectionInterface();


            void WelcomeInterface()
            {
                Console.WriteLine("Welcome to Bank of Pride. \n\nPlease enter your login name");
                while (!usercheck)
                {
                    connect.Open();
                    user = Console.ReadLine();
                    userNum = Array.IndexOf(users, user);
                    if (user == users.ElementAt(userNum))
                    {
                        usercheck = true;
                    }

                }
                Console.WriteLine("\nLogin name is correct\n\nPlease enter your password");
                while (!PassCheck)
                {
                    passWord = Console.ReadLine();
                    if (passWord == userPass[userNum])
                    {
                        PassCheck = true;
                    }
                }
                Console.WriteLine("Pasword is correct, press any key to continue");
                Console.ReadKey();
            }

            void SelectionInterface()
            {
                Console.Clear();

                Console.WriteLine("\nWelcome " + user + "\n\nPlease enter the number of the action you would like to take\n" +
                                                           "------------------------------------------------------------");
                Console.WriteLine("1. Deposit cash \n2. Withdraw cash \n3. Check your balance \n4. Take a loan \n5. Check the status of your loan (if you got a loan)\n" +
                    "------------------------------------------------------------");
                ConsoleKeyInfo selection = Console.ReadKey();
                switch (selection.Key)
                {
                    case ConsoleKey.D1:

                    case ConsoleKey.D2:

                    case ConsoleKey.D3:

                    case ConsoleKey.D4:

                    case ConsoleKey.D5:

                    default:
                        break;
                }
            }
        }
    }
}
