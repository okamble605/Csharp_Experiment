using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication8
{
 class uni {
 private int number1;
 private int number2;
 public uni(int num1, int num2)
 {
 number1 = num1;
 number2 = num2;
 }
 public void ShowData()
 {
 Console.WriteLine("The Numbers are: " + number1 + " and " + number2);
 }
 public static uni operator -(uni opr)
 {
 uni obj = new uni(5, 6);
 obj.number1 = -opr.number1;
 obj.number2 = -opr.number2;
 return obj;
 }
 }
 class Program {
 static void Main(string[]) {
 uni opr1 = new uni(20, 30);
 Console.WriteLine("Before Operator Overloading");
 opr1.ShowData();
 uni opr2 = new uni(10, 15);
 opr2 = -opr1; // operator() will call
 Console.WriteLine("---------------------------");
 Console.WriteLine("After Operator Overloading");
 opr2.ShowData();
 Console.ReadLine();
 }
 }
}
