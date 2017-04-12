using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle : IShape
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public double Area
        {
            get
            {
                return GetArea();
            }
        }

        public Triangle(int a, int b, int c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        
        public  double GetArea()
        {
            return -1;
        }

        public  double GetPerimeter()
        {
            return this.A + this.B + this.C;
        }
    }
}
