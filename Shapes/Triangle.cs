using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle : Shape
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public Triangle(int a, int b, int c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        
        public override double GetArea()
        {
            return -1;
        }

        public override double GetPerimeter()
        {
            return this.A + this.B + this.C;
        }
    }
}
