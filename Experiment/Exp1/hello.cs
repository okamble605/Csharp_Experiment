using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello From C#");
            Console.WriteLine("It is Demo");
            int a, b, c;
            a = 10;
            b = 12;
            c = a + b;
            Console.WriteLine("Add :"+c);
            Console.WriteLine("Add of {0} and {1} is {2}",a,b,c);

            Console.WriteLine("Enter Value Of a");
            a= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value Of b");
            String bn = Console.ReadLine();
            b= Convert.ToInt32(bn);

            c = a * b;
            Console.WriteLine("Multiplication of a and b :"+c);
            Console.WriteLine("Multiplication of {0} and {1} is {2}", a, b, c);

            Console.Read();
        }
    }
}
