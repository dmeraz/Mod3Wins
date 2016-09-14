using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Wins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number and hit enter.");

            int luckyNum = int.Parse(Console.ReadLine());

            while (true)
            {
                if (luckyNum % 3 != 0)
                {
                    Console.WriteLine("You lost. Try again.");
                    int newNum = int.Parse(Console.ReadLine());

                    if (newNum % 3 == 0)
                    {
                        Console.WriteLine("You win!");
                        break;
                    }
                }

                else
                {
                    Console.WriteLine("You win!");
                    break;
                }

            }
        }
    }
}

