using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;

class Program
        {
           

                Console.WriteLine("Enter a number:");
                int number = Convert.ToInt32(Console.ReadLine());
                switch (number % 2)
                {
                    case 0:
                        Console.WriteLine($"{number} is even.");
                        break;

                    case 1:
                        Console.WriteLine($"{number} is odd.");
                        break;

                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }

            }

        }

    }

}


