using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfectNumbber
{
    class Program
    {
        static bool Isperfect(int number)
        {
            int sum = 0;
            for (int z = 1; z < number; z++)
            {
                if (number % z == 0) sum = sum + 1;
            }
            if (sum == number return true;
            return false;
        }

        static void Main(string[] args)

        {
            int x, y;
            Console.WriteLine("Please enter the first number");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            y = int.Parse(Console.ReadLine());

            for (int z = x; z <= y; z++)


            {
                if (Isperfect(z)) Console.WriteLine("{0}", z);
            }
            Console.ReadKey();
        }


 
      }

