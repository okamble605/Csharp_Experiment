using System;
namespace WriteOnlyMethodExample{
 class Student {
 private string name;
 private int rollNo;
 public string Name {
 set { name = value; }
 }
 public int RollNo {
 set { rollNo = value; }
 }
 public void DisplayInfo() {
 Console.WriteLine("Name: " + name);
 Console.WriteLine("Roll No: " + rollNo);
 } }
 class Program {
 static void Main(string[] args) {
 Student student = new Student();
 Console.Write("Enter Name: ");
 student.Name = Console.ReadLine();
 Console.Write("Enter Roll No: ");
 student.RollNo = int.Parse(Console.ReadLine());
 student.DisplayInfo();
 } } }
