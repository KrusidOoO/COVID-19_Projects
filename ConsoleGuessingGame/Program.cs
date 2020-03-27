using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Now it is time for a guessing game, guess a number between 0 and 10");
            List<int> StoredInputs = new List<int> { };
            int k = 1;
            Random rnd = new Random();
            int o = Convert.ToInt32(rnd.Next(0, 10));
            int l;
            int latestInput = StoredInputs.Count()-1;
            while (k <= 3)
            {

                Console.WriteLine("Make your guess as to which number has been generated");
                l = Convert.ToInt32(Console.ReadLine());
                StoredInputs.Add(l);
                if(l==StoredInputs.ElementAt(latestInput)&&k!=1)
                {
                    Console.WriteLine("This guess is the same as your previous guess, pick a different number");
                }
                else if (l > o)
                {
                    Console.WriteLine("Your guess is higher than the generated number, try again");
                    k++;
                }
                else if (l < o)
                {
                    Console.WriteLine("Your guess is lower than the generated number, try again");
                    k++;
                }
                else if (l == o)
                {
                    Console.WriteLine("You are correct!!");
                    k = 5;
                    Console.WriteLine("Press any key to exit this fun little program");
                }
                if (k > 3)
                    Console.WriteLine("You ran out of tries, better luck next time!");
                else if (k == 3)
                    Console.WriteLine("");

            }
            Console.ReadKey();
        }
    }
}
