using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication7
{
 public class operate
 {
 int a, b;
 public operate(int x, int y)
 {
 a = x; b = y;
 }
 public static operate operator *(operate ob, operate ob1)
 {
 operate r = new operate(1, 2);
 r.a = ob.a * ob1.a;
 r.b = ob.a * ob1.b;
 return r;
 }
 public void disp()
 {
 Console.WriteLine("Value of a is {0} & b is {1} :", a, b);
 }
 }
 class Program
 {
 static void Main(string[] args)
 {
 operate o = new operate(10, 20);
 Console.WriteLine("Before call of operator method");
 o.disp();
 operate o1 = new operate(30, 40);
 o1.disp();
 operate o2 = new operate(50, 60);
 o2 = o1 * o;
 Console.WriteLine("After call of operator method: ");
 o2.disp();
 Console.ReadLine();
 }
 }
}
