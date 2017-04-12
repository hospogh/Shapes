using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : IShape
    {
        public int Radius { get; set; }

        public double Area
        {
            get
            {
                return GetArea();
            }
        }

        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public  double GetArea()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }

        public  double GetPerimeter()
        {
            return 2 * Math.PI * this.Radius;
        }
    }
}
