using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._10._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("System will help you find prime numbers within your selected range:\n");
            Console.Write("---------------------------------------------------:\n\n");
            
            Console.Write("Please enter first number of range: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Now, eneter second number of range : ");
            int second = int.Parse(Console.ReadLine());
            Console.Write("The prime numbers between " + first+ " and " + second + " are ");
            Console.Write("\n\n");

            for (int begin = first; begin <= second; begin++)
            {
                int sum = 0;
                
                for (int i = 2; i <= begin / 2; i++)
                {
                    if (begin % i == 0)
                    {
                        sum++;
                        break;
                    }
                }

                if (sum == 0 && begin != 1)
                    Console.Write("{0} ", begin);

            }
            
            Console.ReadLine();
        }
    }
}
