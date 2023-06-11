Test Library
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace TestLibrary{
    public class Class1    {
        public void show()   {
            Console.WriteLine(" Hello From DLL ");
         }
     public int square(int a)    {
            return a*a ;
     }
    }

Console Application
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestLibrary;
namespace ConsoleApplication3
{
    class Program{
        static void Main(string[] args){
            Class1 c = new Class1();
            c.show();
            Console.WriteLine("Square is " + c.square(20));
            Console.Read();

        } } }
