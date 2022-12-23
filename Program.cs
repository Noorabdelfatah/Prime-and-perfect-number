using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter last number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("the prime numbers are:");
            int sum = 0;
            {
                for (int y = a; y <= b; y++)
                {
                    for (int x = 1; x <= y; x++)
                    {
                        if (y % x == 0)
                            sum++;
                    }

                    if (sum == 2)


                    {
                        Console.WriteLine(y);

                        sum = 0;
                    }
                    else
                    {
                        sum = 0;
                        
                    }
                    Console.ReadLine();



                }









            }
        }




    }
}
