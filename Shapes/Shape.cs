using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
        public  double Area
        {
            get
            {
                return GetArea();
            }
        }

        public void Print()
        {
            Console.WriteLine("Area is: {0}, Perimeter is: {1}", GetArea(), GetPerimeter());
        }
    }
}
