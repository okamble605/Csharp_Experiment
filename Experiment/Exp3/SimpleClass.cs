using System;
class Rectangle {
 private double length;
 private double width;
 public Rectangle(double l, double w) {
 length = l;
 width = w;
 }
 public double GetArea() {
 return length * width;
 }
 public double GetPerimeter() {
 return 2 * (length + width);
 } }
class Program {
 static void Main(string[] args) {
 Rectangle rect = new Rectangle(5, 10);
 Console.WriteLine("Area of rectangle is {0}", rect.GetArea());
 Console.WriteLine("Perimeter of rectangle is {0}", rect.GetPerimeter());
 } }
