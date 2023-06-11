using System;
public static class MyExtensions {
 public static bool IsEven(this int num) {
 return num % 2 == 0;
 } }
class Program {
 static void Main(string[] args) {
 int num = 5;
 Console.WriteLine("Is {0} even? {1}", num, num.IsEven());
 num = 6;
 Console.WriteLine("Is {0} even? {1}", num, num.IsEven());
 }
}
