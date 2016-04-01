using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Write a number for x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write a number for y");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("///////////////////////");
            Console.WriteLine("// Choose a option //");
            Console.WriteLine("///////////////////////");
            Console.WriteLine("1 - Addition.");
            Console.WriteLine("2 - Subtration.");
            Console.WriteLine("3 - Multiplication.");
            Console.WriteLine("4 - Division.");
            int z = Convert.ToInt32(Console.ReadLine());
            switch (z)
            {
                case 1:
                    Console.WriteLine("////////////////////");
                    Console.WriteLine("// Result //");
                    Console.WriteLine("////////////////////");
                    Console.WriteLine(add(x, y));
                    break;

                case 2:
                    Console.WriteLine("////////////////////");
                    Console.WriteLine("// Result //");
                    Console.WriteLine("////////////////////");
                    Console.WriteLine(sub(x, y));
                    break;

                case 3:
                    Console.WriteLine("////////////////////");
                    Console.WriteLine("// Result //");
                    Console.WriteLine("////////////////////");
                    Console.WriteLine(mul(x, y));
                    break;

                case 4:
                    Console.WriteLine("////////////////////");
                    Console.WriteLine("// Result //");
                    Console.WriteLine("////////////////////");
                    Console.WriteLine(div(x, y));
                    break;

                default:
                    Console.WriteLine("Wrong Input..!!");
                    break;
            }
            Console.ReadKey(true);

        }
        public static int add(int x, int y)
        {
            return x + y;
        }

        public static int sub(int x, int y)
        {
            if (x > y)
                return x - y;
            return y - x;
        }

        public static int mul(int x, int y)
        {
            return x * y;
        }

        public static int div(int x, int y)
        {
            return x / y;
        }
    }
}
