using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape rect = new Rectangle(4 ,5);
            Shape circle = new Circle(6);
            Shape triangle = new Triangle(4, 4, 4);

            List<Shape> shapes = new List<Shape>();
            shapes.Add(rect);
            shapes.Add(circle);
            shapes.Add(triangle);

            foreach(Shape shape in shapes)
            {
                shape.Print();
            }
        }
    }
}
