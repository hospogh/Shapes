using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * this.Radius;
        }
    }
}
