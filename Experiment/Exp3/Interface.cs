using System;
interface IShape {
 double GetArea();
}
class Rectangle : IShape {
 private double length;
 private double width;
 public Rectangle(double l, double w) {
 length = l;
 width = w;
 }
 public double GetArea() {
 return length * width;
 } }
class Square : IShape {
 private double side;
 public Square(double s) {
 side = s;
 }
 public double GetArea() {
 return side * side;
 } }
class Program {
 static void Main(string[] args) {
 IShape shape = new Rectangle(5, 10);
 Console.WriteLine("Area of rectangle is {0}", shape.GetArea());
 shape = new Square(5);
 Console.WriteLine("Area of square is {0}", shape.GetArea());
 } }
