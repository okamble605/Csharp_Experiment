using System;
class Employee {
 protected string name;
 protected double salary;
 public void GetData() {
 Console.Write("Enter name: ");
 name = Console.ReadLine();
 Console.Write("Enter salary: ");
 salary = double.Parse(Console.ReadLine());
 }
 public virtual void DisplaySalary() {
 Console.WriteLine("Salary of {0} is {1}", name, salary);
 } }
class Program {
 static void Main(string[] args) {
 Employee emp = new Employee();
 emp.GetData();
 emp.DisplaySalary();
 } }
