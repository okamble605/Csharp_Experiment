using System;
interface ICollegeStaff {
void GetDetails();
void DisplayDetails();
}
public class CollegeStaff : ICollegeStaff {
protected string name;
protected int age;
protected string designation;
public void GetDetails() {
 Console.Write("Enter name: ");
 name = Console.ReadLine();
 Console.Write("Enter age: ");
 age = int.Parse(Console.ReadLine());
 Console.Write("Enter designation: ");
 designation = Console.ReadLine();
}
public void DisplayDetails() {
Console.WriteLine("\n\t");
 Console.WriteLine("Name: " + name);
 Console.WriteLine("Age: " + age);
 Console.WriteLine("Designation: " + designation);
} }
interface ICollegeTeacher : ICollegeStaff {
void GetTeacherDetails();
void DisplayTeacherDetails();
}
public partial class CollegeTeacher : CollegeStaff, ICollegeTeacher {
protected string department;
public void GetTeacherDetails() {
 GetDetails();
 Console.Write("Enter department: ");
 department = Console.ReadLine();
}
public void DisplayTeacherDetails() {
 DisplayDetails();
 Console.WriteLine("Department: " + department);
} }
class Program {
static void Main(string[] args) {
CollegeTeacher teacher = new CollegeTeacher();
teacher.GetTeacherDetails();
teacher.DisplayTeacherDetails();
Console.ReadLine();
} }
