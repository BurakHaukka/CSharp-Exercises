using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Implement an application that can handle different shapes (e.g. Circle and Rectangle).
 * Create an abstract Shape class from which other shape classes inherit. For the Shape class,
 * define the property name of the shape (Name) and two abstract methods: Area and Circumference (area and circumference).
 * Inherit the Circle and Rectangle classes from the Shape class and implement the Area and Circumference methods.
 * Create a Shapes class and inside it a List data structure where shapes can be added. 
 * Implement the main program where you use the Shapes class, 
 * create a few different shapes and add them to the List data structure in the Shapes class.
 * Finally, in the main program, go through the List data structure of the Shapes class and print all the shapes it contains.
 */
namespace T42
{
    internal class Program
    {
        public abstract class Shape 
        {
            public string Name { get; set; }

            public abstract double Area();
            public abstract double Circumference();
        }

        public class Shapes
        {
            public List<string> ShapesList { get; set; }

            public Shapes() 
            {
                ShapesList = new List<string>();
            }
        }



        public class Square : Shape
        {
            public double edge { get; set; }

            public override double Area() 
            {
                
                double area = edge * edge;
                return area;
            }

            public override double Circumference() 
            {
                
                double circum = 4 * edge;
                return circum;
            }

            public string ToString()
            {
                return $"Name = {Name} Edge = {edge} Area = {Area()} Circumference = {Circumference()}\n";
            }
        }

        public class Rectangle : Shape 
        {
            public double edge1 { get; set; }
            public double edge2 { get; set; }

            public override double Area()
            {
               double area = edge1 * edge2;
               return area;
            }

            public override double Circumference()
            {
               double circum = (2 * edge2) + (2 * edge1);
               return circum;
            }

            public string ToString()
            {
                return $"Name = {Name} Width = {edge1} Height = {edge2} Area = {Area()} Circumference = {Circumference()}\n";
            }
        }

        public class Circle : Shape
        {
            public double radius { get; set; }

            public override double Area()
            {
                double area = Math.PI * radius;
                return Math.Round(area, 2);
            }

            public override double Circumference()
            {
                double circum = 2 * Math.PI * radius;
                return Math.Round(circum, 2);
            }

            public string ToString() 
            {
                return $"Name = {Name} Radius = {radius} Area = {Area()} Circumference = {Circumference()}\n";
            }
        }

        static void Main(string[] args)
        {
            Square square1 = new Square() { Name = "Square 1", edge = 2.5 };
            square1.Area();
            square1.Circumference();

            Square square2 = new Square() { Name = "Square 2", edge = 5.0 };
            square2.Area();
            square2.Circumference();

            Square square3 = new Square() { Name = "Square 3", edge = 7.0 };
            square3.Area();
            square3.Circumference();

            Rectangle rectangle1 = new Rectangle() { Name = "Rectangle 1", edge1 = 2.5, edge2 = 1.0 };
            rectangle1.Area();
            rectangle1.Circumference();

            Rectangle rectangle2 = new Rectangle() { Name = "Rectangle 2", edge1 = 20, edge2 = 10 };
            rectangle2.Area();
            rectangle2.Circumference();

            Rectangle rectangle3 = new Rectangle() { Name = "Rectangle 3", edge1 = 5.5, edge2 = 2.0 };
            rectangle3.Area();
            rectangle3.Circumference();

            Circle circle1 = new Circle() { Name = "Circle 1", radius = 1.0 };
            circle1.Area();
            circle1.Circumference();

            Circle circle2 = new Circle() { Name = "Circle 2", radius = 3.0 };
            circle2.Area();
            circle2.Circumference();

            Circle circle3 = new Circle() { Name = "Circle 3", radius = 4.0 };
            circle3.Area();
            circle3.Circumference();

            Shapes Shapes = new Shapes();
            //Console.WriteLine(square1.ToString());
            //string sq1 = square1.ToString();
            Shapes.ShapesList.Add(square1.ToString());
            Shapes.ShapesList.Add(square2.ToString());
            Shapes.ShapesList.Add(square3.ToString());

            Shapes.ShapesList.Add(rectangle1.ToString());
            Shapes.ShapesList.Add(rectangle2.ToString());
            Shapes.ShapesList.Add(rectangle3.ToString());

            Shapes.ShapesList.Add(circle1.ToString());
            Shapes.ShapesList.Add(circle2.ToString());
            Shapes.ShapesList.Add(circle3.ToString());

            foreach (var shape in Shapes.ShapesList) 
            {
                Console.WriteLine(shape);
            }

        }
    }
}
