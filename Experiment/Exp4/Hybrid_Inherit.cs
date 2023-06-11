using System;
public class Shape {
public virtual void Input() {
Console.WriteLine("Enter the parameters of the shape:");
}
public virtual void Output() {
 Console.WriteLine("The area of the shape is:");
} }
public class TwoDimensionalShape : Shape {
public override void Input() {
Console.WriteLine("Enter the parameters of the 2D shape:");
}
public override void Output() {
 Console.WriteLine("The area of the 2D shape is:");
} }
public partial class Circle : TwoDimensionalShape {
private double radius;
public override void Input() {
 Console.WriteLine("Enter the radius of the circle:");
 radius = double.Parse(Console.ReadLine());
}
public override void Output() {
 Console.WriteLine("The area of the circle is: " + Math.PI * radius * radius);
} }
public partial class Rectangle : TwoDimensionalShape {
private double length;
private double width;
public override void Input() {
 Console.WriteLine("Enter the length of the rectangle:");
 length = double.Parse(Console.ReadLine());
 Console.WriteLine("Enter the width of the rectangle:");
 width = double.Parse(Console.ReadLine());
}
public override void Output() {
 Console.WriteLine("The area of the rectangle is: " + length * width);
}}
class Program {
static void Main(string[] args) {
Shape circle = new Circle();
circle.Input();
circle.Output();
 Shape rectangle = new Rectangle();
 rectangle.Input();
 rectangle.Output();
} }
