using System;
public class Calculator
{
 public int Add(int num1, int num2)
 {
 return num1 + num2;
 }
 public float Add(float num1, float num2)
 {
 return num1 + num2;
 }
 public int Add(int num1, int num2, int num3)
 {
 return num1 + num2 + num3;
 }
}
public class Program
{
 static void Main(string[] args)
 {
 Calculator calc = new Calculator();
 int sum1 = calc.Add(1, 2);
 Console.WriteLine("Sum of 1 and 2 is " + sum1);
 float sum2 = calc.Add(1.5f, 2.5f);
 Console.WriteLine("Sum of 1.5 and 2.5 is " + sum2);
 int sum3 = calc.Add(1, 2, 3);
 Console.WriteLine("Sum of 1, 2, and 3 is " + sum3);
 }
}
