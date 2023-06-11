using System;
class MyClass {
 private int no;
 public MyClass(int n) {
 no = n;
 }
 public int No {
 get {
 return no;
 } } }
class Program {
 static void Main(string[] args) {
 MyClass myObj = new MyClass(42);
 Console.WriteLine("My number is: " + myObj.No);
 } }
