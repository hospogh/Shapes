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
            IShape rect = new Rectangle(4 ,5);
            IShape circle = new Circle(6);
            IShape triangle = new Triangle(4, 4, 4);

            List<IShape> shapes = new List<IShape>();
            shapes.Add(rect);
            shapes.Add(circle);
            shapes.Add(triangle);

            foreach(IShape shape in shapes)
            {
                Console.WriteLine(shape.GetArea()+ "  "+ shape.GetPerimeter());
            }
        }
    }
}
