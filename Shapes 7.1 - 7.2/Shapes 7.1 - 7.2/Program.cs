using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_7._1___7._2
{
    class Program
    {
        public abstract class Shape
        {

        }

        public class Round : Shape
        {

        }

        public class Cornery : Shape
        {

        }

        public class Triangle : Cornery
        {

            public int bas { get; set; }
            public int höjd { get; set; }

            public int Area()
            {
                int area = (bas * höjd) / 2;
                return area;
            }
            public static void PrintAllShapes(List<Shape> listan)
            {
                //måste ändras, hela objekt kan ej skrivas ut
                foreach (Shape item in listan)
                {
                    double area = item.Area();
                    Console.WriteLine(area);
                }
                listan.Clear();
            }


        }

        public class Circle : Round
        {
            public double radius { get; set; }

            public double Area()
            {
                double area = radius * radius * Math.PI;
                return area;
            }

        }

        public class Rectangle : Cornery
        {
            public int bas { get; set; }
            public int höjd { get; set; }

            public int Area()
            {
                int area = bas * höjd;
                return area;
            }

        }

        public class Oval : Round
        {

        }

        static void Main(string[] args)
        {
            List<Shape> allShapes = new List<Shape>();

            while(true)
            {
                Console.WriteLine("Select (T)riangle, (C)ircle, (R)ectangle, or (D)one.");

                string input = Console.ReadLine();

                switch(input)
                {
                    case "T":
                        {
                            Console.WriteLine("Enter the base and then the height of the triangle.");
                            Triangle triangle = new Triangle();
                            triangle.bas = int.Parse(Console.ReadLine());
                            triangle.höjd = int.Parse(Console.ReadLine());

                            triangle.Area();
                            allShapes.Add(triangle);
                            break;

                        }
                    case "R":
                        {
                            Console.WriteLine("Enter the base and then the height of the rectangle.");
                            Rectangle rectangle = new Rectangle();
                            rectangle.bas = int.Parse(Console.ReadLine());
                            rectangle.höjd = int.Parse(Console.ReadLine());

                            rectangle.Area();
                            allShapes.Add(rectangle);
                            break;
                        }
                    case "C":
                        {
                            Console.WriteLine("Enter the radius of the circle.");
                            Circle circle = new Circle();
                            circle.radius = double.Parse(Console.ReadLine());

                            
                            allShapes.Add(circle);
                            break;
                        }
                    case "D":
                        {
                            PrintAllShapes(allShapes); 

                            break;
                        }
                }

            }

        }
    }
}
