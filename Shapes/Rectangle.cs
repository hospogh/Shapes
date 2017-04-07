using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : Shape
    {
        private int Length { get; set; }
        private int Width { get; set; }

        public Rectangle(int length, int width)
        {
            this.Length = length;
            this.Width = width;
        }

        public override double GetArea()
        {
             return this.Length * this.Width;
        }

        public override double GetPerimeter()
        {
            return 2 * (this.Length + this.Width);
        }
    }
}
